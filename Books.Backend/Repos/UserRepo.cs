using Books.Backend.Context;
using Books.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books.Backend.Repos
{
    public class UserRepo : IUserRepo
    {
        private readonly UsersInMemoryContext _dbContext;

        public UserRepo(UsersInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User?> GetBy(Guid id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<User>> GetAll()
        {
            return await _dbContext.Users.ToListAsync();
        }
    }
}
