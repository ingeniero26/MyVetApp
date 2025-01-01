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
    }
}
