using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
	internal class HireDate
	
	{
        #region Attributes

        private int day;
		private int year;
		private int month;

		#endregion

		#region Properties
		public int Day
		{
			get { return day; }

			set
			{
				if (value <= 31)
					day = value;
				else Console.WriteLine("Invalid Day");

			}
		}

		public int Month
		{
			get { return month; }
			set
			{
				if (value <= 12)
					month = value;
				else Console.WriteLine("Invaild Month");

			}
		}

		public int Year
		{
			get { return year; }
			set
			{
				if (value <= 2025) year = value;
				else Console.WriteLine("Invalid Year");
			}
		}
        #endregion

        #region Methods
        public override string ToString()
        {
			return $"{Day}/{Month}/{Year}";
        }
        #endregion
    }
}
