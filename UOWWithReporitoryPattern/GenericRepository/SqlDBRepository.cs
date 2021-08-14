using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;
using UOWWithReporitoryPattern.ModelEntiry;

namespace UOWWithReporitoryPattern.GenericRepository
{
    public abstract class SqlDBRepository : ISqlDBRepository
    {
        private bool isDisposed;
        protected UOWDBContext _context;

        public SqlDBRepository(UOWDBContext context)
        {
            _context = context;
        }

        public void AddObject<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
        }
        public void UpdateObject<T>(T entity) where T : class
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void DeleteObject<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAllAsync<T>() where T : class
        {
            return _context.Set<T>().AsEnumerable();
        }

        public virtual void Dispose(bool isManuallyDisposing)
        {
            if (!isDisposed)
            {
                if (isManuallyDisposing)
                    _context.Dispose();
            }

            isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~SqlDBRepository()
        {
            Dispose(false);
        }

    }

}
