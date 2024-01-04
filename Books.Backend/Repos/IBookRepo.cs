using Books.Backend.Datas.Entities;

namespace Books.Backend.Repos
{
    public interface IBookRepo
    {
        Task<List<Book>> GetAll();
        Task<Book?> GetBy(Guid id);
    }
}
