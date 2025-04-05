using DataModel.Directories;
using DataModel.Object;
using Microsoft.EntityFrameworkCore;

namespace Storage
{
    public class MyDbContext : DbContext
    {
        public DbSet<Stuff> Stuffs { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests{ get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            { 
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;AttachDbFilename=C:\\Cool_BD\\Database.mdf;Database=MyDatabase;Trusted_Connection=True;");
            }
        }
    }

}
