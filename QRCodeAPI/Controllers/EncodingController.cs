using QRCodeAPI.Models;
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace QRCodeAPI.Controllers
{
	[BasicAuthentication]
	public class EncodingController : ApiController
	{
		// GET api/encoding
		public HttpResponseMessage Get()
		{
			return Response(new StringContent("<h2>Welcome to QR Code Generator &amp Reader API</br>You must include authentication in your request.</h2>"), "text/html");
		}

		// GET api/encoding/5
		public HttpResponseMessage Get(string text)
		{
			return Process(text);
		}

		// POST api/encoding
		public HttpResponseMessage Post([FromBody] string value)
		{
			return Process(value);
		}

		/// <summary>
		/// Generate QR Code from text using QRCoder library
		/// </summary>
		/// <param name="text">Content which you want to create from</param>
		/// <returns></returns>
		private Image GenerateQR(string text)
		{
			QRCodeGenerator qrGenerator = new QRCodeGenerator();
			QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
			QRCode qrCode = new QRCode(qrCodeData);
			Bitmap qrCodeImage = qrCode.GetGraphic(20);
			return qrCodeImage;
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
		/// Redirect to other url
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
		private HttpResponseMessage RedirectURL(string url)
		{
			var response = Request.CreateResponse(HttpStatusCode.Moved);
			response.Headers.Location = new Uri(url);
			return response;
		}

		/// <summary>
		/// Combine generating QR code method and responsing the client request method
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		private HttpResponseMessage Process(string text)
		{
			if (text != null)
			{
				// For saving QR Code
				string urlResult = HttpContext.Current.Server.MapPath("/Images/" + $@"{Guid.NewGuid()}.png");
				Image image = GenerateQR(text);
				image.Save(urlResult, ImageFormat.Png);
				// For returning response message
				MemoryStream memoryStream = new MemoryStream();
				image.Save(memoryStream, ImageFormat.Png);
				return Response(new ByteArrayContent(memoryStream.ToArray()), "image/png");
			}
			else
				return Response(new StringContent("<h2>There has been an error when processing your request</h2>"), "text/html");
		}
	}
}