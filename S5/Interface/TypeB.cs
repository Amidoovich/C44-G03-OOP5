using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5.Interface
{
    internal class TypeB : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 4;
        }
    }
}
