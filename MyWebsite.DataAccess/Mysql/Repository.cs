using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MyWebsite.DataAccess.Abstract;

namespace MyWebsite.DataAccess.Mysql
{
    public class Repository<T> : RepositoryBase,IRepository<T> where T : class
    {
        public T Get(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
