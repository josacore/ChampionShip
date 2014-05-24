using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChampionShipWebSite.Models
{
    public class Place
    {
        public int Id_Place { get; set; }
        public string Name_Place { get; set; }
        public double Latitude_Place { get; set; }
        public double Longitude_Place { get; set; }
        public double Altitude_Place { get; set; }
        public string Direction_Place { get; set; }
        public DateTime Date_Created_Place { get; set; }
        public List<string> Images_Place { get; set; }
    }
}
