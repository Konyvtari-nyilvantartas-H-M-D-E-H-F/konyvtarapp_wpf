using Books.Backend.Context;
using Books.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books.Backend.Repos
{
    public class BookRepo : IBookRepo
    {
        private readonly BooksInMemoryContext _dbContext;

        public BookRepo(BooksInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Book?> GetBy(Guid id)
        {
            return await _dbContext.Books.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Book>> GetAll()
        {
            return await _dbContext.Books.ToListAsync();
        }
    }
}
