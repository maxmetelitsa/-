using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    public class ActualEmployeeSalaryByJobAndContract : Payroll
    {
        public double NewSalary(Employee employee)
        {
            double percent = employee.Contract.Sum * 0.07;
            double salary = 0;
            double sal = employee.Position.BaseHourlyrate;

            for (int i = 0; i < employee.TimeboardGS.Timesheets.Length; i++)
            {
                salary += (employee.TimeboardGS.Timesheets[i].Hours * sal);
            }
            salary += percent;
            if (employee.IsMemberOfLaborUnion == true)
            {
                salary -= (salary * 0.01);
            }
            double s = salary;
            s = s - (s * 0.13);
            return s;
        }
    }
}
