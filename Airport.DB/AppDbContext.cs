using Microsoft.EntityFrameworkCore;

namespace Airport.DB
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Ticket> Tickets { get; set; }


        public AppDbContext(string connectionString = @"workstation id=airport.mssql.somee.com;packet size=4096;user id=XanderUZZZER_SQLLogin_1;pwd=cq1dsb51y7;data source=airport.mssql.somee.com;persist security info=False;initial catalog=airport
")
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
