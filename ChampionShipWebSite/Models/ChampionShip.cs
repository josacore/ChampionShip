using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChampionShipWebSite.Models
{
    public class Championship
    {
        public int Id_Championship { get; set; }
        public string Name_Championship { get; set; }
        public User User_Created_Championship { get; set; }
        public DateTime Date_Created_Championship { get; set; }
        public Country Country_Championship { get; set; }
        public City City_Championship { get; set; }
        public List<Team> Teams_Championship { get; set; }
        public List<Place> Seats_Championship { get; set; }
        public List<New> News_Championship { get; set; }
        public List<Title> Titles_Championship { get; set; }
    }
}