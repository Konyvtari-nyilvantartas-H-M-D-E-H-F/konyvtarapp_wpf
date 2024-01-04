using Microsoft.EntityFrameworkCore;

namespace Books.Backend.Context
{
    public class BooksInMemoryContext : BooksContext
    {
        public BooksInMemoryContext(DbContextOptions<BooksContext> options) : base(options)
        {
        }
    }
}
