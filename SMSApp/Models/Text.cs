using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SMSApp.Models
{
    //Created text class
    public class Text
    {
        //Appllied Validation to Prefix
        [Required]
        [RegularExpression(@"\d{3}", ErrorMessage = "The prefix must be 3 digits long")]
        public string Prefix { get; set; }
        //Appllied Validation to Number
        [Required]
        [RegularExpression(@"\d{7}", ErrorMessage = "The number must be 7 digits long")]
        public string Number { get; set; }
        //Appllied Validation to Message
        [Required(ErrorMessage = "Your message must be between 1 and 140 characters")]
        [StringLength(140, MinimumLength = 1)]
        public string Message { get; set; }
    }
}