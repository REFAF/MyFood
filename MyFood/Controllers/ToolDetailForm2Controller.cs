using MyFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFood.Controllers
{
    public class ToolDetailForm2Controller : Controller
    {
        // GET: ToolDetailForm2

        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            //List<ToolDetailForm2> ci = new List<ToolDetailForm2> { new ToolDetailForm2 { quantity = 0, note = "" } };
            //return View(ci);
            var tools = new List<ToolDetailForm2>();
            for (int i = 0; i < 14; i++)
            {
                tools.Add(new ToolDetailForm2());
            }

            ViewBag.tool_id = new SelectList(db.ToolDetailForms2, "quantity", "note");

            return View(tools);
        }

        [HttpPost]
        public ActionResult Index(List<ToolDetailForm2> ci)
        {
            foreach (ToolDetailForm2 i in ci)
            {
                ToolDetailForm2 tool = new ToolDetailForm2();
                tool.quantity = i.quantity;
                tool.note = i.note;
            }
            db.SaveChanges();
            return View();

        }
    }
}