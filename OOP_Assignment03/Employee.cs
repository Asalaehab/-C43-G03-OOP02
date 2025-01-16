using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03
{
    internal class Employee
    {
        #region Properties
        public int id { get; set; }
        public string? name { get; set; }
        public decimal salary { get; set; }
        public string? hiredate { get; set; }
       public Gender gender { get; set; }
       public Security security { get; set; }
        #endregion
        #region Methodes
        public override string ToString()
        {
            return $"ID :{id}\nname : {name}\nsalary : {salary}\nhiredate : {hiredate}\nGender {gender}";
        }
        #endregion


    }
}
