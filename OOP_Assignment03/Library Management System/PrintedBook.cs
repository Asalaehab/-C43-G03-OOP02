using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03.Library_Management_System
{
    internal class PrintedBook:book
    {
        public PrintedBook(string title,string author,int isbn,int pageCount):base(title,author,isbn)
        {
            PageCount = pageCount;
        }

        public int PageCount {  get; set; }


    }
}
