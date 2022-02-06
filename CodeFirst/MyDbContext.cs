using System.IO;
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CodeFirst
{
    internal class MyDbContext : DbContext
    {
        private readonly IConfiguration _iConfiguration;
        private readonly string _connectionString;


        public virtual DbSet<Programme> Programmes { get; set; }
        public virtual DbSet<Subject> Subjects{ get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }

        public MyDbContext() : base()
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
            modelBuilder.Entity<ProgrammeSubject>()
                .HasKey(ps => new { ps.ProgrammeId, ps.SubjectId });  
            modelBuilder.Entity<ProgrammeSubject>()
                .HasOne(ps => ps.Programme)
                .WithMany(p => p.ProgrammeSubjects)
                .HasForeignKey(ps => ps.ProgrammeId);
            modelBuilder.Entity<ProgrammeSubject>()
                .HasOne(ps => ps.Subject)
                .WithMany(s => s.ProgrammeSubjects)
                .HasForeignKey(ps => ps.SubjectId);

            /*modelBuilder.Entity<Student>()
                .HasMany(c => c.Address)
                .WithOne(e => e.);*/
        }
    }
}