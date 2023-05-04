using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    public class Fan
    {
        private const int _slow = 1;
        private const int _medium = 2;
        private const int _fast = 3;

        private int _speed = _slow;
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        //private bool on = false;
        //private double radius = 5;
        //private string color = "blue";

        public void PrintInfo()
        {
            Console.WriteLine(_slow);
        }

    }
}
