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
            Fan Fan1 = new Fan(Fan.Fast, true, 10, "yellow");
            Console.WriteLine(Fan1.ToString());
            Fan Fan2 = new Fan(Fan.Medium, false, 5, "blue");
            Console.WriteLine(Fan2.ToString());
            Console.WriteLine("=======================");
            
        }
    }
}
