using HamsterWars.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HamsterWars.Server.DataBase
{
    public class HamsterDBContext : DbContext
    {
        public DbSet<Hamster> Hamsters { get; set; }

        public HamsterDBContext(DbContextOptions<HamsterDBContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{



        //}

    }
}
