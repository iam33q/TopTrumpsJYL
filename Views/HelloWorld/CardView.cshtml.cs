using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WEEK7.Views
{
    public class CardView : PageModel
    {
        private readonly ILogger<CardView> _logger;

        public CardView(ILogger<CardView> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}