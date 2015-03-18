using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SMSApp.Models;

namespace SMSApp.Models
{
    public class ContactDBcs
    {
       public static List<Contact> contact = new List<Contact>
            {
             //Created corresponding view page(Details.cshtml), and made it strongly bound to the ContactController.
                new Contact{Forename ="David", Surname = "Kane", Prefix = "087", Number = "7545713", ContactID = 1},
                new Contact{Forename ="Kieron", Surname = "Kane", Prefix = "087", Number = "2794043", ContactID = 2},
                new Contact{Forename ="Tina", Surname = "Kane", Prefix = "087", Number = "6131317", ContactID = 3},
                new Contact{Forename ="Owen", Surname = "Kane", Prefix = "087", Number = "6575529", ContactID = 4},
                new Contact{Forename ="Sarah", Surname = "Kane", Prefix = "087", Number = "6276459", ContactID = 5},
                new Contact{Forename ="Orla", Surname = "McEntaggart", Prefix = "086", Number = "1646343", ContactID = 6},
                new Contact{Forename ="Ronan", Surname = "McHugh", Prefix = "086", Number = "1260772", ContactID = 7},
                new Contact{Forename ="Conor", Surname = "Murphy", Prefix = "087", Number = "7866611", ContactID = 8},
                new Contact{Forename ="Aisling", Surname = "Gleeson", Prefix = "087", Number = "7696963", ContactID = 9},
                new Contact{Forename ="Karl", Surname = "Ringrose", Prefix = "087", Number = "2162438", ContactID = 10},

                
            };
    }
}