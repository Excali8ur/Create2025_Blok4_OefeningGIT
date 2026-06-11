using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reisbureau.DataAccess;
using Reisbureau.Models;

namespace Reisbureau
{
    public class Program
    {
        static void Main(string[] args)
        {
            DalSQL dalSQL = new DalSQL(".", "Reisbureau");

            string uitkomst = dalSQL.OphalenKlant(56955);

            Console.WriteLine(uitkomst);

            uitkomst = dalSQL.OphalenKlant(56973);

            Console.WriteLine(uitkomst);

            /*
            Console.WriteLine("Hello, World!");

            Voorbeeld voorbeeld = new Voorbeeld();

            Console.WriteLine("Geef een getal:");
            int getal = int.Parse(Console.ReadLine());

            voorbeeld.Getal = getal;

            Console.WriteLine(voorbeeld.Tekst);
            voorbeeld.PasTekstAan("Nieuwe Tekst...");
            Console.WriteLine(voorbeeld.Tekst);
            */
        }
    }
}
