using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using tshirt.Data.Models;

namespace tshirt.Data
{
    public class TshirtContext : IdentityDbContext<ApplicationUser> {
        public TshirtContext()
            : base("tshirtdb", throwIfV1Schema: false)
        {
        }


        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductDesign> ProductDesigns { get; set; }
        public DbSet<ProductColors>ProductColors  { get; set; }

        public static TshirtContext Create() {
            return new TshirtContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}