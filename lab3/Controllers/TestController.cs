using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab3.Models;

namespace lab3.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult Load()
        {
            Test test = new Test()
            {
                FirstName = "Aviel",
                LastName = "Cohen",
                Email = "Mail",
                Phone = "Phone"
            };

            return View(test);
        }

        public ActionResult Submit()
        {
            if (ModelState.IsValid)
            {
                Test test = new Test()
                {
                    FirstName = Request.Form["FirstName"],
                    LastName = Request.Form["LastName"],
                    Email = Request.Form["Email"],
                    Phone = Request.Form["Phone"]
                };

                return View("Load", test);
            }
            return View("Submit");
        }

    }
}