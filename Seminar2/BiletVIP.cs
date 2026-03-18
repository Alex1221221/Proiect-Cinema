using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class BiletVIP : Bilet
    {
        public BiletVIP(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza) : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)
        {
        }
        bool IncludePopcorn()
        {
            return true;
        }
        bool IncludeBauture()
        {
            return true;

        }
        public double GetExtras()
        {
            int popcorn = 15;
            int bautura = 10;
            return (popcorn + bautura);
        }
        public override double CalculeazaPretFinal()
        {
            return pretBaza*GetExtras();
        }
    }
}
