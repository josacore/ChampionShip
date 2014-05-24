using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChampionShipWebSite.Models
{
    public class Member
    {
        public int Id_Member { get; set; }
        public Profile Profile_Member { get; set; }
        public DateTime Date_Created { get; set; }
    }
}
