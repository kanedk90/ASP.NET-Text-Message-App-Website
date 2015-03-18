using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMSApp.Models;

//Created Contact Controller
namespace SMSApp.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Details()
        {
           //declared another list called contacts and made it equal to the contacts list in ContactDBs
            List<Contact> myContacts = ContactDBcs.contact;
            return View(myContacts);
        }
    }
}
