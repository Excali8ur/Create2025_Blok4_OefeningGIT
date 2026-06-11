using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Dobbelsteen_Demo
{
    public class Beker
    {
        private List<Dobbelsteen> dobbelstenen;

        /// <summary>
        /// Maak een lege beker aan
        /// </summary>

	    // Kasper was hier
        public Beker()
        {
            dobbelstenen = new List<Dobbelsteen>();
        }
        /// <summary>
        /// Maak een beker aan met een x aantal dobbelstenen
        /// Dit zijn standaard dobbelstenen met 6 zijden
        /// </summary>
        /// <param name="aantalDobbelstenen"></param>
        public Beker(int aantalDobbelstenen)
        {
            dobbelstenen = new List<Dobbelsteen>();
            for (int i = 0; i < aantalDobbelstenen; i++)
            {
                Dobbelsteen d = new Dobbelsteen();
                dobbelstenen.Add(d);
            }

        }

        public void VoegDobbelsteenToe()
        {
            Dobbelsteen d = new Dobbelsteen();
            dobbelstenen.Add(d);
        }

        public void VerwijderDobbelsteen()
        {
            if (dobbelstenen.Count > 0)
            {
                dobbelstenen.RemoveAt(0);
            }
        }

        public List<int> RolDobbelstenen()
        { 
            List<int> worpen = new List<int>();
            foreach(Dobbelsteen d in dobbelstenen)
            {
                worpen.Add(d.Rollen());
            }
            return worpen;
        }
    }
}
