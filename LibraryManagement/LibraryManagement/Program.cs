using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Genre = "Fiction",
                PublicationYear = 1925,
                CopiesAvailable = true
            };

            Book book2 = new Book
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Genre = "Fiction",
                PublicationYear = 1960,
                CopiesAvailable = true
            };

            Member member1 = new Member
            {
                Name = "John Doe",
                FinesOwed = false
            };

            Member member2 = new Member
            {
                Name = "Jane Smith",
                FinesOwed = false
            };

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddMember(member1);
            library.AddMember(member2);

            // Borrowing books
            member1.BorrowBook(book1);
            member2.BorrowBook(book2);
            member1.BorrowBook(book2); // Trying to borrow an already borrowed book

            // Returning books
            member1.ReturnBook(book1);
            member2.ReturnBook(book2);

            // Displaying library inventory and members
            library.DisplayInventory();
        }
    }
}
