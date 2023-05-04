using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            Console.WriteLine(fan1.Speed);
            fan1.PrintInfo();
        }
    }
}
