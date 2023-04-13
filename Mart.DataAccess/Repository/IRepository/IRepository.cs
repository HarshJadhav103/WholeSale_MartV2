using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mart.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T will be generic and will accept any class or model passed to it
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
