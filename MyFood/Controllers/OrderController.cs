using MyFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

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
            
            db.Orders.Add(orderObj);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        //authorize sup
        //Get: Order/viewOrder
        public ActionResult viewOrder()
        {
            var order = db.Orders.ToList();
            
            return View(order);
        }


        //authorize sup
        //Get: Order/editOrder
        public ActionResult acceptOrder(long id)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }

            ViewOrderViewModel model = new ViewOrderViewModel()
            {
                order_id = id,
                phone_number = order.phone_number,
                buffet_type_id = order.buffet_type_id,
                plate_num = order.plate_num,
                persons_num = order.persons_num,
                event_date = order.event_date,
                event_time = order.event_time,
                unit_id = order.unit_id,
                unit_name = order.unit_name,
                reservation_date = order.reservation_date
            };
            return View(model);
        }
    }
}