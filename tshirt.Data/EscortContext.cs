using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using tshirt.Data.Models;

namespace tshirt.Data
{
    public class EscortContext : IdentityDbContext<ApplicationUser> {
        public EscortContext()
            : base("escortdb", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        
        public static EscortContext Create() {
            return new EscortContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}