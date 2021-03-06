﻿using QRCodeAPI.Models;
using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using ZXing;

namespace QRCodeAPI.Controllers
{
	[BasicAuthentication]
	public class DecodingController : ApiController
	{
		// GET api/decoding
		public HttpResponseMessage Get()
		{
			return Response(new StringContent("<h2>Welcome to QR Code Generator &amp Reader API</br>You must include authentication in your request.</h2>"), "text/html");
		}

		// POST api/decoding
		public HttpResponseMessage Post()
		{
			string path = Upload();
			if (path == null)
				return Response(new StringContent("<h2>There has been an error when processing your request</h2>"), "text/html");
			else
			{
				string result = Process(path);
				if (result == null)
					return Response(new StringContent("<h2>There has been an error when processing your request</h2>"), "text/html");
				return Response(new StringContent(result), "text/html");
			}
		}

		/// <summary>
		/// Response represented as a result to response client request
		/// </summary>
		/// <param name="content"></param>
		/// <param name="header"></param>
		/// <returns></returns>
		private HttpResponseMessage Response(HttpContent content, string header)
		{
			var response = new HttpResponseMessage(HttpStatusCode.OK)
			{
				Content = content
			};
			response.Content.Headers.ContentType = new MediaTypeHeaderValue(header);
			return response;
		}

		/// <summary>
		/// Upload a file from client to server and return its physical path
		/// </summary>
		/// <returns></returns>
		private string Upload()
		{
			var httpRequest = HttpContext.Current.Request;
			if (httpRequest.Files.Count == 1) // Currently only support 1 uploading file
			{
				// Put loop statement here for multiple files
				HttpPostedFile postedFile = httpRequest.Files[0];
				string filePath = HttpContext.Current.Server.MapPath("/Images/" + $@"{Guid.NewGuid()} " + postedFile.FileName);
				postedFile.SaveAs(filePath);
				return filePath;
			}
			return null;
		}

		/// <summary>
		/// Return a string that represented as a QR Code
		/// </summary>
		/// <param name="filePath"></param>
		/// <returns></returns>
		private string Process(string filePath)
		{
			try
			{
				Image image = Image.FromFile(filePath);
				var reader = new BarcodeReader();
				var result = reader.Decode((Bitmap)image);
				return result.Text;
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
