using Microsoft.EntityFrameworkCore;

namespace Books.Backend.Context
{
    public class UsersInMemoryContext : UsersContext
    {
        public UsersInMemoryContext(DbContextOptions<UsersContext> options) : base(options)
        {
        }
    }
}
