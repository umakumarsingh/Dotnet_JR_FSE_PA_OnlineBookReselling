using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineBookReselling.Entities
{
    public class BookType
    {
        [Key]
        [Display(Name = "Book Type Id")]
        public int BookTypeId { get; set; }
        [Required]
        [Display(Name = "Type Of Book")]
        public string TypeofBook { get; set; }
        public string Url { get; set; }
        public bool OpenInNewWindow { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
