using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.WebSite.Models;
using Project1.WebSite.Services;

namespace Project1.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClubsController : ControllerBase
    {
        public ClubsController(JsonFileClubsService clubService)
        {
            this.ClubService = clubService;
        }

        public JsonFileClubsService ClubService { get; }

        [HttpGet]
        public IEnumerable<Club> Get()
        {
            return ClubService.GetClubs();
        }
    }
}
