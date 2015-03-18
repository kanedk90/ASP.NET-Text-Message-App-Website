using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSApp.Models
{
    //Created a Contact Class
    public class Contact
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Prefix { get; set; }
        public string Number { get; set; }
        public int ContactID { get; set; }
    }
}