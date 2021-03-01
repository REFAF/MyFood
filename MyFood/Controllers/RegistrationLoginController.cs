using MyFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFood.Controllers
{
    public class RegistrationLoginController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RegistrationLogin
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegistrationLogin/OrgRegistration
        public ActionResult OrgRegistration()
        {
            var viewModel = new OrgRegistrationViewModel
            {

                orgType = db.OrgTypes.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OrgRegistration(OrgRegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new UserRegistration();
                user.name = model.name;
                user.mobile = model.mobile;
                user.email = model.email;
                user.password = model.Password;
                user.userType_id = 4;
                db.UserRegistrations.Add(user);

                var org = new Organization();
                org.org_location = model.Organization.org_location;
                //ViewBag.orgType_id = new SelectList(db.OrgTypes, "orgType_id", "orgType_name", model.Organization.orgType_id);
                org.orgType_id = model.Organization.orgType_id;

                db.Organizations.Add(org);

                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(model);

        }
        
    }
}