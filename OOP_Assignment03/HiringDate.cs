using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03
{
    internal class HiringDate
    {

        #region Properties
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        #endregion

        #region Constructor
        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        #endregion

    }
}
