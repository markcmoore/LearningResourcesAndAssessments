using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace _20_RockPaperScissorsGame_NoDb
{
    class Context : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Round> Rounds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Server=path to Db. - Database=NameOfDb -
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=RockPaperScissorsDb;Trusted_Connection=True;");
        }
    }
}
