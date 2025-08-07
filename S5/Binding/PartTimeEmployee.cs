using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace S5.Binding
{
    internal class PartTimeEmployee : Employee
    {
        #region Properties
        public decimal HourRate  { get; set; }
        public int  CountOfHours { get; set; }
        #endregion

        #region Constructor
        public PartTimeEmployee(int id,string? name,int age,decimal hourRate,int countOfHours)
        {
            Id = id;
            Name = name;
            Age = age;
            HourRate = hourRate;
            CountOfHours = countOfHours;

        }

        #endregion

        #region Methods

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am part Employee");
        }

        public override void GetEmployeeData()
        {
            base.GetEmployeeData();
            Console.WriteLine($"Hour Rate : {HourRate}\nCountOfHours : {CountOfHours}");
        }
        #endregion
    }
}
