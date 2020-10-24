using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Context context)
        {

            if (context.Employees.Any())
            {
                return;
            }

            Employee[] employees = new Employee[]
            {
                new Employee{FirstName = "Jason", LastName = "Prescot", PhoneNumber="123-242-1234", Role=Roles.Manager, Salary=10000},
                new Employee{FirstName = "Joel", LastName = "Hill", PhoneNumber="123-242-1876", Role=Roles.AssistantManager, Salary=50000},
                new Employee{FirstName = "Noah", LastName = "Sutherland", PhoneNumber="123-242-4598", Role=Roles.Cashier, Salary=20000}

            };

            foreach(Employee employee in employees)
            {
                context.Employees.AddRange(employees);
                context.SaveChanges();
            }
                
        }
    }
}
