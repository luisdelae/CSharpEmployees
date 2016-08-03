using eManager.Domain;
using eManager.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eManager.Web.Controllers
{
    public class HomeController : Controller
    {

        private IDepartmentDataSource _db = new DepartmentDb();
        // Go back to this https://app.pluralsight.com/player?course=mvc4&author=scott-allen&name=mvc4-m1-introduction-i&clip=4&mode=live if you run into issues with this constructor

        public ActionResult Index()
        {
            var allDeparements = _db.Departments;
            return View(allDeparements);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}