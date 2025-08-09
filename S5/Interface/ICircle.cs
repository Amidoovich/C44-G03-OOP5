using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5.Interface
{
    internal interface ICircle : IShape
    {
        public float Radius { get; set; }
    }
}
