using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5.Overriding
{
    internal class TypeD : TypeC
    {
        public  int  D { get; set; }

        public TypeD(int a,int b,int c,int d) : base(a,b,c)
        {
            D = d;
        }

        public new void MyFun01()
        {
            Console.WriteLine("I am TypeD [Chid Grand Child]");
        }

        public virtual new void MyFun02()
        {
            Console.WriteLine($"TypeD : A = {A} , B = {B} , C = {C}, D = {D}");
        }
    }
}
