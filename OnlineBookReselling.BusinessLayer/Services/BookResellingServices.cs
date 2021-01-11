using OnlineBookReselling.BusinessLayer.Interfaces;
using OnlineBookReselling.BusinessLayer.Services.Repository;
using OnlineBookReselling.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookReselling.BusinessLayer.Services
{
    public class BookResellingServices : IBookResellingServices
    {
        /// <summary>
        /// Creating referance variable of IBookResellingRepository and injecting in BookResellingServices Constructor
        /// </summary>
        private readonly IBookResellingRepository _brRepository; 
        public BookResellingServices(IBookResellingRepository bookResellingRepository)
        {
            _brRepository = bookResellingRepository;
        }
        /// <summary>
        /// Place a book order, user must be verified by another function VerifyUser.
        /// user must be register first, then place to order.
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<Book> BookOrder(int bookId, ApplicationUser user)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Book Type List for Creating Menu Bar
        /// </summary>
        /// <returns></returns>
        public IList<BookType> BookTypeList()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find a book by name and book Author
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> FindBook(string name)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all book and book by book type by selecting menubar options
        /// </summary>
        /// <param name="bookTypeId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> GetAllBook(int? bookTypeId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get book details by book id
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public Task<Book> GetBookDetailsById(int bookId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get a user details by passing user details after register
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> GetUserDetailsById(int UserId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get order information after any user place order.
        /// </summary>
        /// <param name="emailId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Order>> OrderInformation(string emailId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register a new user and make them to place order
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<ApplicationUser> RegisterUser(ApplicationUser user)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Using this method use are verified for placing a book order.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Task<ApplicationUser> VerifyUser(string email, string password)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
