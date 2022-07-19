using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Supermarket_MVC.Models
{
    public class LoginModel
    {
        public int ID { get; set; }
        [MinLength(4, ErrorMessage = "UserName should have minimum of 4 character")]
        public String UserName { get; set; }
        public String Password { get; set; }
    }
}