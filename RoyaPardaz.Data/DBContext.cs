using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RoyaPardaz.Data.Entities;
using System;

namespace RoyaPardaz.Data
{
    public class DBContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        private readonly IConfigurationRoot _configuration;

        public DBContext(IConfigurationRoot configurationRoot, DbContextOptions<DBContext> options) : base(options)
        {
            _configuration = configurationRoot;
        }

        #region DbSetSections
        // public DbSet<User> TblUser { get; set; }
        // public DbSet<ApplicationUser> TblUserProfile { get; set; }
        //public DbSet<Payments> TblPayments { get; set; }
        //public DbSet<UserAreas> TblUserArea { get; set; }
        //public DbSet<Area> TblArea { get; set; }
        //public DbSet<City> TblCity { get; set; }
        //public DbSet<PropertiesInformation> TblPropertiesInformation { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    _configuration.GetConnectionString("DefaultConnection")
                , serverDbContextOptionBuilder =>
                {
                    var minutes = (int)TimeSpan.FromMinutes(3).TotalSeconds;
                    serverDbContextOptionBuilder.CommandTimeout(minutes);
                    serverDbContextOptionBuilder.MigrationsAssembly("rsaco.Data");
                });

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>(b =>
            {
                b.Property(u => u.Id).HasDefaultValueSql("newsequentialid()");
            });

            modelBuilder.Entity<ApplicationRole>(b =>
            {
                b.Property(u => u.Id).HasDefaultValueSql("newsequentialid()");
            });
        }
    }
}

