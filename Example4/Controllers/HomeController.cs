using Microsoft.AspNetCore.Mvc;
using System;

namespace Example4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        public JsonResult Calculate(DateTime time, int day) => new(new { Result = time.AddDays(day) });
    }
}
