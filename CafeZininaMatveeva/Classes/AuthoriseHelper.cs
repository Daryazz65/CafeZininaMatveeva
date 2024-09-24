using CafeZininaMatveeva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeZininaMatveeva.Classes
{
    internal class AuthoriseHelper
    {
        public static Employee selectedEmployee;

        public static bool Authorise(string login, string password)
        {
            List<Employee> employees = App.context.Employee.ToList();
            foreach (Employee employee in employees)
            {
                if (employee.Login == login && employee.Password == password)
                {
                    selectedEmployee = employee;
                    return true;
                }
            }
            if (selectedEmployee != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
