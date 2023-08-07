using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Configuration;

namespace ConsoleApp1.Database
{
    public partial class TestDbContext : DbContext
    {
        public DbSet<Data> Datas { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SqliteConnectionString"].ConnectionString;
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
