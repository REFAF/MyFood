using MyFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MyFood.Controllers
{
    public class OrderController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: Order/OrderForm1
        public ActionResult OrderForm1()
        {
            var viewModel = new OrderForm1ViewModel
            {
                Unit = db.Units.ToList(),
                BuffetType = db.BuffetTypes.ToList()
            };
            
            return View(viewModel);
        }

        // Post: Order/OrderForm1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OrderForm1(OrderForm1ViewModel order)
        {
            var orderObj = new Order();
            orderObj.phone_number = order.phone_number;
            orderObj.buffet_type_id = order.buffet_type_id;
            orderObj.plate_num = order.plate_num;
            orderObj.persons_num = order.persons_num;
            orderObj.event_date = order.event_date;
            orderObj.event_time = order.event_time;
            orderObj.reservation_date = DateTime.Now;
            //orderObj.address = order.address;
            orderObj.unit_id = order.unit_id;
            orderObj.unit_name = order.unit_name;
            orderObj.user_id = User.Identity.GetUserId();
            
            db.Orders.Add(orderObj);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        //authorize sup
        //Get: Order/viewOrder
        public ActionResult viewOrder()
        {
            var order = db.Orders.Where(o => o.accept == null).ToList();
            return View(order);
        }


        //authorize sup
        //Get: Order/orderDetails
        public ActionResult orderDetails(long id)
        {
            var order = db.Orders.Include(c => c.BuffetType)
                .Include(c => c.Unit).SingleOrDefault(c => c.order_id == id);

            var users = from u in db.Users
                        where u.Roles.Any(r => r.RoleId == "65986752-711f-4b17-a15f-7cb96b094090")
                        select u;

            ViewBag.UserName = users.ToList();

            if (order == null)
            {
                return HttpNotFound();
            }

            return View(order);
        }

        //authorize sup
        //POST: Order/orderDetails
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult orderDetails(int id, Order order )
        {
            if (ModelState.IsValid)
            {
                var orderInDb = db.Orders.SingleOrDefault(c => c.order_id == id);

                
                orderInDb.accept = order.accept;
                orderInDb.sup_id = User.Identity.GetUserId();
                orderInDb.emp_id = order.emp_id;

                db.SaveChanges();
                return RedirectToAction("viewOrder");
            }
            return View(order);
        }



        //authorize team
        //Get: Order/AssignedOrder
        public ActionResult AssignedOrder()
        {
            var user = User.Identity.GetUserId();
            var order = db.Orders.Where(o => o.emp_id == user ).ToList();
            return View(order);
        }

        //authorize team
        //Get: Order/empOrderDetails
        public ActionResult empOrderDetails(long id)
        {
            var order = db.Orders.Include(c => c.Unit).Include(c => c.empId)
                .Include(c => c.supId).SingleOrDefault(c => c.order_id == id);

            if (order == null)
            {
                return HttpNotFound();
            }

            return View(order);
        }

        //GET: Order/FoodReceiptReport
        public ActionResult FoodReceiptReport(long id)
        {
            ViewModelForm3 viewmodel = new ViewModelForm3()
            {
                safetyTool = new List<SafetyTool> {new SafetyTool { staff_name = "", clothing = false,
                    hair = false, nails = false, clothing_claean = false,
                    head_cover = false, face_mask = false,gloves = false, note = ""} },

                order_id = id,
            };
            return View(viewmodel);
        }

        //POST: Order/FoodReceiptReport
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FoodReceiptReport(long id, ViewModelForm3 viewModelForm3,
            NotHealthy notHealthy, List<SafetyTool> safety, FoodType foodType)
        {
            var order = db.Orders.Include(c => c.empId)
                .Include(c => c.supId)
                .SingleOrDefault(c => c.order_id == id);

            var form3 = new FoodReceiptForm3();
            var staff_health = new NotHealthy();
            var staff_tool = new SafetyTool();
            var food = new FoodType();

            form3.team_leader_id = User.Identity.GetUserId();
            form3.order_id = order.order_id;
            form3.sup_id = order.sup_id;

            form3.car_num = viewModelForm3.car_num;
            form3.staff_num = viewModelForm3.staff_num;
            form3.date = viewModelForm3.date;
            form3.day = viewModelForm3.day;


            foreach (var i in viewModelForm3.safetyTool)
            {
                db.SafetyTools.Add(i);
                i.f3_id = form3.f3_id;
            }

            safety = new List<SafetyTool> { new SafetyTool { staff_name = "", clothing = false,
                hair = false, nails = false, clothing_claean = false ,head_cover = false,
                face_mask = false,gloves = false, note = ""} };

            
            form3.healthy = viewModelForm3.healthy;
            form3.not_healthy = viewModelForm3.not_healthy;

            staff_health.nothealthy_type_name = notHealthy.nothealthy_type_name;
            staff_health.Employee1_name = notHealthy.Employee1_name;
            staff_health.Employee2_name = notHealthy.Employee2_name;
            staff_health.note = notHealthy.note;

            form3.nothealthy_type_id = notHealthy.nothealthy_type_id;
            food.rice = foodType.rice;
            food.water = foodType.water;
            food.chicken = foodType.chicken;
            food.soup = foodType.soup;
            food.meat = foodType.meat;
            food.pies = foodType.pies;
            food.dates = foodType.dates;
            food.bread = foodType.bread;
            food.fruit = foodType.fruit;
            food.dessert = foodType.dessert;
            food.gursan = foodType.gursan;
            food.groats = foodType.groats;
            food.pasta = foodType.pasta;
            food.vegetables = foodType.vegetables;
            food.buffet = foodType.buffet;
            food.juices = foodType.juices;

            form3.food_type_id = foodType.food_type_id;

            form3.cart_num = viewModelForm3.cart_num;
            form3.pot_num = viewModelForm3.pot_num;
            form3.edible = viewModelForm3.edible;
            form3.inedible = viewModelForm3.inedible;
            form3.exit_time = viewModelForm3.exit_time;
            form3.arrival_time = viewModelForm3.arrival_time;
            form3.return_time = viewModelForm3.return_time;
            form3.kilos_exit_time = viewModelForm3.kilos_exit_time;
            form3.kilos_arrival_time = viewModelForm3.kilos_arrival_time;
            form3.kilos_return_time = viewModelForm3.kilos_return_time;

            form3.note = viewModelForm3.note;

            db.FoodReceiptForms3.Add(form3);
            db.NotHealthies.Add(staff_health);
            db.FoodTypes.Add(food);

            db.SaveChanges();

            return RedirectToAction("AssignedOrder");
        }
    }
}