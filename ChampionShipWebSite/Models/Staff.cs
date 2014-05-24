using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChampionShipWebSite.Models
{
    public class Staff
    {
        public int Id_Staff { get; set; }
        public string Job_Staff { get; set; }
        public string State_Staff { get; set; }
        public ContractGame ContractGame_Staff { get; set; }
        public List<Team> Teams_Staff { get; set; }
    }
}