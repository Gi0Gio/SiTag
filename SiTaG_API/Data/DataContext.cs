using Microsoft.EntityFrameworkCore;
using SiTaG_API.Entities;

namespace SiTaG_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Animals> Animals { get; set; }
        public DbSet<AnimalsxCattles> AnimalsxCattles { get; set; }
        public DbSet<ApplicationMethods> ApplicationMethods { get; set; }
        public DbSet<Births> Births { get; set; }
        public DbSet<BirthServices> BirthServices { get; set; }
        public DbSet<Cattles> Cattles { get; set; }
        public DbSet<CattlesxDivision> CattlesxDivision { get; set; }
        public DbSet<Divisions> Divisions { get; set; }
        public DbSet<DivisionxLots> DivisionxLots { get; set; }
        public DbSet<HealthStatuses> HealthStatuses { get; set; }
        public DbSet<Lots> Lots { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<Stages> Stages { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Treatments> Treatments { get; set; }
    }
}
