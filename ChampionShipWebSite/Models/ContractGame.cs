using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChampionShipWebSite.Models
{
    public class ContractGame
    {
        public int Id_ContractGame { get; set; }
        public double Amount_Money_ContractGame { get; set; }
        public DateTime Date_start_ContractGame { get; set; }
        public DateTime Date_ends_ContractGame { get; set; }
    }
}
