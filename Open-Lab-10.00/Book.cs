using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    public class Book
    {
        //Premenné string
        public string title;

        //Premenné int
        private int pages;
        
        //Metóda ktorá vypíše všetky premenné
        public void WriteAll() 
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
        }
    }
}
