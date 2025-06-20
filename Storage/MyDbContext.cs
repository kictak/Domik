using DataModel.Directories;
using DataModel.Object;
using Microsoft.EntityFrameworkCore;

namespace Storage
{
    public class MyDbContext : DbContext
    {
        private const string databaseFilePath = @"C:\Users\Pibo0123004\Desktop\db\Database.mdf";

        public DbSet<Stuff> Stuffs { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<CheckIn> CheckIns { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Hotels2;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}