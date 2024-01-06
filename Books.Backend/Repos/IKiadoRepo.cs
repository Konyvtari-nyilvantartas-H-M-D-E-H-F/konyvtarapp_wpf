using Books.Backend.Datas.Entities;

namespace Books.Backend.Repos
{
    public interface IKiadoRepo
    {
        Task<List<Kiado>> GetAll();
        Task<Kiado?> GetBy(Guid id);
    }
}
