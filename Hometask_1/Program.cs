using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timesheet[] timesheet = { new Timesheet(new DateTime(2023, 02, 02), 6), new Timesheet(new DateTime(2023, 02, 03), 4), new Timesheet(new DateTime(2023, 02, 04), 8) };
            Position[] position = { new Position("UV1856", "Директор", 35.8), new Position("WK1510", "Java-разработчик", 20.8), 
                                    new Position("FAV783", "C#-разработчик", 19.8), new Position("X1856", "Менеджер", 13.9),
                                    new Position("IO7892", "Руководитель", 18.5), new Position("FR7382", "Front-разработчик", 17.9)
            };
            Console.WriteLine("Введите начальную дату табеля сотрудника: ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечную дату табеля сотрудника: ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Укажите табельный номер сотрудника: ");
            int tnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ФИО сотрудника: ");
            string fullname = Console.ReadLine();
            Console.WriteLine("Укажите рейтинг сотрудника (от 1 до 5): ");
            int rating = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату приема сотрудника на работу: ");
            DateTime acception_dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Укажите, принадлежит ли сотрудник профсоюзу: ");
            bool ismember = bool.Parse(Console.ReadLine());
            Console.WriteLine("Выберите должность сотрудника: ");
            for(int i = 0; i < position.Length;i++)
            {
                Console.WriteLine("Должность " + (i + 1) + $":\nКод: {position[i].Code}\nСпециальность: {position[i].Name}\nПочасовая оплата: {position[i].BaseHourlyrate}\n");
            }
            int pos = int.Parse(Console.ReadLine());
            Position chosen_pos = position[pos - 1];
            Console.WriteLine("Заполните рабочие часы табеля\n");
            Timeboard timeboard1 = new Timeboard(startDate, endDate);
            Console.WriteLine("Заполните контракт сотрудника: ");

            Console.WriteLine("Укажите номер контракта: ");
            int cnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Укажите дату заключения контракта: ");
            DateTime cdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите ФИО заказчика: ");
            string client = Console.ReadLine();

            Console.WriteLine("Укажите сумму контракта: ");
            double sum = double.Parse(Console.ReadLine());

            Console.WriteLine("Укажите комментраий к контракту: ");
            string comment = Console.ReadLine();

            Contract contract = new Contract(cnumber, cdate, client, sum, comment);

            Employee employee = new Employee(tnumber, fullname, rating, acception_dt, ismember, chosen_pos, timeboard1, contract, 1);

            employee.Print();
            Console.WriteLine("ffff");
            Console.WriteLine($"Старая зарплата: {employee.Salaries()}");

            for(int i = 1; i <= 7; i++)
            {
                Console.WriteLine($"Зарплата по схеме {i}: {Employee.NewSalary(employee)}");
            }
        }
    }
}
