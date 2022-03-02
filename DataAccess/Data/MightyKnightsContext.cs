using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataAccess.Models;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Data
{
    public partial class MightyKnightsContext : DbContext
    {
        public MightyKnightsContext()
        {
        }

        public MightyKnightsContext(DbContextOptions<MightyKnightsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ParkingLot> ParkingLots { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().AddJsonFile("appSettings.json");
            IConfiguration configuration = configurationBuilder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParkingLot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ParkingLot");

                entity.HasIndex(e => e.ParkingSpot, "UQ__ParkingL__FBE2AFF14457941D")
                    .IsUnique();

                entity.Property(e => e.RegistrationPlate).HasMaxLength(50);

                entity.Property(e => e.VechileType).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
