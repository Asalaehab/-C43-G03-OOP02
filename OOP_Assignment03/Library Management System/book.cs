using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03.Library_Management_System
{
    internal class book
    {


        #region Properties
        public string? title { get; set; }
        public string? suthor { get; set; }
        public int ISBN { get; set; }
        #endregion

        #region Constructor
        public book(string? title, string? suthor, int iSBN)
        {
            this.title = title;
            this.suthor = suthor;
            ISBN = iSBN;
        }
        #endregion

    }
}
