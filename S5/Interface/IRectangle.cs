using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5.Interface
{
    internal interface IRectangle : IShape
    {
        public float Width { get; set; }
        public float Height { get; set; }
    }
}
