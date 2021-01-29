using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebsite.DataAccess.EF;
using MyWebsite.Entities;

namespace MyWebsite.BussinessLayer
{
    public class BilgilerManager
    {
        private  Repository<tblBilgiler> repo_Bilgi = new Repository<tblBilgiler>();

        public List<tblBilgiler> GetBilgiler()
        {
            return repo_Bilgi.GetList();
        }
    }
}
