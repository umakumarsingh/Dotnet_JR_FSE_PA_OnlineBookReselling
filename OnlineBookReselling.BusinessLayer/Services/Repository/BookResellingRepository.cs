using Microsoft.EntityFrameworkCore;
using OnlineBookReselling.DataLayer;
using OnlineBookReselling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookReselling.BusinessLayer.Services.Repository
{
    public class BookResellingRepository : IBookResellingRepository
    {
        /// <summary>
        /// Creating Referance variable of BookResellingDbContext and injecting in BookResellingRepository Constructor
        /// </summary>
        private readonly BookResellingDbContext _resellingDbContext;
        public BookResellingRepository(BookResellingDbContext resellingDbContext)
        {
            _resellingDbContext = resellingDbContext;
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
            //Here we accessing book details for store in Order Table
            var bookPrice = _resellingDbContext.Books.Where(x => x.BookId == bookId).FirstOrDefault();
            
            var order = new Order()
            {
                UserId = user.UserId,
                UserEmail = user.Email,
                BookId = bookId,
                BookName = bookPrice.BookName,
                Amount = bookPrice.UnitPrice
            };
            _resellingDbContext.Add(order);
            await _resellingDbContext.SaveChangesAsync();
            return bookPrice;
        }
        /// <summary>
        /// Getting Book type List for Generating Menu Bar
        /// </summary>
        /// <returns></returns>
        public IList<BookType> BookTypeList()
        {
            var typeList = _resellingDbContext.BookTypes.ToList();
            return typeList;
        }
        /// <summary>
        /// User can find a book by Name and author of book
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> FindBook(string name)
        {
            var result = await _resellingDbContext.Books.
                Where(x => (x.BookName == name) || (x.Author == name)).Take(10).ToListAsync();
            return result;
        }
        /// <summary>
        /// Get all book on Index method and alos accesss book by book type id
        /// </summary>
        /// <param name="bookTypeId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> GetAllBook(int? bookTypeId)
        {
            if (bookTypeId == null)
            {
                var book = await _resellingDbContext.Books
                    .OrderByDescending(x => x.BookName).ToListAsync();
                return book;
            }
            else
            {
                var plan = await _resellingDbContext.Books.Where(x => x.BookTypeId == bookTypeId)
                    .OrderByDescending(x => x.BookName).ToListAsync();
                return plan;
            }
        }
        /// <summary>
        /// Get book details by book id, after click on details of book in view
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public async Task<Book> GetBookDetailsById(int bookId)
        {
            var details = await _resellingDbContext.Books.Where(x => x.BookId == bookId)
                    .OrderByDescending(x => x.BookName).FirstOrDefaultAsync();
            return details;
        }
        /// <summary>
        /// Get user details after user is able to register successfully.
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> GetUserDetailsById(int UserId)
        {
            var user = await _resellingDbContext.Users.Where(x => x.UserId == UserId)
                    .OrderByDescending(x => x.Email).FirstOrDefaultAsync();
            return user;
        }
        /// <summary>
        /// Get book order details by registered user email address
        /// </summary>
        /// <param name="emailId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Order>> OrderInformation(string emailId)
        {
            var orderInfo = await _resellingDbContext.Orders.
                Where(x => x.UserEmail == emailId).ToListAsync();
            return orderInfo;
        }
        /// <summary>
        /// Register a new user, after user can place a book order
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> RegisterUser(ApplicationUser user)
        {
            _resellingDbContext.Users.Add(user);
            await _resellingDbContext.SaveChangesAsync();
            return user;
        }
        /// <summary>
        /// Verify a user before placing a book order.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> VerifyUser(string email, string password)
        {
            var user = await _resellingDbContext.Users.Where
                (u => u.Email == email && u.Password == password).FirstOrDefaultAsync();
            return user;
        }
    }
}
