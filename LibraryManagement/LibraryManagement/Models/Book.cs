using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublicationYear { get; set; }
        public bool CopiesAvailable { get; set; }



        public void BorrowBook(Member member)
        {
          
            if (CopiesAvailable == false)
                Console.WriteLine("Bu kitabi goture bilmezsiz: " + Title + "yoxdur cunki");
            else {
                Console.WriteLine("Bu kitabi goturubdur:  " + Title);
                member.FinesOwed = true; 
                CopiesAvailable = false;
            }
                
            
        }

        public void ReturnBook(Member member)
        {
              CopiesAvailable = true;
                
        }

        public void DisplayDetails()
        {
            Console.Write($"Kitabin adi:{Title};\nKitabin janri:{Genre};\nKitabin muellifi:{Author};\nKitabin nesr ili:{PublicationYear};\nKitabin movcudlugu:{CopiesAvailable}");
        }
    }
}
