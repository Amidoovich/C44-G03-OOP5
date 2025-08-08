using S5.Binding;
using S5.Interface;
using S5.Overriding;
using Type = S5.Interface.Type;
using TypeA = S5.Interface.TypeA;
using TypeB = S5.Interface.TypeB;
using TypeC = S5.Interface.TypeC;

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

        static void PrintFiveNumbersFromSeries(ISeries series)
        {
            if (series is not null) 
            {
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();
                   
            }
            else
            {
                return;
            }
        }
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

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10, "Ahmed", 25, 2000);
            //ProccessEmployee(fullTimeEmployee);

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee(10,"Ahmed",25,2,5);
            //ProccessEmployee(partTimeEmployee);

            #endregion
            #region Example 03
            //TypeC typeC = new TypeC(1, 2, 3);
            //typeC.A = 10;
            //typeC.B = 20;
            //typeC.C = 30;
            //typeC.MyFun01();
            //typeC.MyFun02();

            //TypeA typeA = new TypeC(1,2,3);
            //typeA.A = 10;
            ////typeA.B = 10;
            ////typeA.C = 10;

            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeC(1,2,3);
            //typeB.A = 10;
            //typeB.B = 10;
            ////typeB.C = 10; // InVALID

            //typeB.MyFun01();
            //typeB.MyFun02();

            //TypeA typeA = new TypeD(1, 2, 3, 4);
            //typeA.A = 10;
            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeD(1, 2, 3, 4);
            //typeB.MyFun01();
            //typeB.MyFun02();

            //TypeC typeC = new TypeD(1, 2, 3, 4);
            //typeC.MyFun01();
            //typeC.MyFun02();

            //TypeA typeA = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);

            //typeA.MyFun02();
            //typeB.MyFun02();
            //typeC.MyFun02();
            //typeD.MyFun02();



            #endregion
            #endregion

            #region Interface

            #region Example 01
            //IType type = new Type();

            //type.MyProperty = 1;

            //type.MyMethod();

            //type.Print();

            //Type type = new Type();

            //type.MyProperty = 5;
            //type.MyMethod();
            ////type.Print(); 
            #endregion
            #region Example 02

            //TypeA typeA = new TypeA();
            //PrintFiveNumbersFromSeries(typeA);

            //TypeB typeB = new TypeB();
            //PrintFiveNumbersFromSeries(typeB);

            //TypeC typeC = new TypeC();
            ////PrintFiveNumbersFromSeries(typeC);
            #endregion
            #region Example 03
            //Car car = new Car();
            //car.Backward();
            //car.Right();
            //car.Forward();
            //car.Left();
            //car.Speed = 200;

            //IMoveOnAir airPlane = new AirPlane();
            ////airPlane.Speed = 200;
            //airPlane.Backward();
 
            #endregion
            #endregion



        }
    }
}
