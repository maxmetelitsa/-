using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    public class ActualSalaryByJob
    {
        public double NewSalary(Employee employee)
        {
            double salary = 0;
            double sal = employee.Position.BaseHourlyrate;

            for (int i = 0; i < employee.TimeboardGS.Timesheets.Length; i++)
            {
                salary += (employee.TimeboardGS.Timesheets[i].Hours * sal);
            }
            if (employee.IsMemberOfLaborUnion == true)
            {
                salary -= (salary * 0.005);
            }
            salary = salary - (salary * 0.13);
            return salary;
        }
    }
}
