using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5.Interface
{
    internal interface IShape
    {
        public float Area { get; set; }

        public void DisplayShapeInfo();
    }
}
