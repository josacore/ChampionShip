using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChampionShipWebSite.Models
{
    [Table("Director")]
    public class Director
    {
        [Key]
        public int Id_Director { get; set; }
        public string Job_Director { get; set; }
    }
}