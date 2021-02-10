using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project1.WebSite.Models
{
    public class Club
    {
        public string ClubName { get; set; }
        public string League { get; set; }
        public string StadiumName { get; set; }
        public string Img { get; set; }
        public string City  { get; set; }
        public string Capacity { get; set; }
        public string background { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Club>(this);

    }
}
