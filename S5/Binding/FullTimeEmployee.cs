using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5.Binding
{
    internal class FullTimeEmployee : Employee
    {
        #region Properties

        public decimal Salary { get; set; }

        #endregion

        #region Constructor

        public FullTimeEmployee(int id,string? name,int age,decimal salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }

        #endregion

        #region Methods
        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Full Employee");
        }

        public override void GetEmployeeData()
        {
            base.GetEmployeeData();
            Console.WriteLine($"Salary = {Salary:c}");
        }

        #endregion
    }
}
