using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChampionShipWebSite.Models
{
    public class City
    {
        public int id_City { get; set; }
        public String Name_City { get; set; }
        public Country Country_City { get; set; }
        public DateTime Date_Created_City { get; set; }
    }
}
