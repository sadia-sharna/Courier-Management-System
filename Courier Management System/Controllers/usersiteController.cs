using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Courier_Management_System.Models;
using System.Web.Routing;

namespace Courier_Management_System.Controllers
{
    public class usersiteController : Controller
    {
       

       
        public ActionResult IndexView()
        {
            Courier_Management_SystemEntities db = new Courier_Management_SystemEntities();
            //usersite ob_usersite = db.usersites.SingleOrDefault(x => x.id==1);
            //usersiteViewModel vm = new usersiteViewModel();
            //vm.username = ob_usersite.username;
            //vm.id = ob_usersite.id;
            //vm.password = ob_usersite.password;
            return View();
        }
        
       
       /* public JsonResult BookingCalculateUser(BookingWidgetViewModel model)
        {
            booking book = new booking();
            if (book.bOriginArea == "Dhaka")
            {
                book.bOriginCost = 70;
            }
            if (book.bDestArea == "Dhaka")
            {
                book.bDestCost = 70;
            }
            book.bCost = book.bOriginCost + book.bDestCost;

            return Json(book.bCost, JsonRequestBehavior.AllowGet);
        }
        /* private List<AreaInfo> GetOriginArea()
         {
             Courier_Management_SystemEntities db = new Courier_Management_SystemEntities();
             List<AreaInfo> list = db.AreaInfoes.ToList();
             ViewBag.AreaInfoList = new SelectList(list, "aCost", "aAreaName");
             return list;
         }
         */
        
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(RegistrationViewModel model)
        {
            Courier_Management_SystemEntities db = new Courier_Management_SystemEntities();
            siteuser usersite = new siteuser();
            usersite.username = model.username;
            usersite.password = model.password;
            usersite.address = model.address;
            usersite.emailid = model.emailid;
            usersite.usertype = 1;
            db.siteusers.Add(usersite);
            db.SaveChanges();


            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public JsonResult LoginUser(RegistrationViewModel model)
        {
            Courier_Management_SystemEntities db = new Courier_Management_SystemEntities();
            siteuser user = db.siteusers.SingleOrDefault(x => x.emailid==model.emailid && x.password==model.password);
            string result = "Fail";
            if (user!=null)
            {
                Session["UserId"] = user.id;
                Session["UserName"] = user.username;
                if(user.usertype==1)
                {
                    result = "User";
                }
                else
                {
                    result = "Admin";
                }
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("IndexView");
        }

    }
}