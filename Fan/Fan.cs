using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    public class Fan
    {
        public const int Slow = 1;
        public const int Medium = 2;
        public const int Fast = 3;

        #region use getter + setter
        private int _speed = Slow;
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        private bool _on = false;
        public bool On
        {
            get { return _on; }
            set { _on = value; }
        }

        private string _status = "off";
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        private double _radius = 5;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        private string _color = "blue";
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        #endregion

        public Fan()
        {

        }
        public Fan(int speed, bool on, double radius, string color)
        {
            this.Speed = speed;
            this.On = on;
            switch (On)
            {
                case true:
                    this.Status = "On";
                    break;
                case false:
                    this.Status = "Off";
                    break;
            }
            this.Radius = radius;
            this.Color = color;
        }

        public override string ToString()
        {
            return $"Speed = {Speed}, Status = {Status}, Radius = {Radius}, Color = {Color}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(Slow);
            Console.WriteLine(_on);
            Console.WriteLine(_radius);
            Console.WriteLine(_color);
        }

    }
}
