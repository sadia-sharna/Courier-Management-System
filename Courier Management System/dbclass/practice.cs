using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Courier_Management_System.dbclass
{
    public class practice
    {
        int id;
        public practice()
        {

        }
        public practice(int Id)
        {
            id = Id;
        }

        public int getID()
        {
            return id;
        }
    }
}