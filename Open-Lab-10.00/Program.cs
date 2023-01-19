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

            //.
            LOTR.Title = "Ondrejove Dobrodružstvá";
            LOTR.Author = "Ondrej Barčišiak";
            LOTR.Category = "BioGrafia";

            LOTR.Pages = 120;
            LOTR.ReleaseDate = 2021;

            //Vypíše všetky premenné z triedy Book
            Console.WriteLine(LOTR.Title);
            Console.WriteLine(LOTR.Author);
            Console.WriteLine(LOTR.Category);

            Console.WriteLine(LOTR.Pages);
            Console.WriteLine(LOTR.ReleaseDate);
            Console.ReadKey();
        }
    }
}
