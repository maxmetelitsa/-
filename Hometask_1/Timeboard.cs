using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    public class Timeboard
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Timesheet[] Timesheets { get; set; }

        public Timeboard(DateTime startDate, DateTime endDate)
        {
            DateTime stDate = startDate;
            StartDate = startDate;
            EndDate = endDate;

            int reason = (int)(EndDate - StartDate).TotalDays;
            Timesheets = new Timesheet[reason + 1];

            for (int i = 0; i < Timesheets.Length; i++)
            {
                Console.WriteLine($"Укажите количество часов {stDate}: ");
                int hours = int.Parse(Console.ReadLine());
                Timesheets[i] = new Timesheet(stDate, hours);
                stDate = stDate.AddDays(1);
            }
        }
    }
}
