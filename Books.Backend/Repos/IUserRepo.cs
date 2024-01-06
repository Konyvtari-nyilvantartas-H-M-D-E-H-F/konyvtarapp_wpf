using Books.Backend.Datas.Entities;

namespace Books.Backend.Repos
{
    public interface IUserRepo
    {
        Task<List<User>> GetAll();
        Task<User?> GetBy(Guid id);
    }
}
