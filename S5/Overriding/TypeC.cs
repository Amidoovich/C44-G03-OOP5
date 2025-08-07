using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5.Overriding
{
    internal class TypeC : TypeB
    {
        #region Properties
        public int C { get; set; }
        #endregion

        #region Constructors

        public TypeC(int a,int b,int c) : base(a,b)
        {
            C = c;
        }
        #endregion

        #region Methods

        public new void MyFun01()
        {
            Console.WriteLine("I am TypeC [Grand Child]");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeC : A = {A} , B = {B} , C = {C}");
        }

        #endregion
    }
}
