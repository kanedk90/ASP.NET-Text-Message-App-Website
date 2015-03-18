using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace SMSApp.Models
{
    //Create SMS Logger
    public static class SMSLogger
    {
        public static void SMSLog(String SMS)
        {
            System.Diagnostics.Debug.WriteLine(SMS);
        }
    }
}