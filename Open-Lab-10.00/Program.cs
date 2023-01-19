using Open_Lab_10._02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title("title: Lord Of The Rings");
            LOTR.Pages(1172);
            LOTR.Category("category: epic high-fantasy novel");
            LOTR.Author("author: J. R. R. Tolkien");
            LOTR.RelaseDate("relase date: 29. July 1954");
            LOTR.Vypis();

        }
    }
}
