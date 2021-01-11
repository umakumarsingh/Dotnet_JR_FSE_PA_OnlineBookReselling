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
    public class ExceptionalTest
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
        public ExceptionalTest()
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
                PublisherId = 1,
                PublisherName = "Uma Kumar",
                Email = "uma@iiht.co.in",
                Password = "123",
                PhoneNumber = 9631547825
            };
        }
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static ExceptionalTest()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test for verify invalid User registration, if provide null object must be return null, means not possible to register
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Invlid_UserRegister()
        {
            //Arrange
            bool res = false;
            var user = new ApplicationUser()
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
            user = null;
            //Act
            service.Setup(repo => repo.RegisterUser(user)).ReturnsAsync(user = null);
            var result = await _bookResellingServices.RegisterUser(user);
            if (result == null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_Validate_Invlid_UserRegister=" + res + "\n");
            return res;
        }
    }
}
