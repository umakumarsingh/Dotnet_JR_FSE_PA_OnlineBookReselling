using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookReselling.BusinessLayer.Interfaces;
using OnlineBookReselling.BusinessLayer.Services.ViewModels;
using OnlineBookReselling.Entities;
using OnlineBookReselling.Models;

namespace OnlineBookReselling.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Creating Referance variable of ISalonSpaServices and injecting in controller constructor.
        /// </summary>
        private readonly IBookResellingServices _bookRServices;
        public HomeController(IBookResellingServices bookResellingServices)
        {
            _bookRServices = bookResellingServices;
        }
        /// <summary>
        /// Show all book on Index page, can find book by passing book name and title,
        /// get book by book type also after select book type from menu bar.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(int? id, string search, int page = 1)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Book Details
        /// </summary>
        /// <param name="BookId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Details(int BookId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register a new User
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }
        /// <summary>
        /// Post Method of register a new user
        /// </summary>
        /// <param name="appUser"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> RegisterUser(ApplicationUserViewModels appUser)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Place a book Order
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult PlaceBookOrder()
        {
            return View();
        }
        /// <summary>
        /// Place a book Order post method
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PlaceBookOrder([FromQuery] int bookId, string email, string password)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// after book order is placed successfully user see the order infor using this method
        /// </summary>
        /// <param name="emailId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> OrderInfo([FromQuery] string emailId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get user information after user is registred
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> UserInfo(int UserId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Privacy Policy
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// Error for controller function
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
