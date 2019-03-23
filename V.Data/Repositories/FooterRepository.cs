using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V.Data.Infrastructure;
using V.Model.Models;

namespace V.Data.Repositories
{
    public interface IFooterRepository
    {

    }
    internal class FooterRepository:RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
