﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar2004
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Meccs("7up Joventut", "Adecco Estudiantes", 81, 73, "Palacio Mun. De Deportes De Badalona", "2005-04-03");
            Console.WriteLine($"{m.Hpont}");
            Console.ReadKey();
        }
    }
}
