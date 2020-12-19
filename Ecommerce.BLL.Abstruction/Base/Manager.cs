using Ecommerce.DAL.Abstruction;
using Ecommerce.DAL.Abstruction.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.BLL.Abstruction.Base
{
    public abstract class Manager<T>:IManager<T> where T:class
    {
        IRepository<T> _repository;
        public Manager(IRepository<T> repository)
        {
            _repository = repository;
        }
        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual bool Add(T customer)
        {
            return _repository.Add(customer);
        }
        public virtual bool Update(T customer)
        {
            return _repository.Update(customer);
        }

        public virtual bool Remove(T customer)
        {
            return _repository.Remove(customer);
        }

        public virtual T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetFirstOrDefault(predicate);
        }

    }
}
