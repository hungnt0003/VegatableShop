using V.Data.Infrastructure;
using V.Model.Models;

namespace V.Data.Repositories
{
    public interface IMenuRepository
    {
    }

    internal class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}