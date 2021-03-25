using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MyFood.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public UserType UserType { get; set; }

        [Display(Name = "نوع المستخدم")]
        public byte userType_id { get; set; }

        public string name { get; set; }

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
        public DbSet<City> Cities { get; set; }
        public DbSet<EmpRole> EmpRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<Donator> Donators { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<BuffetType> BuffetTypes { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<OrgType> OrgTypes { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<SafetyTool> SafetyTools { get; set; }
        public DbSet<FoodReceiptForm3> FoodReceiptForms3 { get; set; }
        public DbSet<NotHealthy> NotHealthies { get; set; }
        public DbSet<PackagingFollowUp> PackagingFollowUps { get; set; }
        public DbSet<Sample> Samples { get; set; }
        public DbSet<FamilyDiet> FamilyDiets { get; set; }
        public DbSet<OrderForm1> OrderForms1 { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Direction> Directions{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Neighborhood> neighborhoods { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<CarToolForm2> CarToolForm2s { get; set; }
        public DbSet<ToolDetailForm2> ToolDetailForms2 { get; set; }
        public DbSet<Form4A> Forms4A { get; set; }



        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}