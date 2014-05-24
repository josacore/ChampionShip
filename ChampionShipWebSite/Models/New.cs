using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChampionShipWebSite.Models
{
    public class New
    {
        public int Id_New { get; set; }
        public string Title_New { get; set; }
        public string Content_New { get; set; }
        public User User_Create_New { get; set; }
        public DateTime Date_Created_New { get; set; }
        public List<tag> Tags_New { get; set; }
        public List<string> Images_News { get; set; }
    }
}
