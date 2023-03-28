using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    public interface Payroll
    {
        double NewSalary(Employee employee);
    }
    //public class Payrol
    //{
    //    public static double StateEmployeeSalary(Employee employee)
    //    {
    //        return employee.Salaries();
    //    }
    //    public static double AnotherEmployeeSalary(Employee employee)
    //    {
    //        double percent = employee.Contract.Sum * 0.95;
    //        return employee.Salaries() + percent;
    //    }
    //    public static double ActualSalary(Employee employee)
    //    {
    //        double salary = 0;
    //        double bonus_rate = (employee.Rating - 1) * 10;
    //        double sal = employee.Position.BaseHourlyrate + ((employee.Position.BaseHourlyrate / 100.0) * bonus_rate);

    //        for (int i = 0; i < employee.TimeboardGS.Timesheets.Length; i++)
    //        {
    //            salary += (employee.TimeboardGS.Timesheets[i].Hours * sal);
    //        }
    //        if (employee.IsMemberOfLaborUnion == true)
    //        {
    //            salary -= (salary * 0.15);
    //        }
    //        return salary;
    //    }
    //    public static double ActualSalaryByJob(Employee employee)
    //    {
    //        double salary = 0;
    //        double sal = employee.Position.BaseHourlyrate;

    //        for (int i = 0; i < employee.TimeboardGS.Timesheets.Length; i++)
    //        {
    //            salary += (employee.TimeboardGS.Timesheets[i].Hours * sal);
    //        }
    //        if (employee.IsMemberOfLaborUnion == true)
    //        {
    //            salary -= (salary * 0.005);
    //        }
    //        return salary;
    //    }
    //    public static double ActualEmployeeSalaryByJobAndContract(Employee employee)
    //    {
    //        double percent = employee.Contract.Sum * 0.93;
    //        double salary = 0;
    //        double sal = employee.Position.BaseHourlyrate;

    //        for (int i = 0; i < employee.TimeboardGS.Timesheets.Length; i++)
    //        {
    //            salary += (employee.TimeboardGS.Timesheets[i].Hours * sal);
    //        }
    //        salary += percent;
    //        if (employee.IsMemberOfLaborUnion == true)
    //        {
    //            salary -= (salary * 0.01);
    //        }
    //        return salary;
    //    }

    //}
}
