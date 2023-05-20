
using Infrastructure.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.Repositories
{
    public class BaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbContext context;

        protected readonly DbSet<TEntity> table;

        public BaseRepository(DbContext context)
        {
            this.context = context;
            table = this.context.Set<TEntity>();
        }

        public virtual async Task<TEntity> FindByIdAsync(long id)
        {
            return await table.FindAsync(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return table;
        }

        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return table.Where(expression);
        }

        public virtual async Task Insert(TEntity entity)
        {
            await table.AddAsync(entity);
        }

        public virtual void Update(TEntity entity)
        {
            table.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                table.Attach(entity);
            }

            table.Remove(entity);
        }

        public virtual void Delete(int id)
        {
            TEntity entity = table.Find(id);

            table.Remove(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
