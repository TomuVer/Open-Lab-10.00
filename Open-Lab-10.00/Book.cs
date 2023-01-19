using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        //Všetky vlastnosti premenných
        public string Title
        {
            set { this.title = value; }
            get { return title; }
        }

        public string Category
        {
            set { this.category = value; }
            get { return category; }
        }

        public string Author
        {
            set { this.author = value; }
            get { return author; }
        }
        public int Pages
        {           
            get { return pages; }
            set { 
                    if(pages < 0) 
                    {
                        pages = 1;              
                    }

                    else
                    {
                       pages = value;
                    }
            }
        }

        public int ReleaseDate
        {
            get { return releaseDate; }
            set {
                    if(releaseDate >= 1450 && releaseDate <= 2021) 
                    {
                        releaseDate = -1;
                    }

                    else 
                    {
                        releaseDate = value;
                    }
            }
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
