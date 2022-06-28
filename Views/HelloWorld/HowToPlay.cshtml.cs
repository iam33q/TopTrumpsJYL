using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WEEK7.Views
{
    public class HowToPlay : PageModel
    {
        private readonly ILogger<HowToPlay> _logger;

        public HowToPlay(ILogger<HowToPlay> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}