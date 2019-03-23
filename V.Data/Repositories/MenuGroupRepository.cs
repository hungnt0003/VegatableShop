using V.Data.Infrastructure;
using V.Model.Models;

namespace V.Data.Repositories
{
    public interface IMenuGroupRepository
    {
    }

    internal class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}