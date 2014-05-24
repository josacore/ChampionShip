using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChampionShipWebSite.Models
{
    public class Team
    {
        public int id_Team { get; set; }
        public String Name_Team { get; set; }
        public DateTime Foundation_Date_Team { get; set; }
        public City City_Team { get; set; }
        public string Url_Official_Anthem_Team { get; set; }
        public Place Stadium_Team { get; set; }
        public Place complex_Team {get; set;}
        public List<int> Telephones_Team { get; set; }
        public List<string> Emails_Team { get; set; }
        public List<string> Websites_Team { get; set; }
        public List<string> SocialNetworks_Team { get; set; }
        public List<string> NickNames_Team { get; set; }
        public List<string> Images_Team { get; set; }
        public List<Member> Members_Team { get; set; }
        public DateTime Date_Created_Team { get; set; }
    }
}
