using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOWWithReporitoryPattern.GenericRepository;
using UOWWithReporitoryPattern.ModelEntiry;
using UOWWithReporitoryPattern.NewFolder1;
using UOWWithReporitoryPattern.Repositories;

namespace UOWWithReporitoryPattern
{
    public class ExampleClass
    {
        public void UnitOfWorkWithRepositoryPattern()
        {
            Model1 modelContext = new Model1();
            var xxx = modelContext.EncCellCustomerPermits.Take(50).ToListAsync().Result;


            UOWDBContext context = new UOWDBContext();

            CustomerRepository customerRepository = new CustomerRepository(context);
           // var activeCustomers = customerRepository.GetAllActiveCustomersAsync<Customer>().Result;
        }
    }
}
