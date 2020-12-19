using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.BLL.Abstruction.Base
{
    public interface IManager<T> where T:class
    {
        ICollection<T> GetAll();
        bool Add(T customer);
        bool Update(T customer);
        bool Remove(T customer);
        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);
    }
}
