using Microsoft.EntityFrameworkCore;
using Store.DB.Context;
using System.Linq;
using System.Threading.Tasks;

namespace Store.DB
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        private DbSet<T> _dbSet;

        public DbSet<T> DbSet => _dbSet ??= _context.Set<T>();

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            DbSet.Remove(entity);
            await SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            DbSet.Update(entity);
            await SaveChangesAsync();
        }

        public IQueryable<T> Get()
        {
            return DbSet.AsQueryable();
        }

        public IQueryable<T> GetAll()
        {
            return DbSet.AsQueryable();
        }

        private async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
