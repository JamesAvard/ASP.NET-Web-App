using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Project1.WebSite.Models;

namespace Project1.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileClubsService ClubService;
        public IEnumerable<Club> Clubs { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileClubsService clubService)
        {
            _logger = logger;
            ClubService = clubService;
        }

        public void OnGet()
        {
            Clubs = ClubService.GetClubs();
        }
    }
}
