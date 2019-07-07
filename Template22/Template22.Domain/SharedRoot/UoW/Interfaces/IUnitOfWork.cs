namespace Template22.Domain.SharedRoot.UoW.Interfaces
{
    public interface IUnitOfWork
    {
        bool Commit();
        void Dispose();
    }
}
