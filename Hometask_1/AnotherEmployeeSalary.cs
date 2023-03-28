using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    public class AnotherEmployeeSalary : Payroll
    {
        public double NewSalary(Employee employee)
        {
            double percent = employee.Contract.Sum * 0.05;
            double s = employee.Salaries() + percent;
            s = s - (s * 0.13);
            return s;

        }
    }
}
