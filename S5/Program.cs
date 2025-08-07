using S5.Binding;
using S5.Overriding;

namespace S5
{
    internal class Program
    {

        public static void ProccessEmployee(Employee employee)
        {
            if(employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }
        }
        //public static void ProccessEmployee(PartTimeEmployee employee)
        //{
        //    if(employee is not null)
        //    {
        //        employee.GetEmployeeType();
        //        employee.GetEmployeeData();
        //    }
        //}
        static void Main(string[] args)
        {
            #region Binding
            #region Example 01

            // Ref From Parent [Base] => object from Child [Dervied]

            //TypeA typeA = new TypeB(1, 2);
            //typeA.A = 1;
            ////typeA.B = 2; // Invalid
            //typeA.MyFun01(); // Static poly - static Binding - Early Binding
            //                 // Compilation Time
            //                 // override [new]
            //                 // Resolve At Compile Time Based on Ref Type
            //typeA.A = 2;
            //typeA.MyFun02();// Dynamic poly = Dynamic Binding - Lae Binding
            //                // Run Time
            //                // override [override]
            //                // Resolve at Run Time Based on object Type

            #endregion
            #region Example 02

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10, "Ahmed", 25, 2000);
            ProccessEmployee(fullTimeEmployee);

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(10,"Ahmed",25,2,5);
            ProccessEmployee(partTimeEmployee);

            #endregion
            #endregion
        }
    }
}
