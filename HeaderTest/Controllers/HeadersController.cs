using Microsoft.AspNetCore.Mvc;

namespace HeaderTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeadersController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            Dictionary<string, List<string>> headers = new();

            var keys = HttpContext.Request.Headers.Keys.Order().ToList();

            foreach (string key in keys)
            {
                headers.Add(key, HttpContext.Request.Headers[key].ToList()!);
            }

            return Ok(headers);
        }
    }
}
