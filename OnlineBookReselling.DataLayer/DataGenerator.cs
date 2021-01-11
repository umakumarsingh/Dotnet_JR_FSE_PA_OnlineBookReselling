using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineBookReselling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineBookReselling.DataLayer
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookResellingDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<BookResellingDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;   // Data was already seeded
                }
                context.Books.AddRange(
                new Book
                {
                    BookId = 1,
                    BookName = "Working with .net core",
                    Description = "Using this book you lear, how to work with .net core",
                    BookTypeId = 2,
                    Author = "Tim Cook",
                    PublisherId = 1,
                    PublishedOn = DateTime.Now,
                    UnitPrice = 1232,
                    Remark = "For .net and core Developer"
                },
                new Book
                {
                    BookId = 2,
                    BookName = ".net core",
                    Description = "Learn .net core",
                    BookTypeId = 3,
                    Author = "Ck Das",
                    PublisherId = 1,
                    PublishedOn = DateTime.Now,
                    UnitPrice = 1232,
                    Remark = "For .net and core Developer"
                });
                context.SaveChanges();
                if (context.BookTypes.Any())
                {
                    return;   // Data was already seeded
                }
                context.BookTypes.AddRange(
                new BookType
                {
                    BookTypeId = 1,
                    TypeofBook = "All Book",
                    Url = "~/",
                    OpenInNewWindow = false,
                    Description = ""
                },
                new BookType
                {
                    BookTypeId = 2,
                    TypeofBook = "Programming",
                    Url = "~/Home/Index/2",
                    OpenInNewWindow = false,
                    Description = ""
                },
                new BookType
                {
                    BookTypeId = 3,
                    TypeofBook = "Management",
                    Url = "~/Home/Index/3",
                    OpenInNewWindow = false,
                    Description = ""
                });
                context.SaveChanges();
            }
        }
    }
}
