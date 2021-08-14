using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;
using UOWWithReporitoryPattern.GenericRepository;
using UOWWithReporitoryPattern.ModelEntiry;

namespace UOWWithReporitoryPattern.Repositories
{
    public class CustomerRepository : SqlDBRepository, ICustomerRepository
    {
        protected UOWDBContext _context;

        public CustomerRepository(UOWDBContext context) : base(context)
        {
            _context = context;
        }

        public Task<IEnumerable<T>> GetAllActiveCustomersAsync<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }

}
