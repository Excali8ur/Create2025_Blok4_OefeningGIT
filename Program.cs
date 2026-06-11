using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Dobbelsteen_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beker beker = new Beker(100);

            List<int> worpen = beker.RolDobbelstenen();
            Console.WriteLine(worpen.Count > 0 ? string.Join(" - ", worpen) : "Beker is leeg");

            Beker legeBeker = new Beker();
            worpen = legeBeker.RolDobbelstenen();
            Console.WriteLine(worpen.Count > 0 ? string.Join(" - ", worpen) : "Beker is leeg");

            Console.WriteLine("Stan was here");

            /*
            Dobbelsteen blauweD6 = new Dobbelsteen();
            Console.WriteLine(blauweD6.naam);

            blauweD6.naam = "Nieuwe Naam";
            blauweD6.zijden = 6;
            blauweD6.kleur = "blauw";
            blauweD6.waarden = new List<int>{1, 2, 3, 4, 5, 6 };

            Console.WriteLine(blauweD6.naam);

            List<int> waardenlijst = new List<int>() { 1, 2, 3, 4};
            Dobbelsteen rodeD4 = new Dobbelsteen(4, waardenlijst, "Roze", "Kaassoufle");
            
            int zijden = 20;
            Dobbelsteen myLuckyDice = new Dobbelsteen(zijden, 1, 20);
            myLuckyDice.naam = "Lucky";
            myLuckyDice.vorm = "Polydice";
            myLuckyDice.materiaal = "Plastic";
            myLuckyDice.kleur = "Donkerpaars met goud";

            Console.WriteLine(myLuckyDice.Print());    
            */

            /*
            //Oefening met Random
            Random dobbelsteen1 = new Random(DateTime.Now.Millisecond);
            Random dobbelsteen2 = new Random(DateTime.Now.Millisecond);

            int i = 1;
            while (i <= 30)
            {
                Console.WriteLine($"Het {i}e getal is: {dobbelsteen1.Next(1, 7)}");
                Console.WriteLine($"Het {i}e getal is: {dobbelsteen2.Next(1, 7)}");
                Console.WriteLine("*****");
                i++;
            }*/

        }
    }
}
