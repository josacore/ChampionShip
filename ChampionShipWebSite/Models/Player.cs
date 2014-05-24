using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChampionShipWebSite.Models
{
    public class Player : Member
    {
        public int Id_Player { get; set; }
        public string Position_Player { get; set; }
        public string Prefered_Foot_Player { get; set; }
        public double Height_Player { get; set; }
        public double Weight_Player { get; set; }
        public ContractGame ContractGame_Player { get; set; }
        public List<Team> Teams_Player { get; set; }
    }
}