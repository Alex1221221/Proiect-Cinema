using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Seminar2
{
    internal class CasaBilete
    {
        private List<Bilet> bileteVandute;
        public CasaBilete()
        {
            bileteVandute = new List<Bilet>();
        }
        public void AdaugaBilet(Bilet b)
        {
            if(b!= null)
            {
                bileteVandute.Add(b);
                Console.WriteLine("Biletul a fost adaugat cu succes");
            }
        }
        public double PreturiFinale()
        {
            double total = 0;
            foreach(var b in bileteVandute)
            {
                total += b.CalculeazaPretFinal();
                
                
            }
            return total;
        }
        public double GetReduceriAcordate()
        {
            double total = 0;
            foreach(var b in bileteVandute)
            {
                total += b.GetReducere();
            }
            return total;
        }
        public int GetNumarBietePerTip<T>() where T : Bilet
        {
            return bileteVandute.OfType<T>().Count();
        }
        public double GetBiletulCelMaiScump()
        {
            return bileteVandute.Max(b => b.CalculeazaPretFinal());
        }
    }
}
