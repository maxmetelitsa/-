using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    public class Timesheet
    {
        public DateTime Date { get; set; }
        public double Hours { get; set; }

        public Timesheet(DateTime date, double hours)
        {
            Date = date;
            Hours = hours;
        }
    }
}
