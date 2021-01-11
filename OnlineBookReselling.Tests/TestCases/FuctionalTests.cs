using Moq;
using OnlineBookReselling.BusinessLayer.Interfaces;
using OnlineBookReselling.BusinessLayer.Services;
using OnlineBookReselling.BusinessLayer.Services.Repository;
using OnlineBookReselling.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OnlineBookReselling.Tests.TestCases
{
    public class FuctionalTests
    {
        /// <summary>
        /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
        /// </summary>
        private readonly IBookResellingServices _bookResellingServices;
        public readonly Mock<IBookResellingRepository> service = new Mock<IBookResellingRepository>();
        private readonly ApplicationUser _applicationUser;
        private readonly Book _book;
        private readonly BookType _bookType;
        private readonly Order _order;
        private readonly Publisher _publisher;
        public FuctionalTests()
        {
            //Creating New mock Object with value.
            _bookResellingServices = new BookResellingServices(service.Object);
            _applicationUser = new ApplicationUser
            {
                UserId = 1,
                Name = "Kumar Uma",
                Email = "services@iiht.co.in",
                Password = "12345",
                ConfirmPassword = "12345",
                MobileNumber = 9631458713,
                PinCode = 457878,
                HouseNo_Building_Name = "Eru Banglore",
                Road_area = "City Road",
                City = "Banglore",
                State = "Karnataka"
            };
            _book = new Book
            {
                BookId = 1,
                BookName = ".Net Core",
                Description = "Learn .net Core",
                Author = "TIm Cook",
                BookTypeId = 1,
                PublisherId = 1,
                PublishedOn = DateTime.Now,
                UnitPrice = 458,
                Remark = "Useful for .net core Developer"
            };
            _bookType = new BookType
            {
                BookTypeId = 1,
                TypeofBook = "Programming",
                Url = "~/",
                OpenInNewWindow = false,
                Description = "Menu Bar"
            };
            _order = new Order
            {
                OrderId = 1,
                UserId = 1,
                UserEmail = "uma@gmail.com",
                BookId = 1,
                BookName = ".Net Core",
                Amount = 784
            };
            _publisher = new Publisher
            {
                PublisherId  = 1,
                PublisherName = "Uma Kumar",
                Email = "uma@iiht.co.in",
                Password = "123",
                PhoneNumber = 9631547825
            };
        }
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static FuctionalTests()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Using this test case method try to get all book and all bokk by bookType Id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_GetAllBook()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.GetAllBook(_bookType.BookTypeId));
            var result = await _bookResellingServices.GetAllBook(_bookType.BookTypeId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_GetAllBook=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get Book by book Id, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetBookDetailsById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.GetBookDetailsById(_book.BookId)).ReturnsAsync(_book);
            var result = await _bookResellingServices.GetBookDetailsById(_book.BookId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetBookDetailsById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get book by Name, Author, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_FindBook_By_Name_Author()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.FindBook(_book.BookName));
            var result = await _bookResellingServices.FindBook(_book.BookName);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_FindBook_By_Name_Author=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Register a user return async return _user object of worki fine.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_new_RegisterUser()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.RegisterUser(_applicationUser)).ReturnsAsync(_applicationUser);
            var result = await _bookResellingServices.RegisterUser(_applicationUser);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_new_RegisterUser=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get Applicaton User by User Id, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetUserDetailsById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.GetUserDetailsById(_applicationUser.UserId)).ReturnsAsync(_applicationUser);
            var result = await _bookResellingServices.GetUserDetailsById(_applicationUser.UserId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetUserDetailsById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Verify Applicaton User by Email Id amd Password, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_VerifyUserDetails()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.VerifyUser(_applicationUser.Email, _applicationUser.Password)).ReturnsAsync(_applicationUser);
            var result = await _bookResellingServices.VerifyUser(_applicationUser.Email, _applicationUser.Password);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_VerifyUserDetails=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Book a order of book return async return _book object of worki fine.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Take_BookOrder()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.BookOrder(_book.BookId,_applicationUser)).ReturnsAsync(_book);
            var result = await _bookResellingServices.BookOrder(_book.BookId, _applicationUser);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Take_BookOrder=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using this test case method try to get all book list.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_BookTypeList()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.BookTypeList());
            var result = _bookResellingServices.BookTypeList();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_BookTypeList=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get User order information by User EmilId, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetUser_OrderInformation()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.OrderInformation(_applicationUser.Email));
            var result = await _bookResellingServices.OrderInformation(_applicationUser.Email);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetUser_OrderInformation=" + res + "\n");
            return res;
        }
    }
}
