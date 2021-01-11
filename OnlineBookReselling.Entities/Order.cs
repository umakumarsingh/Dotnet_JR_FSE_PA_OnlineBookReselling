using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineBookReselling.Entities
{
    public class Order
    {
        [Key]
        [Display(Name = "Order Id")]
        public int OrderId { get; set; }
        [Display(Name = "User Id")]
        public int UserId { get; set; }
        [Display(Name = "User Email")]
        public string UserEmail { get; set; }
        [Display(Name = "Book Id")]
        public int BookId { get; set; }
        [Display(Name ="Book Name")]
        public string BookName { get; set; }
        public Double Amount { get; set; }
    }
}
