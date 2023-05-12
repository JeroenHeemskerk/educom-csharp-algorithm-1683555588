using System;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using MySql.Data.EntityFrameworkCore.Extensions;
using BornToMove;

namespace BornToMove.DAL
{
    public class YourDbContext : DbContext
    {
        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options) { }

        public DbSet<Move> Moves { get; set; }
    }
}

