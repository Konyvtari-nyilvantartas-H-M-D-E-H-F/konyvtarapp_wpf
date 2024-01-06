using Books.Backend.Context;
using Books.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books.Backend.Repos
{
    public class KiadoRepo : IKiadoRepo
    {
        private readonly KiadoInMemoryContext _dbContext;

        public KiadoRepo(KiadoInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Kiado?> GetBy(Guid id)
        {
            return await _dbContext.Kiadok.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Kiado>> GetAll()
        {
            return await _dbContext.Kiadok.ToListAsync();
        }
    }
}
