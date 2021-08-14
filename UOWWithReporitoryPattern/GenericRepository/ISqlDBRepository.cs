using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;

namespace UOWWithReporitoryPattern.GenericRepository
{
    public interface ISqlDBRepository : IDisposable
    {
        IEnumerable<T> GetAllAsync<T>() where T : class;
        void AddObject<T>(T entity) where T : class;
        void DeleteObject<T>(T entity) where T : class;
        void UpdateObject<T>(T entity) where T : class;
    }
}
