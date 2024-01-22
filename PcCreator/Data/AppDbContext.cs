using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<PcEntity> Pcs { get; set; }
        private string DbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "PcCreator.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PcEntity>().HasData(
               new PcEntity
               {
                   Id = 1,
                   Name = "Pc1",
                   Processor = "Intel i5",
                   RAM = "8GB",
                   Disk = "1TB",
                   DiskType = "HDD",
                   GPU = "Nvidia 1050",
                   Manufacturer = "Dell",
                   ProductionDate = new DateTime(2019, 1, 1)
               },
               new PcEntity
               {
                   Id = 2,
                   Name = "Pc2",
                   Processor = "Intel i7",
                   RAM = "16GB",
                   Disk = "1TB",
                   DiskType = "HDD",
                   GPU = "Nvidia 1060",
                   Manufacturer = "Dell",
                   ProductionDate = new DateTime(2019, 1, 1)
               }
                );
        }
    }
}