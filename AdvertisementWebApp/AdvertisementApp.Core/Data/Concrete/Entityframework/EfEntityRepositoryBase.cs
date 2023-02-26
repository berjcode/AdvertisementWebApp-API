using AdvertisementApp.Core.Data.Abstract;
using AdvertisementApp.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Core.Data.Concrete.Entityframework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
    {

        private readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
          await  _context.Set <TEntity >().AddAsync(entity);

        }

        //bool 
        public  async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
          return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
           return await _context.Set<TEntity>().CountAsync(predicate);
        }


       //remove asekron değil kendimiz oluşturduk.
        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => {
                _context.Set<TEntity>().Remove(entity);
            });

        }
      
     
        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            //sorguları ve filtreleri oluşturmamızı sağlar.
            IQueryable<TEntity> query  =_context.Set<TEntity>();
          //null olma durumu predicate
          
            if(predicate !=null)
            {
                query = query.Where(predicate);
            }

            //değer varsa
            if(includeProperties.Any())
            {   
                foreach(var includeProperty in includeProperties)
                {
                    query =query.Include(includeProperty);
                }
            }

            return await query.ToListAsync();
        }

        //singleordefault =eşleşmiyorsa null döner. 1den fazla değer varsa expection fırlatır.
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
           IQueryable<TEntity> query = _context.Set<TEntity>();
            if(predicate != null)
            {
                query = query.Where(predicate);
            }

            if(includeProperties.Any())
            {
                foreach(var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _context.Set<TEntity>().Update(entity);
            });
        }
    }
}
