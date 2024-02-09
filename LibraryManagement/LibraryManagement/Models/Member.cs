using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Member
    {

        public string Name { get; set; }
        public string MembershipType { get; set; }
        public bool FinesOwed { get; set; }

        public void BorrowBook(Book book)
        {
            if(FinesOwed == true)
            {
                Console.WriteLine($"Sizin borcunuz var ona gore bu kitabi: {book.Title} goture bilmezsiz!! Cenab/Xanim: {Name}");
            }
            else
            {
                Console.WriteLine($"Bu kitabi goture bilersiniz: {book.Title}  Cenab/Xanim: {Name} ");
                FinesOwed = true;
            }
        }

        public void ReturnBook(Book book)
        {
            if (FinesOwed == true)
            {
                Console.WriteLine($"Bu kitabi qaytardiniz: {book.Title} Cenab/Xanim : {Name} ");
                FinesOwed = false;
                book.ReturnBook(this);
            }
            else
            {
                Console.WriteLine($"Sizin borcunuz yoxdur !!");
            }
        }

        public void DisplayDetails()
        {
            Console.Write($"Siz Cenab/Xanim {Name}\nKitabxanamizda uzvluk novunuz: {MembershipType}\nBorcunuz: {FinesOwed}" );
        }

    }
}
