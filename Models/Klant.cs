using System;
using System.Collections.Generic;
using System.Text;

namespace Reisbureau.Models
{
    public class Klant
    {
        public int klantNr;
        public string naam;
        public List<Boeking> boekingen;
    }
}
