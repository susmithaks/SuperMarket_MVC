using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Supermarket_MVC.Models
{
    [Table("EmployeeDetails")]
    public class RegisterModel
    { 
        //primary key 
        [Key]
        //Auto increment
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public String Name { get; set; }
        public String Email_ID { get; set; }
        public int Age { get; set; }
        public string  UserName { get; set; }
        public string Password { get; set; }

    }

}