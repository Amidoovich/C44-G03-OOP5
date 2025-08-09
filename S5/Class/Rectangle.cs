using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S5.Interface;

namespace S5.Class
{
    internal class Rectangle : IRectangle
    {
        public float Width { get ; set; }
        public float Height { get; set; }
        public float Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Info:\nArea = {Area}\nWidth = {Width}\nHeight = {Height}"); ;
        }
    }
}
