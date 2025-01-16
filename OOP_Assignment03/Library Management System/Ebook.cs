using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03.Library_Management_System
{
    class Ebook:book
    {
       
        #region Properties
        public int FileSize { get; set; }
        #endregion

        #region Constructor
        public Ebook(string? title, string? author, int isbn, int fileSize)
           : base(title, author, isbn) {  
            FileSize = fileSize;
        }
        #endregion

    }
}
