using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WEEK7.Views
{
    public class GamePage : PageModel
    {
        private readonly ILogger<GamePage> _logger;

        public GamePage(ILogger<GamePage> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}