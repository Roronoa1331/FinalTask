using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Library
    {
        public List<Book> ListBook;
        public List<Member> ListMember;


        public Library()
        {
            ListBook = new List<Book>();
            ListMember = new List<Member>();
        }

        public void AddBook(Book book)
        {
            ListBook.Add(book);
        }
        public void AddMember(Member member)
        {
            ListMember.Add(member);
        }
        public void DisplayInventory()
        {
            for(int i = 0; i < ListBook.Count; i++)
            {
                Console.WriteLine($"Bu adam:{ListMember[i].Name} Bu kitabi aldi: {ListBook[i].Title}");
            }
        }
        

    }
}
