using System;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
//using MySql.Data.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using BornToMove;


namespace BornToMove.DAL
{
    public class MoveContext : DbContext
    {
        public MoveContext(DbContextOptions<MoveContext> options) : base(options) { }

        public MoveContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var serverVersion = new MariaDbServerVersion(new Version(10, 4, 27));

                optionsBuilder.UseMySql("Server=localhost;Database=born2move;Uid=root;Pwd=Edu-Com17;", serverVersion);
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Move> Moves { get; set; }
    }
}
