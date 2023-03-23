using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HealthAW.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<HealthAW.Models.Coach> Coaches { get; set; }

        public System.Data.Entity.DbSet<HealthAW.Models.CoachType> CoachTypes { get; set; }

        public System.Data.Entity.DbSet<HealthAW.Models.ItemCategory> ItemCategories { get; set; }

        public System.Data.Entity.DbSet<HealthAW.Models.Items> Items { get; set; }

        public System.Data.Entity.DbSet<HealthAW.Models.Cart> Carts { get; set; }

        public System.Data.Entity.DbSet<TaskA.Models.RolesView> RolesViews { get; set; }
    }
}