using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebsite.DataAccess;

namespace MyWebsite.DataAccess.EF
{
    public class RepositoryBase
    {
        protected static PortfolioContext db;
        private static object _locksyc = new object();
        protected RepositoryBase()
        {
            CreatecoContext();
        }

        protected static void CreatecoContext()
        {
            if (db == null)
            {
                lock (_locksyc)
                {
                    if (db==null)
                    {
                db =new PortfolioContext();
                    }
                }
            }

        }
    }
}
