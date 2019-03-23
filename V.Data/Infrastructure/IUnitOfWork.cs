namespace V.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}