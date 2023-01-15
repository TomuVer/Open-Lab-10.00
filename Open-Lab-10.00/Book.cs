using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    public class Book
    {
        //Premenné stRing
        private string title;
        private string category;
        private string author;

        //Premenné int
        private int pages;
        private int releaseDate;

        //Metódy string na ukladanie údajov
        public void Title(string title) 
        {
            this.title = title;
        }

        public void Category(string category)
        {
            this.category = category;
        }

        public void Author(string author)
        {
            this.author = author;
        }

        //Metódy int na ukladanie údajov 
        public void Pages(int pages)
        {
            this.pages = pages;
        }

        public void ReleaseDate(int releaseDate) 
        {
            this.releaseDate = releaseDate;
        }

        //Metóda ktorá vypíše všetky premenné
        public void WriteAll() 
        {
            Console.WriteLine(title);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(pages);
            Console.WriteLine(releaseDate);            
        }
    }
}
