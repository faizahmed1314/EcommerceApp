using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.DAL.Abstruction.Base
{
    public interface IRepository<T> where T: class
    {
        ICollection<T> GetAll();
        bool Add(T entity);
        bool Update(T entity);

        bool Remove(T entity);

        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);


        
    }
}
