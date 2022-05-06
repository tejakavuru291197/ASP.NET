using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_WebApplication1_DBFirst.Models
{
    [Table("tblFootBallLeague")]
    public class FootBallLeague
    {
        [Key]
        public int MatchID { get; set; }
        public string TeamName1 { get; set; }
        public string TeamName2 { get; set; }
        public string MatchStatus { get; set; }
        public string WinningTeam { get; set; } //EF will create Null Columns for reference types ...string is a reference type
        public Nullable<int> Points { get; set; }
    }
}