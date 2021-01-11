using Moq;
using OnlineBookReselling.BusinessLayer.Interfaces;
using OnlineBookReselling.BusinessLayer.Services;
using OnlineBookReselling.BusinessLayer.Services.Repository;
using OnlineBookReselling.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;

namespace OnlineBookReselling.Tests.TestCases
{
    public class BoundaryTest
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
        public BoundaryTest()
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
        static BoundaryTest()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test to validate Application User Id is return valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ApplicationUser_Id()
        {
            //Arrange
            bool res = false;
            //Act
            service.Setup(repo => repo.RegisterUser(_applicationUser)).ReturnsAsync(_applicationUser);
            var result = await _bookResellingServices.RegisterUser(_applicationUser);
            if (result.UserId == _applicationUser.UserId)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_Validate_ApplicationUser_Id=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Validate Mobile Number
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateMobileNumber()
        {
            //Arrange
            bool res = false;
            //Act
            service.Setup(repo => repo.RegisterUser(_applicationUser)).ReturnsAsync(_applicationUser);
            var result = await _bookResellingServices.RegisterUser(_applicationUser);
            var actualLength = _applicationUser.MobileNumber.ToString().Length;
            if (result.MobileNumber.ToString().Length == actualLength)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_ValidateMobileNumber=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Testfor_ValidEmail used for test the valid Email
        /// </summary>
        [Fact]
        public async void Testfor_ValidEmail()
        {
            //Arrange
            bool res = false;
            //Act
            bool isEmail = Regex.IsMatch(_applicationUser.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
            res = isEmail;
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_ValidEmail=" + res + "\n");
        }
    }
}
