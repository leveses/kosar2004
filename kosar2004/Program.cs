using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kosar2004
{
    class Program
    {
        static List<Meccs> lista = new List<Meccs>();
        static void Main(string[] args)
        {
            var m = new Meccs("7up Joventut", "Adecco Estudiantes", 81, 73, "Palacio Mun. De Deportes De Badalona", "2005-04-03");
            Console.WriteLine($"{m.Hpont}");
            Beolvasas();
            HarmadikFeladat();
            Console.ReadKey();
        }
        static void Beolvasas()
        { 
            StreamReader file = new StreamReader("eredmenyek.csv");

            file.ReadLine();
            while (!file.EndOfStream)
            {
                string[] adat = file.ReadLine().Split(';');

                lista.Add(new Meccs(adat[0], adat[1], int.Parse(adat[2]), int.Parse(adat[3]), adat[4], adat[5]));
            }
            file.Close();
        }
        static void HarmadikFeladat()
        {
            int hazai = 0;
            int idegen = 0;
            foreach (var i in lista)
            {
                if (i.Hazai == "Real Madrid")
                {
                    hazai++;
                }
                if(i.Idegen == "Real Madrid")
                {
                    idegen++;
                }
            }
            //Alternatív megoldás
            //var hazais = from m in lista where m.Hazai == "Real Madrid" select m;
            //var hazaiDb = hazais.ToList().Count;
            //var idegens = from m in lista where m.Idegen == "Real Madrid" select m;
            //var idegenDb = idegens.ToList().Count;
            //Console.WriteLine($"Hazai: {hazaiDb}, Idegen: {idegenDb}");
            Console.WriteLine($"Hazai: {hazai}, Idegen: {idegen}");
        }
    }
}
