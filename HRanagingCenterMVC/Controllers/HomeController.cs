using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using HRanagingCenterMVC.Models;

namespace HRanagingCenterMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult Professional()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }



        public ActionResult Registration()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Registration(TblUser r)
        {
            using (HRDTOEntities db = new HRDTOEntities())
            {
                if (ModelState.IsValid)
                {
                    db.TblUsers.Add(r);
                    db.SaveChanges();
                    ModelState.Clear();
                }
            }
            return View(r);
            //return View(r);
        }
        [HttpPost]
        public ActionResult Login(TblUser r)
        {
            using (HRDTOEntities db = new HRDTOEntities())
            {
                if (ModelState.IsValid)
                {

                    var log = db.TblUsers.Where(a => a.userName.Equals(r.userName) && a.password.Equals(r.password)).FirstOrDefault();
                    {
                        return RedirectToAction("Contact");
                    }
                    ModelState.Clear();
                }
            }
            return View(r);
        }
    }
}