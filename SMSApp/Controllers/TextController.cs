using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMSApp.Models;

namespace SMSApp.Controllers
{
    public class TextController : Controller
    {
        [HttpGet]
        // GET: Text
        public ActionResult SendText(string Number, string Prefix)
        {
            Text n = new Text();
            n.Prefix = Prefix;
            n.Number = Number;
            

            return View(n);
        }
        //Recieve HttpPost from the SendText view and recieve the data from the text input form
        [HttpPost]
        public ActionResult SendText(FormCollection collection)
        {
            //create new SMS object to fill ud=sing parameters from the SendText view
                Text message  = new Text();
                message.Prefix = collection["Prefix"];
                message.Number = collection["Number"];
                message.Message = collection["Message"];

           //check if contact exists in list already
                IEnumerable<Contact> checkContact =
                    from x in ContactDBcs.contact
                    where (message.Prefix + message.Number) == (x.Prefix + x.Number)
                    select x;
            
            //if match found, redirect to confirmation page
                if (checkContact.Count() > 0)
                {
                    List<Contact> contactsConfirm = checkContact.ToList();
                    Contact contactConfirm = contactsConfirm.Single();
                    SMSLogger.SMSLog(message.Message);
                    return View("Confirmation", contactConfirm);
                }
           
            //if no matches are found in the list, return an error page
                if(checkContact.Count() == 0)
                {
                    return View("Error");
                }

                return View();
           

        }
    }
}