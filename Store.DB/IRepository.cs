using System.Linq;
using System.Threading.Tasks;

namespace Store.DB
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        IQueryable<T> Get();
        IQueryable<T> GetAll();
    }
}
