using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;

namespace UOWWithReporitoryPattern.Repositories
{
    public interface ICustomerRepository : IDisposable
    {
        Task<IEnumerable<T>> GetAllActiveCustomersAsync<T>() where T : class;
    }
}
