using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Courier_Management_System.Models;

namespace Courier_Management_System.Controllers
{
    public class TrackingController : Controller
    {
        deliveryMan dMan = new deliveryMan();
        // GET: Tracking
        public ActionResult TrackView()
        {
            Courier_Management_SystemEntities entities = new Courier_Management_SystemEntities();
            var getDeliveryList = entities.deliveryMen.ToList();
            SelectList list = new SelectList(getDeliveryList, "dID", "dFirstName");
            ViewBag.deliveryManList = list;

            return View();
        }
        [HttpPost]
        public ActionResult TrackView(Tracking track,FormCollection form)
        {
            using (Courier_Management_SystemEntities entities = new Courier_Management_SystemEntities())
            {
               
                 track.diD = 1;
                //string s = form["deliveryMan"].ToString();
                track.bID = (int)Session["HelloID"];
               
                entities.Trackings.Add(track);
                entities.SaveChanges();
               // int ID = track.trackiingID;


            }

            return View(track);

        }
        public ActionResult TrackingWidget()
        {
            return View();
        }
        [HttpPost]
        public JsonResult TrackingButton(Tracking tracking)
        {
            Courier_Management_SystemEntities db = new Courier_Management_SystemEntities();
            
            Tracking tr = db.Trackings.SingleOrDefault(x => x.bID == tracking.bID);
            string name = "1";
            if (tr!=null)
            {
                name = tr.bID.ToString();
            }
            
            
            return Json(name, JsonRequestBehavior.AllowGet);
        }
    }
}