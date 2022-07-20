using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Supermarket_MVC.Models
{
    public class Item_Details
    {   //primary key.
        [Key]
        //Auto increment
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MinLength(3, ErrorMessage = "Enter minimum 3 character")]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Range(1,int.MaxValue)]
        public int Quantity { get; set; }

       

    }
}