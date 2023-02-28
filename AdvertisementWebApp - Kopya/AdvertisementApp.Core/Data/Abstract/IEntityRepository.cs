using AdvertisementApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Core.Data.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // t bir sınıf olmalı, bir Ientity implemente edilmiş ve new'lenebilir olmalı

        // t = sorguda dönecek tip
        //  predicate :koşul belirleyerek sorgunun belli bir şekilde dönmesini sağlarız.
        // includeProperties : ilişkili özellikler için kullanırız.
        Task<T> GetAsync(Expression<Func<T,bool>> predicate, params Expression<Func<T,object>>[] includeProperties);


        //  parametre  verilimezse tüm değerler gelir.
        // IList: t türünün bir liste olarak döndürüleceğini belirtir.

        Task<IList<T>> GetAllAsync(Expression<Func<T,bool>> predicate= null, params Expression<Func<T, object>>[] includeProperties);


        //
        Task AddAsync(T entity);    
        Task DeleteAsync(T entity); 

        Task UpdateAsync(T entity);


        //
        //Kullanıcı kontrolü
        Task<bool> AnyAsync(Expression<Func<T,bool>> predicate);



        //Count

        Task<int> CountAsync(Expression<Func<T,bool>> predicate);

        //Task: multithreading  coklu iş,asekron olarak çalışmak, 





            }
}
