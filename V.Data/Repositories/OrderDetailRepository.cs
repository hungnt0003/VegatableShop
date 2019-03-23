using V.Data.Infrastructure;
using V.Model.Models;

namespace V.Data.Repositories
{
    public interface IOrderDetailRepository
    {
    }

    internal class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}