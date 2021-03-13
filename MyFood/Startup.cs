using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using MyFood.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFood.Startup))]
namespace MyFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }

        // In this method we will create default User roles and Admin user for login    
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            //In Startup iam creating first Admin Role and creating a default Admin User
            if (!roleManager.RoleExists("Admin"))
            {
                // first we create Admin rool    
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                   

                //var user = new ApplicationUser();
                //user.UserName = "MyFoodAdmin@MyFood.com";
                //user.Email = "MyFoodAdmin@MyFood.com";

                //string userPWD = "MyFood1234";

                //var chkUser = UserManager.Create(user, userPWD);

                ////Add default User to Role Admin    
                //if (chkUser.Succeeded)
                //{
                //    var result1 = UserManager.AddToRole(user.Id, "Admin");

                //}
            }

            // creating Creating Manager role     
            if (!roleManager.RoleExists("مدير الجمعية"))
            {
                var role = new IdentityRole();
                role.Name = "مدير الجمعية";
                roleManager.Create(role);

            }

            // creating Creating Employee role     
            if (!roleManager.RoleExists("رئيس فريق"))
            {
                var role = new IdentityRole();
                role.Name = "رئيس فريق";
                roleManager.Create(role);

            }

            // creating Creating Employee role     
            if (!roleManager.RoleExists("مشرف صالات"))
            {
                var role = new IdentityRole();
                role.Name = "مشرف صالات";
                roleManager.Create(role);

            }

            
        }
    }
}
