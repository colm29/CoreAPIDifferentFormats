using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XmlTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RawRequestBodyController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "Please post to api/RawRequestBody to test receiving Raw Request Body";
        }

        // POST api/values
        [HttpPost]
        public async Task<ContentResult> Post([FromBody] string body)
        {
            var requestData = body;

            var response = new ContentResult
            {
                Content = requestData,
                StatusCode = 200
            };
            return await Task.FromResult(response);
        }
    }
}
