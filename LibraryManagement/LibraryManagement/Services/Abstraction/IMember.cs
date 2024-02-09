using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services.Abstraction
{
    internal interface IMember
    {
        void BorrowBook(Book book);
        void ReturnBook(Book book);
        void DisplayDetails();



    }
}
