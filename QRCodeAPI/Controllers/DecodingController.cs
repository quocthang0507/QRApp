using System.Collections.Generic;
using System.Web.Http;

namespace QRCodeAPI.Controllers
{
	public class DecodingController : ApiController
	{
		// GET api/decoding
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/decoding/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/decoding
		public void Post([FromBody]string value)
		{
		}

		// PUT api/decoding/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/decoding/5
		public void Delete(int id)
		{
		}

	}
}
