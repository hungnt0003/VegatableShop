using System;

namespace V.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        VDbContext Init();
    }
}