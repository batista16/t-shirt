using Microsoft.AspNet.Identity.EntityFramework;
using tshirt.Data.Models;

namespace tshirt.Data
{
    public class TshirtContext : IdentityDbContext<ApplicationUser> {
        public TshirtContext()
            : base("tshirtdb", throwIfV1Schema: false)
        {
        }

        public static TshirtContext Create() {
            return new TshirtContext();
        }
    }
}