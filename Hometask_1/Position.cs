using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    public class Position
    {
       public string Code { get; set; }
       public string Name { get; set; }
       public double BaseHourlyrate { get; set; }

        public Position(string code, string name, double baseHourlyrate)
        {
            Code = code;
            Name = name;
            BaseHourlyrate = baseHourlyrate;
        }
    }
}
