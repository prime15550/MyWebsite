using System.Data.Entity;

using MyWebsite.Entities;

namespace MyWebsite.DataAccess.EF
{
  public partial class PortfolioContext : DbContext
  {
   public virtual DbSet<tblBilgiler> tblBilgiler { get; set; }

    }
}
