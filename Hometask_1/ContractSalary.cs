using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    public class ContractSalary
    {
        public double NewSalary(Employee employee)
        {
            double s = employee.Contract.Sum * 0.1;
            return s -= s * 0.13;
        }
    }
}
