using OnlineBookReselling.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace OnlineBookReselling.BusinessLayer.Services.ViewModels
{
    public class BookViewModels
    {
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
        public IEnumerable<Book> Books { get; set; }
        public int TypePerPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(Books.Count() / (double)TypePerPage));
        }
        public IEnumerable<Book> PaginatedBookType()
        {
            int start = (CurrentPage - 1) * TypePerPage;
            return Books.OrderBy(b => b.BookId).Skip(start).Take(TypePerPage);
        }
    }
}
