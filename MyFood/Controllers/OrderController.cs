using MyFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

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
            
            db.Orders.Add(orderObj);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        //authorize sup
        //Get: Order/viewOrder
        public ActionResult viewOrder()
        {
            var order = db.Orders.Where(o => o.Accept == false && o.Deny == false).ToList();
            
            return View(order);
        }


        //authorize sup
        //Get: Order/orderDetails
        public ActionResult orderDetails(long id)
        {
            var order = db.Orders.Include(c => c.BuffetType)
                .Include(c => c.Unit).SingleOrDefault(c => c.order_id == id);
            
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
        public ActionResult orderDetails(Order order )
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("viewOrder");
            }
            return View(order);
        }
    }
}