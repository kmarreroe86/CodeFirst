using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CodeFirstFluentApi.Models
{
    public class MyDbContext : DbContext
    {
        private readonly IConfiguration _iConfiguration;
        private readonly string _connectionString;


        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        public MyDbContext()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _iConfiguration = builder.Build();
            _connectionString = _iConfiguration.GetConnectionString("DefaultConnection");


            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseMySql(_connectionString, providerOptions => providerOptions.CommandTimeout(60))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ToTable => configure table name
            modelBuilder.Entity<Department>().ToTable("Dpto");

            // HasKey => configure the primary key
            modelBuilder.Entity<Address>().HasKey(a => new {a.EmployeeId});
        }
    }
}