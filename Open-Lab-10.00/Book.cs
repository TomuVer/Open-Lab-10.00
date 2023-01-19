using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._02
{
    internal class Book
    {
        private string title;
        private string category;
        private string author;
        private string relaseDate;
        private int pages;

        public string Title(string xtitle)
        {
            this.title = xtitle;
            return title;
        }
        public string Category(string xcate)
        {
            this.category = xcate;
            return category;
        }
        public string Author(string xauthor)
        {
            this.author = xauthor;
            return author;
        }
        public string RelaseDate(string xrelaseDate)
        {
            this.relaseDate = xrelaseDate;
            return relaseDate;
        }
        public int Pages(int xpages)
        {
            this.pages = xpages;
            return pages;
        }

        public void Vypis()
        {
            Console.WriteLine(Category(category));
            Console.WriteLine(Author(author));
            Console.WriteLine(Title(title));
            Console.WriteLine(RelaseDate(relaseDate));
            Console.WriteLine("number of pages: " + Pages(pages));
        }
    }
}
