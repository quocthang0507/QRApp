using QRCoder;
using System;
using System.Collections.Generic;
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
	public class EncodingController : ApiController
	{
		// GET api/encoding
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/encoding/5
		public int Get(int id)
		{
			return id;
		}

		// POST api/encoding
		public void Post([FromBody]string value)
		{
		}

		// PUT api/encoding/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/encoding/5
		public void Delete(int id)
		{
		}

		[HttpGet]
		// api/encoding/create/5
		public HttpResponseMessage Create(string text)
		{
			// For creating QR Code
			QRCodeGenerator qrGenerator = new QRCodeGenerator();
			QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
			QRCode qrCode = new QRCode(qrCodeData);
			Bitmap qrCodeImage = qrCode.GetGraphic(20);
			// For saving QR Code
			string urlResult = HttpContext.Current.Server.MapPath("/Images/" + $@"{Guid.NewGuid()}.png");
			Image image = qrCodeImage;
			image.Save(urlResult, ImageFormat.Png);
			// For returning response
			var result = new HttpResponseMessage(HttpStatusCode.OK);
			MemoryStream memoryStream = new MemoryStream();
			image.Save(memoryStream, ImageFormat.Png);
			result.Content = new ByteArrayContent(memoryStream.ToArray());
			result.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");
			return result;
		}
	}
}
