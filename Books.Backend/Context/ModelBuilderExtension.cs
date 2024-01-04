using Books.Backend.Datas.Entities;
using Books.Backend.Datas.Enums;
using Microsoft.EntityFrameworkCore;

namespace Books.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Book> books = new List<Book>
            {
                new Book
                {
                    Id=Guid.NewGuid(),
                    Title="arany apam",
                    Published=new DateTime(1905,2,1),
                    BookCategory = BookCategoryType.Self_Help,
                    BookLength= 200
                },
                new Book
                {
                    Id=Guid.NewGuid(),
                    Title="elveszet ereklyék",
                    Published=new DateTime(),
                    BookCategory = BookCategoryType.Mystery,
                    BookLength=350
                }
            };

            // Books
            modelBuilder.Entity<Book>().HasData(books);
        }
    }
}
