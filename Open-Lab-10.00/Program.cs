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
            
            LOTR.Title("Ondrejove Dobrodružstvá");
            LOTR.Pages(120);
            LOTR.Category("BioGrafia");
            LOTR.Author("Ondrej Barčišiak");
            LOTR.RelaseDate("2021");
            LOTR.Vypis();

        }
    }
}
