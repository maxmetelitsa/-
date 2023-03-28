using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_1
{
    public class Contract
    {
        int number;
        DateTime date;
        string client;
        double sum;
        string comment;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Client
        {
            get { return client; }
            set { client = value; }
        }
        public double Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        public string Comment
        { 
            get { return comment; }
            set { comment = value; }
        }
        public Contract()
        { 

        }
        public Contract(int number, DateTime date, string client, double sum, string comment)
        {
            Number = number;
            Date = date;
            Client = client;
            Sum = sum;
            Comment = comment;
        }
    }
}
