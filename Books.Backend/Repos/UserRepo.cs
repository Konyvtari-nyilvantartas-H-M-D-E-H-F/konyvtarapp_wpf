using Books.Backend.Context;
using Books.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books.Backend.Repos
{
    public class UserRepo : IUserRepo
    {
        private readonly UsersInMemoryContext _dbContextb;

        public UserRepo(UsersInMemoryContext dbContextb)
        {
            _dbContextb = dbContextb;
        }

        public async Task<User?> GetBy(Guid id)
        {
            return await _dbContextb.Users.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<User>> GetAll()
        {
            return await _dbContextb.Users.ToListAsync();
        }
    }
}
