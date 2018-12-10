using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Courier_Management_System.Models
{
    public class usersiteViewModel
    {
        public long id { get; set; }
        public string username { get; set; }
        public string emailid { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public int? usertype { get; set; }
    }
}