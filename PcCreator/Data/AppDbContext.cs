using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
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
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<PcEntity>().HasData(
            //   new PcEntity
            //   {
            //       Id = 1,
            //       Name = "Pc1",
            //       Processor = "Intel i5",
            //       RAM = "8GB",
            //       Disk = "1TB",
            //       DiskType = "HDD",
            //       GPU = "Nvidia 1050",
            //       Manufacturer = "Dell",
            //       ProductionDate = new DateTime(2019, 1, 1)
            //   },
            //   new PcEntity
            //   {
            //       Id = 2,
            //       Name = "Pc2",
            //       Processor = "Intel i7",
            //       RAM = "16GB",
            //       Disk = "1TB",
            //       DiskType = "HDD",
            //       GPU = "Nvidia 1060",
            //       Manufacturer = "Dell",
            //       ProductionDate = new DateTime(2019, 1, 1)
            //   }
            //    );

            string Admin_ID = Guid.NewGuid().ToString();
            string Admin_Role_ID = Guid.NewGuid().ToString();

            string Kamil_ID = Guid.NewGuid().ToString();
            string User_Role_ID = Guid.NewGuid().ToString();

            // dodanie roli użytkownika
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = User_Role_ID,
                Name = "user",
                NormalizedName = "USER",
                ConcurrencyStamp = User_Role_ID
            });


            // dodanie roli admina 
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = Admin_Role_ID,
                Name = "admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Admin_Role_ID
            });

            var admin = new IdentityUser
            {
                Id = Admin_ID,
                Email = "tomek@wsei.pl",
                EmailConfirmed = true,
                UserName = "tomek",
                NormalizedUserName = "TOMEK",
                NormalizedEmail = "TOMEK@WSEI.PL"
            };

            var kamil = new IdentityUser
            {
                Id = Kamil_ID,
                Email = "kamil@wsei.pl",
                EmailConfirmed = true,
                UserName = "kamil",
                NormalizedUserName = "KAMIL",
                NormalizedEmail = "KAMIL@WSEI.PL"
            };

            // haszowanie hasła 
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();

            admin.PasswordHash = ph.HashPassword(admin, "1234");
            kamil.PasswordHash = ph.HashPassword(kamil, "1234");

            // zapisanie użytkownika
            modelBuilder.Entity<IdentityUser>().HasData(admin);
            modelBuilder.Entity<IdentityUser>().HasData(kamil);

            // przypisanie roli do użytkownika
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = Admin_Role_ID,
                UserId = Admin_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = User_Role_ID,
                UserId = Kamil_ID
            });
        }
    }
}