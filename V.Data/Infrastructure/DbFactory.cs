using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        VDbContext dbContext;
        public VDbContext Init()
        {
            return dbContext ?? (dbContext = new VDbContext());
        }

        protected override void DisposeCore()
        {
            if(dbContext !=null)
            {
                dbContext.Dispose();
            }
        }
    }
}
