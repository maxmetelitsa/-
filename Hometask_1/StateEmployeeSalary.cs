using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    public class StateEmployeeSalary : Payroll
    {
        public double NewSalary(Employee employee)
        {
            double s = employee.Salaries();
            return s -= s * 0.13;
        }
    }
}
