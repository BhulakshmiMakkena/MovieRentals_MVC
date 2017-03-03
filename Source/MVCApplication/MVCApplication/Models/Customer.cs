using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    [Table ("Customer")]
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
         public string CustomerLastName { get; set; }
        public string CustomerGender { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
      
    }
}