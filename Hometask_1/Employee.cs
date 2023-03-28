using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    public class Employee : Payroll
    {
        public int Number { get; set; }
        public string Fullname { get; set; }

        int rating;
        public int Rating
        {
            get { return rating; }
            set
            {
                if(value >= 1  && value <=5)
                {
                    rating = value;
                }
                else
                {
                    throw new Exception("Неверное значение рейтинга");
                }
            }
        }
        DateTime EmploymentDate { get; set; }
        bool isMemberOfLaborUnion;
        public bool IsMemberOfLaborUnion
        {
            get { return isMemberOfLaborUnion; }
            set { isMemberOfLaborUnion = value ; }
        }

        Timeboard Timeboard;
        public Timeboard TimeboardGS
        {
            get { return Timeboard; }
            set { Timeboard = value; }
        }

        public Position Position { get; set; }

        Contract contract;
        public Contract Contract
        {
            get { return contract; }
            set { contract = value; }
        }
        int scheme;
        public int Scheme
        {
            get { return scheme; }
            set { scheme = value; }
        }
        public Employee(int number, string fullname, int rating, DateTime employmentDate, bool isMemberOfLaborUnion, Position position, Timeboard timeboard, Contract contract, int scheme)
        {
            Number = number;
            Fullname = fullname;
            Rating = rating;
            EmploymentDate = employmentDate;
            IsMemberOfLaborUnion = isMemberOfLaborUnion;
            TimeboardGS = timeboard;
            Position = position;
            Contract = contract;
            Scheme = scheme;
        }
        public void Print()
        {
            Console.WriteLine($"\nИнформация о сотруднике\nНомер: {Number}\nФИО: {Fullname}\nРазряд: {Rating}\nДата приема на работу: {EmploymentDate}\nПринадлежность профсоюзу: {IsMemberOfLaborUnion}\nДолжность: {Position.Name}");
            int reason = (int)(Timeboard.EndDate - Timeboard.StartDate).TotalDays;
            Console.WriteLine("Табель рабочего времени:\n");

            for (int i = 0; i <= reason; i++)
            {
                Console.WriteLine($"{Timeboard.Timesheets[i].Date} ({Timeboard.Timesheets[i].Date.DayOfWeek})\t\t{Timeboard.Timesheets[i].Hours} час.");
            }
        }
        public static double NewSalary(Employee employee)
        {
            double sal = 0;
            int check = employee.Scheme;
            switch(employee.Scheme)
            {
                case 1:
                    {
                        StateEmployeeSalary salary = new StateEmployeeSalary();
                        sal = salary.NewSalary(employee);
                        break;
                    }
                case 2:
                    {
                        AnotherEmployeeSalary salary = new AnotherEmployeeSalary();
                        sal = salary.NewSalary(employee);
                        break;
                    }
                case 3:
                    {
                        ActualSalary salary = new ActualSalary();
                        sal = salary.NewSalary(employee);
                        break;
                    }
                case 4:
                    {
                        ActualSalaryByJob salary = new ActualSalaryByJob();
                        sal = salary.NewSalary(employee);
                        break;
                    }
                case 5:
                    {
                        ActualEmployeeSalaryByJobAndContract salary = new ActualEmployeeSalaryByJobAndContract();
                        sal = salary.NewSalary(employee);
                        break;
                    }
                case 6:
                    {
                        ContractSalary salary = new ContractSalary();
                        sal = salary.NewSalary(employee);
                        break;
                    }
            }
            return sal;
        }
        public double Salaries()
        {
            double salary = 0;
            double dif = 0;
            double bonus_rate = (Rating - 1) * 10;
            double sal = Position.BaseHourlyrate + ((Position.BaseHourlyrate / 100.0) * bonus_rate);

            for (int i = 0; i < TimeboardGS.Timesheets.Length; i++)
            {
                if(TimeboardGS.Timesheets[i].Date.DayOfWeek == DayOfWeek.Saturday || TimeboardGS.Timesheets[i].Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    salary += TimeboardGS.Timesheets[i].Hours * sal * 2;
                }
                else
                {
                    if (TimeboardGS.Timesheets[i].Hours > 8.0)
                    {
                        dif = TimeboardGS.Timesheets[i].Hours - 8.0;
                        salary += ((TimeboardGS.Timesheets[i].Hours - 2) * sal) + (dif * sal * 2);
                    }
                    else
                    {
                        salary += (TimeboardGS.Timesheets[i].Hours * sal);
                    }
                }
            }
            if(IsMemberOfLaborUnion == true)
            {
                salary = salary - (salary * 0.15);
            }
            else
            {
                salary = salary - (salary * 0.13);
            }

            return salary;
        }
    }
}
