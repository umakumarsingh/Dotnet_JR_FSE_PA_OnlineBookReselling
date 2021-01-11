using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookReselling.Entities
{
    public class Book
    {
        [Key]
        [Display(Name = "Book Id")]
        public int BookId { get; set; }
        [Required]
        [Display(Name ="Book Name")]
        public string BookName { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int BookTypeId { get; set; }
        public int PublisherId { get; set; }
        public DateTime PublishedOn { get; set; }
        [Display(Name = "Unit Price")]
        public double UnitPrice { get; set; }
        public string Remark { get; set; }
        public virtual Publisher Publishers { get; set; }
    }
}
