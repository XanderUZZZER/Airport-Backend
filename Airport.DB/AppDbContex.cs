using Microsoft.EntityFrameworkCore;

namespace Airport.DB
{
    class AppDbContex : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Flight> Flights { get; set; }

        public AppDbContex(string connectionString = @"Server=(localdb)\mssqllocaldb;Database=Airport")
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
