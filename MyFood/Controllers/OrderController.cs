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

            //65986752-711f-4b17-a15f-7cb96b094090
            //19d1428e-d468-42a6-b493-20fa8a3b6657
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
        public ActionResult orderDetails(int id, Order order)
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
            var order = db.Orders.Where(o => o.emp_id == user && o.order_status == null).ToList();
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

        //GET: Order/Form3Sec1
        public ActionResult Form3Sec1(long id)
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

        //POST: Order/Form3Sec1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Form3Sec1(long id, ViewModelForm3 viewModelForm3,
            NotHealthy notHealthy, List<SafetyTool> safety )
        {
            var order = db.Orders.Include(c => c.supId)
                .SingleOrDefault(c => c.order_id == id);

            order.order_status = "قيد التنفيذ";
            var form3 = new FoodReceiptForm3();
            var staff_health = new NotHealthy();
            var staff_tool = new SafetyTool();
            

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
            
            form3.exit_time = viewModelForm3.exit_time;
            form3.kilos_exit_time = viewModelForm3.kilos_exit_time;

            form3.note = viewModelForm3.note;

            db.FoodReceiptForms3.Add(form3);
            db.NotHealthies.Add(staff_health);


            db.SaveChanges();

            return RedirectToAction("AssignedOrder");
        }

        // (Index)
        //GET: Order/empProcessingOrder
        public ActionResult empProcessingOrder()
        {
            var form3 = db.FoodReceiptForms3.Include(f => f.Order)
                .Where(c => c.Order.order_status == "قيد التنفيذ").ToList();

            return View(form3);
        }

        //GET: Order/Form3Sec2
        public ActionResult Form3Sec2(long id)
        {
              
            var form3 = db.FoodReceiptForms3
                .Include(c => c.FoodType)
                .Include(c => c.NotHealthy)
                .Include(c => c.Order).SingleOrDefault(c => c.f3_id == id);


            if (form3 == null)
            {
                return HttpNotFound();
            }

            return View(form3);

        }

        //POST: Order/Form3Sec2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Form3Sec2(long id, string button , FoodReceiptForm3 foodReceiptForm3,FoodType foodType)
        {

            if (ModelState.IsValid)
            {
                var form3 = db.FoodReceiptForms3
                .Include(c => c.FoodType)
                .Include(c => c.Order).SingleOrDefault(c => c.f3_id == id);

                var order = db.Orders.SingleOrDefault(c => c.order_id == form3.order_id);

                var food = new FoodType();


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

                form3.cart_num = foodReceiptForm3.cart_num;
                form3.pot_num = foodReceiptForm3.pot_num;
                form3.edible = foodReceiptForm3.edible;
                form3.inedible = foodReceiptForm3.inedible;

                form3.arrival_time = foodReceiptForm3.arrival_time;
                form3.return_time = foodReceiptForm3.return_time;
                form3.kilos_arrival_time = foodReceiptForm3.kilos_arrival_time;
                form3.kilos_return_time = foodReceiptForm3.kilos_return_time;

                form3.note = foodReceiptForm3.note;

                db.FoodTypes.Add(food);
                db.SaveChanges();

                if (button == "تسليم التقرير")
                {
                    order.order_status = "الانتهاء من استلام الطعام";
                    db.SaveChanges();
                }

                return RedirectToAction("empProcessingOrder");


            }

            return View(foodReceiptForm3);
        }


        //GET: Order/Form2
        public ActionResult Form2()
        {
            ViewModelForm2 viewModel = new ViewModelForm2()
            {

                toolDetailForm2 = new List<ToolDetailForm2> {new ToolDetailForm2 {quantity = 0 ,
                    returned_tools = 0, note = "", tool_unit = ""} },

                ToolIE = db.Tools.ToList(),

            };

            return View(viewModel);
        }


        //POST: Order/Form2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Form2(ViewModelForm2 viewModelForm2, List<ToolDetailForm2> tool)
        {
            var carTool = new CarToolForm2();
            var toolDetail = new ToolDetailForm2();

            carTool.order_id = viewModelForm2.order_id;

            tool = new List<ToolDetailForm2> {new ToolDetailForm2 {quantity = 0 ,
                    returned_tools = 0, note = "", tool_unit = ""} };

            foreach (var i in viewModelForm2.toolDetailForm2)
            {
                db.ToolDetailForms2.Add(i);
                i.f2_id = carTool.form2_id;
            }

            

            carTool.car_num = viewModelForm2.car_num;
            carTool.delivery_date = viewModelForm2.delivery_date;
            db.CarToolForm2s.Add(carTool);

            db.SaveChanges();



            return RedirectToAction("Index", "Home");
        }


        // (Index)
        //GET: Order/CompletedOrder
        public ActionResult CompletedOrder()
        {
            var form3 = db.FoodReceiptForms3.Include(f => f.Order)
                .Where(c => c.Order.order_status == "الانتهاء من استلام الطعام").ToList();

            return View(form3);
        }

        //GET: Order/CompletedOrderDetails
        public ActionResult CompletedOrderDetails(long id)
        {

            var form3 = db.FoodReceiptForms3
                .Include(c => c.FoodType)
                .Include(c => c.NotHealthy)
                .Include(c => c.Order).SingleOrDefault(c => c.f3_id == id);


            if (form3 == null)
            {
                return HttpNotFound();
            }

            return View(form3);


        }

        //POST: Order/CompletedOrderDetails
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompletedOrderDetails(long id, string button, FoodReceiptForm3 foodReceiptForm3, FoodType foodType)
        {

            if (ModelState.IsValid)
            {
                var form3 = db.FoodReceiptForms3
                .Include(c => c.FoodType)
                .Include(c => c.Order).SingleOrDefault(c => c.f3_id == id);

                var order = db.Orders.SingleOrDefault(c => c.order_id == form3.order_id);

                var food = new FoodType();


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

                form3.cart_num = foodReceiptForm3.cart_num;
                form3.pot_num = foodReceiptForm3.pot_num;
                form3.edible = foodReceiptForm3.edible;
                form3.inedible = foodReceiptForm3.inedible;

                form3.arrival_time = foodReceiptForm3.arrival_time;
                form3.return_time = foodReceiptForm3.return_time;
                form3.kilos_arrival_time = foodReceiptForm3.kilos_arrival_time;
                form3.kilos_return_time = foodReceiptForm3.kilos_return_time;

                form3.note = foodReceiptForm3.note;

                db.FoodTypes.Add(food);
                db.SaveChanges();

                return RedirectToAction("CompletedOrder");


            }

            return View(foodReceiptForm3);
        }

        //GET: Order/Form4
        public ActionResult Form4(long id)
        {
            var order = db.Orders
               .Include(c => c.supId)
               .Include(c => c.Unit)
               .SingleOrDefault(c => c.order_id == id);

            ViewModelForm4 viewModel = new ViewModelForm4()
            {
                safetyTool = new List<SafetyTool> {new SafetyTool { staff_name = "", clothing = false,
                    hair = false, nails = false, clothing_claean = false,
                    head_cover = false, face_mask = false,gloves = false, note = ""} },

                order_id = id,

                unitId = order.unit_id,

                mealCategoryIE = db.mealCategories.ToList(),
            };
            return View(viewModel);
        }

        //POST: Order/Form4
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Form4(long id, ViewModelForm4 viewModelForm4,List<SafetyTool> safety)
        {
            var order = db.Orders
                .Include(c => c.supId)
                .Include(c => c.Unit)
                .SingleOrDefault(c => c.order_id == id);

            

            //order.order_status = "قيد التنفيذ";
            var form4 = new Form4A();
            var staff_health = new NotHealthy();
            var staff_tool = new SafetyTool();

            //var unit = db.Database.SqlQuery<Unit>( "select direction_id " +
            //    " from Units where unit" );


            //ViewBag.unit = order.unit_id;

            form4.order_id = order.order_id;
            form4.sup_id = User.Identity.GetUserId();
            form4.team_leader_id = order.emp_id;
            
            form4.Emp1 = viewModelForm4.Emp1;
            form4.Emp2 = viewModelForm4.Emp2;
            form4.meal_num = viewModelForm4.meal_num;
            form4.sample_num = viewModelForm4.sample_num;
            form4.meal_weight = viewModelForm4.meal_weight;
            form4.packing_date = viewModelForm4.packing_date;
            form4.day = viewModelForm4.day;
            form4.mealCategory_id = viewModelForm4.mealCategory_id;

            foreach (var i in viewModelForm4.safetyTool)
            {
                db.SafetyTools.Add(i);
                i.form4A_id = form4.form4A_id;
            }

            safety = new List<SafetyTool> { new SafetyTool { staff_name = "", clothing = false,
                hair = false, nails = false, clothing_claean = false ,head_cover = false,
                face_mask = false,gloves = false, note = ""} };


            db.Forms4A.Add(form4);
            db.NotHealthies.Add(staff_health);

            db.SaveChanges();

            return RedirectToAction("CompletedOrder");
        }



    }
}