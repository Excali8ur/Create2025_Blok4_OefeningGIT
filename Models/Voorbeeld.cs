using System;
using System.Collections.Generic;
using System.Text;

namespace Reisbureau.Models
{
    public class Voorbeeld
    {
        //Attribuut / Eigenschap        
        private int getal;
        //Property voor getal
        public int Getal
        {
            get { return getal; }
            set
            {
                if (value > 0)
                {
                    getal = value;
                }
            }
        }

        //Read-only Property, zonder los attribuut
        public string Tekst { get; private set; }

        //Constructor
        public Voorbeeld()
        {
            Tekst = "Dit is een standaard tekst";
        }

        public void PasTekstAan(string tekst)
        {
            this.Tekst = $"{getal}: {tekst}";
        }

    }
}
