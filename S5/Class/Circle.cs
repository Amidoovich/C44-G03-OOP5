using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S5.Interface;

namespace S5.Class
{
    internal class Circle : ICircle
    {
        public float Radius { get; set; }
        public float Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Info:\nArea = {Area}\nRadius = {Radius}");
        }
    }
}
