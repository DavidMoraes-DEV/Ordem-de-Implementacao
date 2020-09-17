using Course;
using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4k";
            p.Nome = "T";

            Console.WriteLine(p.Nome);
        }
    }
}
