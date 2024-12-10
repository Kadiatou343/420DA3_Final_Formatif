using _420DA3_Final_Formatif.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.DataAccess
{
    internal class MyAppDbContext : DbContext
    {
        public DbSet<Language> Languages { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connectionString = ConfigurationManager.ConnectionStrings["ExamDatabase"].ConnectionString;

            _ = optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            _ = modelBuilder.Entity<Language>()
                .ToTable("Languages")
                .HasKey(l => l.Id);

            _ = modelBuilder.Entity<Country>()
                .ToTable("Countries")
                .HasKey(c => c.Id);

            _ = modelBuilder.Entity<Language>()
                .Property(l => l.Id)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("int")
                .IsRequired(true)
                .UseIdentityColumn(1, 1);

            _ = modelBuilder.Entity<Language>()
                .Property(l => l.Name)
                .HasColumnName("Name")
                .HasColumnOrder(1)
                .HasColumnType($"nvarchar({Language.NAME_MAX_LENGTH})")
                .IsRequired(true);

            _ = modelBuilder.Entity<Language>()
                .Property(l => l.IsoCode)
                .HasColumnName("IsoCode")
                .HasColumnOrder(2)
                .HasColumnType($"nvarchar({Language.ISO_CODE_MAX_LENGTH})")
                .IsRequired(true);

            _ = modelBuilder.Entity<Language>()
                .Property(l => l.RowVersion)
                .HasColumnName("RowVersion")
                .HasColumnOrder(3)
                .IsRowVersion();

            _ = modelBuilder.Entity<Country>()
                .Property(c => c.Id)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("int")
                .IsRequired(true)
                .UseIdentityColumn(1, 1);

            _ = modelBuilder.Entity<Country>()
                .Property(c => c.ShortName)
                .HasColumnName("ShortName")
                .HasColumnOrder(1)
                .HasColumnType($"nvarchar({Country.SHORT_NAME_MAX_LENGTH})")
                .IsRequired(true);

            _ = modelBuilder.Entity<Country>()
                .Property(c => c.FullName)
                .HasColumnName("FullName")
                .HasColumnOrder(2)
                .HasColumnType($"nvarchar({Country.FULL_NAME_MAX_LENGTH})")
                .IsRequired(true);

            _ = modelBuilder.Entity<Country>()
                .Property(c => c.RowVersion)
                .HasColumnName("RowVersion")
                .HasColumnOrder(3)
                .IsRowVersion();

            Language l1 = new Language() { Id = 1, Name = "English", IsoCode = "en" };
            Language l2 = new Language() { Id = 2, Name = "French", IsoCode = "fr" };
            Language l3 = new Language() { Id = 3, Name = "German", IsoCode = "de" };

            Country c1 = new Country() { Id = 1, ShortName = "Canada", FullName = "Dominion of Canada" };
            Country c2 = new Country() { Id = 2, ShortName = "Germany", FullName = "Federal Republic of Germany" };

            _ = modelBuilder.Entity<Country>()
                .HasData(c1, c2);
            _ = modelBuilder.Entity<Language>()
                .HasData(l1, l2, l3);

            _ = modelBuilder.Entity<Country>()
                .HasMany(c => c.Languages)
                .WithMany(l => l.CountriesSpoken)
                .UsingEntity(
                "CountriesLanguages",
                right =>
                {
                    return right.HasOne(typeof(Language)).WithMany().HasForeignKey("LanguageId");
                },
                left =>
                {
                    return left.HasOne(typeof(Country)).WithMany().HasForeignKey("CountryId");
                },
                conf => {
                    conf.ToTable("CountriesLanguages").HasKey("CountryId", "LanguageId");
                    conf.HasData(
                        new { CountryId = 1, LanguageId = 1 },
                        new { CountryId = 2, LanguageId = 3 }
                        );
                }
            );


            
        }
    }
}
