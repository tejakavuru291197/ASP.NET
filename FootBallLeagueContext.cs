using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASP.NET_WebApplication1_DBFirst.Models
{
    public class FootBallLeagueContext : DbContext
    {
        public FootBallLeagueContext() : base("FootBallLeagueConnection")  //it connects to the Db using connection String
        {

        }

        public DbSet<FootBallLeague> FootBallLeague { get; set; }
    }
}

//work flow is : FootBallLeagueContext is going to connect with the Db using DbContext
//and for the interaction with the table we need DbSet class.