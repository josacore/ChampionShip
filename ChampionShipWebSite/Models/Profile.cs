using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChampionShipWebSite.Models
{
    public class Profile
    {
        public int Id_Profile { get; set; }
        public string Image_Profile { get; set; }
        public string FistName_Profile { get; set; }
        public string MiddleName_Profile { get; set; }
        public string LastName_Profile { get; set; }
        public DateTime Date_Born_Profile { get; set; }
        public City CityOfBirth_Profile { get; set; }
        public List<Country> Nationalities_Profile { get; set; }
        public List<string> SocialNetWork_Profile { get; set; }
        public List<string> Images_Profile { get; set; }
        public List<Team> Fan_Team_Profile { get; set; }
    }
}
