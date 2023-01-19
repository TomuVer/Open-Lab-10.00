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
            //Nový objekty z triedy Book
            Book LOTR2 = new Book();
            Book LOTR3 = new Book("Ondrejove Dobrodružstvá", 120);
            Book HOBBIT = new Book("Ondrejove Dobrodružstvá", "Ondrej Barčišiak", "BioGrafia", 120, 2021);

            //.
            LOTR2.WriteAll();
            LOTR3.WriteAll();
            HOBBIT.WriteAll();

            //.
            Console.ReadKey();
        } 
    }
}
