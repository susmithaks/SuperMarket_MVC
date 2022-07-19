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
        [StringLength (10)]
        public String Name { get; set; }
        [EmailAddress(ErrorMessage ="Enter a Valid Email ID")]
        public String Email_ID { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [MinLength (4,ErrorMessage = "Enter minimum 4 character")]
        public string  UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }

}