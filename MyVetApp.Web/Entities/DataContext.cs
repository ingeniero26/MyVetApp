using Microsoft.EntityFrameworkCore;
using MyVetApp.Web.Entities.Data;

namespace MyVetApp.Web.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<PetType> PetTypes { get; set; }    
        public DbSet<Pet> Pets { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<TaxesType> TaxesTypes { get; set; }
        public DbSet<Taxes> Taxes { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
