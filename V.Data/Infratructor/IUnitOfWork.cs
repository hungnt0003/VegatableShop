namespace V.Data.Infratructor
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}