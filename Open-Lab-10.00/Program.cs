using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nový objekt LOTR z triedy Book
            Book LOTR = new Book();

            //
            LOTR.Title("Ondrejove Dobrodrušstvá");
            LOTR.Category("BioGrafia");
            LOTR.Author("Ondrej Vykriváčsky");

            LOTR.Pages(120);
            LOTR.ReleaseDate(2020);

            //Vypíše všetky premenné z triedy Book
            LOTR.WriteAll();
            Console.ReadKey();
        }
    }
}
