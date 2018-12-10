using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Courier_Management_System.Models;

namespace Courier_Management_System.Controllers
{
    public class DeliveryManController : Controller
    {
        // GET: DeliveryMan
        public ActionResult showDeliveryman()
        {
            Courier_Management_SystemEntities db = new Courier_Management_SystemEntities();
            List<deliveryMan> deliveryManList = db.deliveryMen.ToList();
            deliveryMan deliveryVM = new deliveryMan();
            List<deliveryMan> deliveryVMList = deliveryManList.Select(x => new deliveryMan
            {
                dID = x.dID,
                dFirstName = x.dFirstName,
                dLastName = x.dLastName,
                dAddress=x.dAddress,
                dPhoneNo=x.dPhoneNo,
                dSalary=x.dSalary

            }).ToList();

            return View(deliveryVMList);
        }
        public ActionResult addDeliveryMAn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addDeliveryMan(deliveryMan ob)
        {

            using (Courier_Management_SystemEntities entities = new Courier_Management_SystemEntities())
            {
                

                entities.deliveryMen.Add(ob);
                entities.SaveChanges();
               


            }

            return View(ob);

        }


    }
}