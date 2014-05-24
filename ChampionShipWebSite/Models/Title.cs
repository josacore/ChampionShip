using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChampionShipWebSite.Models
{
    public class Title
    {
        public int Id_Title { get; set; }
        public string Name_Title { get; set; }
        public int Position_Title { get; set; }
        public Team Team_Title { get; set; }
        public DateTime Date_Created_Title { get; set; }
    }
}
