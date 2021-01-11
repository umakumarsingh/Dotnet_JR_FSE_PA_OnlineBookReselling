using OnlineBookReselling.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookReselling.BusinessLayer.Interfaces
{
    public interface IBookResellingServices
    {
        Task<IEnumerable<Book>> GetAllBook(int? bookTypeId);
        Task<Book> GetBookDetailsById(int bookId);
        Task<IEnumerable<Book>> FindBook(string name);
        Task<ApplicationUser> RegisterUser(ApplicationUser user);
        Task<ApplicationUser> GetUserDetailsById(int UserId);
        Task<ApplicationUser> VerifyUser(string email, string password);
        Task<Book> BookOrder(int bookId, ApplicationUser user);
        IList<BookType> BookTypeList();
        Task<IEnumerable<Order>> OrderInformation(string emailId);
    }
}
