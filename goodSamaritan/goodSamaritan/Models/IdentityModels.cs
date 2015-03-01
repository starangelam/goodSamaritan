using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GoodSamaritan.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
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

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.AbuserRelationship> AbuserRelationships { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.Age> Ages { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.AssignedWorker> AssignedWorkers { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.Crisis> Crises { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.DuplicateFile> DuplicateFiles { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.Ethnicity> Ethnicities { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.Year> Years { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.Incident> Incidents { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.Program> Programs { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.ReferralContact> ReferralContacts { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.ReferralSource> ReferralSources { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.RepeatClient> RepeatClients { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.RiskLevel> RiskLevels { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.RiskStatus> RiskStatus { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.Service> Services { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.StatusOfFile> StatusOfFiles { get; set; }

        public System.Data.Entity.DbSet<goodSamaritan.Models.Client.VictimOfIncident> VictimOfIncidents { get; set; }
    }
}