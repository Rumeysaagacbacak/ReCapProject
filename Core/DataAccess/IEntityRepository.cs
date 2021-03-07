using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // Generic Constraint
    // T, newlenebilir bir IEntity sınıfı olmalı
    // IEntity olabilir veya ımplemente eden bir nesne olabilir.
    //new () :newlene bilir olmalı.
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        //çekeceğin verilere filtre getirebilmek için expression kullandın
       
        List<T> GetAll(Expression<Func<T, bool>> filter=null );
        //eğer filtre vermemişsse tüm datayı istiyor demektir.
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
