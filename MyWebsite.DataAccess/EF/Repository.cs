using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MyWebsite.DataAccess;
using MyWebsite.DataAccess.Abstract;

namespace MyWebsite.DataAccess.EF
{
    public class Repository<T>: RepositoryBase, IRepository<T> where T : class
    {

        public Repository()
         {
         }
        /*
        public List<T> List()
        {
            return _objectSet.ToList();
        }
        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }
        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public int Update(T obj)
        {
            return Save();
        }

        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

        public int Save()
        {
            return db.SaveChanges();
        }
        */
        public void Delete(T entity)
        {

            using (var context = new PortfolioContext())
            {
                var delete = context.Entry(entity);
                delete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var context = new PortfolioContext())
            {
                return context.Set<T>().SingleOrDefaultAsync(filter).Result;
            }
        }
        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new PortfolioContext())
            {
                return filter == null
                    ? context.Set<T>().ToListAsync().Result
                    : context.Set<T>().Where(filter).ToList();
            }
        }
        public void Insert(T entity)
        {
            using (var context = new PortfolioContext())
            {
                var insert = context.Entry(entity);
                insert.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(T entity)
        {
            using (var context = new PortfolioContext())
            {
                var update = context.Entry(entity);
                update.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
