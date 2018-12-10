using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Courier_Management_System.Models;
using Courier_Management_System.dbclass;

namespace Courier_Management_System.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult BookingWidget()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BookingWidget(booking book)
        {

            using (Courier_Management_SystemEntities entities = new Courier_Management_SystemEntities())
            {
                if (book.bOriginArea == "Dhaka")
                {
                    book.bOriginCost = 50;
                }
                else
                {
                    book.bOriginCost = 100;
                }
                if (book.bDestArea == "Dhaka")
                {
                    book.bDestCost = 50;
                }
                else
                {
                    book.bDestCost = 100;
                }
                if (book.bTye == "Emergency")
                {
                    book.bCost = book.bOriginCost + book.bDestCost + 50;
                }
                else
                {
                    book.bCost = book.bOriginCost + book.bDestCost;
                }
                book.status = "Approve";

                entities.bookings.Add(book);
                entities.SaveChanges();
                int ID = book.bID;


            }

            return View(book);

        }



        public ActionResult AdminHome()
        {
            Courier_Management_SystemEntities db = new Courier_Management_SystemEntities();
            List<booking> bookinglist = db.bookings.ToList();
            BookingWidgetViewModel bookingVM = new BookingWidgetViewModel();
            List<BookingWidgetViewModel> bookingVMList = bookinglist.Select(x => new BookingWidgetViewModel
            {
                bOriginFirstName = x.bOriginFirstName,
                bOriginLastName = x.bOriginLastName,
                bID = x.bID,
                bOriginAddress = x.bOriginAddress,
                bOriginArea = x.bOriginArea,
                bOriginPhoneNo = x.bOriginPhoneNo,
                bDestFirstName = x.bDestFirstName,
                bDestLastName = x.bDestLastName,
                bDestPhoneNo = x.bDestPhoneNo,
                bDestAddress = x.bDestAddress,
                bDestArea = x.bDestArea,
                bWeight = x.bWeight,
                bDestCost = x.bDestCost,
                bOriginCost = x.bOriginCost,
                bTye = x.bTye,
                bDescription = x.bDescription,
                status = x.status,
                bCost = x.bCost
            }).ToList();

            return View(bookingVMList);
        }
        /*[HttpPost]
        public ActionResult AdminHome(BookingWidgetViewModel book)
        {
            
                Session["ApproveBookId"] = book.bID;
                TempData["Approved"] = "Approved";



            return View();
        }
        */
    }
}