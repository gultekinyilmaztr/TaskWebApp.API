using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace TaskWebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]

        public async Task<IActionResult> GetTaskAsync()
        {
            // 5.Thread
            var mytask = new HttpClient().GetStringAsync("https://www.google.com");

            var data = await mytask;
            return Ok(data);

        }

    }
}
