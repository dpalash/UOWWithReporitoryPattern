using DatabaseTest.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new Model1Container())
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                List<Employee> empList = new List<Employee>();
                for (int i = 0; i < 100000; i++)
                {
                    Employee em = new Employee() { Name = $"PD-{i}", Address = $"Dhaka -- 000 {i}" };
                    empList.Add(em);
                }
                // Stop timing.
                //stopwatch.Stop();
               // var ss = stopwatch.Elapsed.Minutes;

               // stopwatch = new Stopwatch();
               // stopwatch.Start();
               c.Employees.AddRange(empList);
              //  stopwatch.Stop();
              //  var sss = stopwatch.Elapsed.Minutes;

             //   stopwatch = new Stopwatch();
             //   stopwatch.Start();
                c.SaveChanges();
                stopwatch.Stop();
                var sssd = stopwatch.Elapsed.Minutes;
            }
        }
    }
}
