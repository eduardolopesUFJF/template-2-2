using Template22.Domain.SharedRoot.UoW.Interfaces;
using Template22.Infra.Data.SqlServer.Context;

namespace Template22.Domain.SharedRoot.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ServiceContext _context;

        public UnitOfWork(ServiceContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            var rowsAffected = _context.SaveChanges();
            return rowsAffected > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
