using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services.Abstraction
{
    internal interface ILibrary
    {
        void AddBook(Book book);
        void AddMember(Member member);
        void DisplayBooks();
        void DisplayMembers();

    }
}
