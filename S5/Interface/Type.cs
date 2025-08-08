using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5.Interface
{
    // Dev 02
    internal class Type : IType
    {
        public int MyProperty { get; set; }

        public void MyMethod()
        {
            Console.WriteLine("Hello Class"); 
        }
    }
}
