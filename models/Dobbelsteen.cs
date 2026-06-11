using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Dobbelsteen_Demo //Nino was hier!
{
    public class Dobbelsteen
    {
        //Eigenschappen (= attributen)
        private int _laatsteWorp = -1;
        public int laatsteWorp
        {
            get{
                if (_laatsteWorp < 0)
                {
                    Rollen();
                }
                return _laatsteWorp;
            }
            private set { _laatsteWorp = value; } }

        private int _zijden;
        public int zijden
        {
            get { return _zijden; }
            set
            {
                if (value > 0)
                {
                    _zijden = value;
                }
            }
        }


        public List<int> waarden;
        public string kleur;
        public string naam;
        public string vorm;
        public string materiaal;
        public string test;

        //private static Random willekeurigewaarde = new Random();
        private Random willekeurigewaarde = new Random();


        //Constructor
        public Dobbelsteen(int seed) 
        {
            willekeurigewaarde = new Random(seed);

            naam = "Standaard dobbelsteen";
            zijden = 6;
            kleur = "blauw";
            waarden = new List<int> { 1, 2, 3, 4, 5, 6 };
            materiaal = "Plastic";
            vorm = "Kubus";
        }

        //Constructor met parameters
        public Dobbelsteen(int zijden, List<int> waarden, string kleur, string naam)
        {
            this.zijden = zijden;
            this.waarden = waarden;
            this.kleur = kleur;
            this.naam = naam;
        }

        public Dobbelsteen(int zijden, int startwaarde, int stopwaarde)
        {
            this.zijden = 20;
            naam = "Standaard dobbelsteen";
            kleur = "blauw";

            this.waarden = new List<int>();

            int stapgrote = (stopwaarde - startwaarde)/zijden;
            if (stapgrote <= 0) { stapgrote = 1; }
            for (int i = startwaarde; i <= stopwaarde; i+=stapgrote)
            {
                this.waarden.Add(i);
            }
        }

        //Gedrag (= Methoden)
        public int Rollen()
        {
            _laatsteWorp = willekeurigewaarde.Next(1, zijden + 1);
            return _laatsteWorp;
        }

        public string Print()
        {
            string tekst = "";
            tekst += $"Naam = {this.naam}; Kleur: {this.kleur}; Waarden:";
            //tekst += $"Waarden: {this.waarden}";
            foreach (int waarde in waarden)
            {
                tekst += $" {waarde}, ";
            }

            waarden.ForEach(w => tekst += $" *{w}* ");

            tekst += string.Join(", ", waarden);

            return tekst;
        }








        /*
        //ToString overload
        public override string ToString()
        {
            // Return a string representation of the Dobbelsteen object
            return $"Naam: {naam}, Zijden: {zijden}, Kleur: {kleur}" +
                $"\nWaarden: {string.Join(", ", waarden ?? new List<int>())}";
        }
        */

    }
}
