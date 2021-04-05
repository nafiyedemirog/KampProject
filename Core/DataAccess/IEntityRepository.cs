using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //filter=null filtre vermeyebilirsin demektir. Expression linqten gelir.
        //Expression=delegate sayesinde ayrı ayrı metotlar yazmaya gerek kalmaz
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter); //tek bir data getirmek için. filtre zorunlu o yüzden null değil
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);


        /*
         * Expression kullanıldığı için buna gerek kalmadı.
         * List<T> GetAllByCategory(int categoryId);*/
    }
}
