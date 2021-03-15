using MyFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFood.Controllers
{
    public class OrderController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: OrderForm1
        public ActionResult OrderForm1()
        {
            var viewModel = new OrderForm1ViewModel
            {
                Unit = db.Units.ToList(),

            };
            
            return View(viewModel);
        }

        // Post: OrderForm1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OrderForm1(OrderForm1ViewModel order)
        {
            var orderObj = new Order();
            orderObj.phone_number = order.phone_number;
            orderObj.event_date = order.event_date;
            orderObj.event_time = order.event_time;
            orderObj.reservation_date = order.reservation_date;
            orderObj.address = order.address;
            orderObj.plate_num = order.plate_num;
            orderObj.persons_num = order.persons_num;
            orderObj.phone_number = order.phone_number;
            orderObj.unit_id = order.unit_id;
            db.Orders.Add(orderObj);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}