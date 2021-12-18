using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace Example4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public DateTime? Time { get; set; }

        public TimeData TimeData { get; set; } = new TimeData();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            TimeData.Day = 0;
            TimeData.Time = DateTime.Now;
            return Page();
        }

        public ActionResult OnPost(TimeData timeData)
        {
            Time = timeData.Time?.AddDays(timeData.Day);
            return Page();
        }
    }

    public class TimeData
    {
        public DateTime? Time { get; set; }
        public int Day { get; set; }
    }
}
