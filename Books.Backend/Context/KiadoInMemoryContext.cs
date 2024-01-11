using Microsoft.EntityFrameworkCore;

namespace Books.Backend.Context
{
    public class KiadoInMemoryContext : KiadokContext
    {
        public KiadoInMemoryContext(DbContextOptions<KiadokContext> options) : base(options)
        {
        }
    }
}
