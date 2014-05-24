using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChampionShipWebSite.Models
{
    public class User
    {
        public int Id_User { get; set; }
        public string User_Name_User { get; set; }
        public string Email_User { get; set; }
        public string Password_User { get; set; }
        public bool Enabled_User { get; set; }
        public Profile Profile_User { get; set; }
        public DateTime Date_Created_User { get; set; }
        public List<Championship> Championships_Subcribed_User { get; set; }
        public List<Team> Teams_Subcribed_User { get; set; }
        public List<Member> Members_Subcribed_User { get; set; }  
    }
}
