using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Courier_Management_System.Models
{
    public class TrackingWidgetModel
    {
        public int trackiingID { get; set; }
        public Nullable<int> bID { get; set; }
        public Nullable<int> diD { get; set; }
        public string dFirstName { get; set; }
        public int dPhoneNo { get; set; }
        public virtual booking booking { get; set; }
        public virtual deliveryMan deliveryMan { get; set; }
    }
}