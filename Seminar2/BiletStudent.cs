using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class BiletStudent : Bilet
    {
        int NumarLegitimatie;
        string Facultate;

        public BiletStudent(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza, int numarLegitimatie, string facultate) :
            base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)
        {
            NumarLegitimatie = numarLegitimatie;
            Facultate = facultate;
        }
        public override double GetReducere()
        {
            return pretBaza * 0.2;
        }
        public override bool EsteValid()
        {


            return base.EsteValid() && NumarLegitimatie > 0 && Facultate.Length != 0;
        }
    }
}
