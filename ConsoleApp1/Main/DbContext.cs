using ConsoleApp1.Small;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.bag
{
    class MyDbContext : DbContext
    {
        public DbSet<Stuff> Stuffs { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests{ get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Gender> DocumentTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            { 
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;AttachDbFilename=C:\\Cool_BD\\Database.mdf;Database=MyDatabase;Trusted_Connection=True;");
            }
        }
    }

}
