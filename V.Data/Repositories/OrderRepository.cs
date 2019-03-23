﻿using V.Data.Infrastructure;
using V.Model.Models;

namespace V.Data.Repositories
{
    public interface IOrderRepository
    {
    }

    internal class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}