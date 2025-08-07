using S5.Overriding;

namespace S5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Binding

            // Ref From Parent [Base] => object from Child [Dervied]

            TypeA typeA = new TypeB(1,2); 
            typeA.A = 1;
            //typeA.B = 2; // Invalid
            typeA.MyFun01(); // Static poly - static Binding - Early Binding
                             // Compilation Time
                             // override [new]
                             // Resolve At Compile Time Based on Ref Type
            typeA.A = 2;     
            typeA.MyFun02();// Dynamic poly = Dynamic Binding - Lae Binding
                            // Run Time
                            // override [override]
                            // Resolve at Run Time Based on object Type

            #endregion
        }
    }
}
