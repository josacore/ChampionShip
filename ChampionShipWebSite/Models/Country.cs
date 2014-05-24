using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChampionShipWebSite.Models
{
    public class Country
    {
        public int id_Country { get; set; }
        public String Name_Country { get; set; }
        public int Code_Country { get; set; }
        public string Url_Flag_Country { get; set; }
        public DateTime Date_Created_Country { get; set; }
    }
}
