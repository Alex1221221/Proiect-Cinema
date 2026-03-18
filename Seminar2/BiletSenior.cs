    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Seminar2
    {
        internal class BiletSenior : Bilet
        {
            int VarstaClient;
            public int varstaClient
            {
                get { return VarstaClient; }
                set
                {
                    if(value < 60 )
                    {
                        throw new ArgumentException("Nu ai peste 60 de ani");
                    }
                    else
                    {
                        VarstaClient = value;
                    }
                }
            }
            public BiletSenior(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza,int varsta) : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)
            {
                varstaClient = varsta;
            }
            public override double GetReducere()
            {
                return pretBaza * 0.3;
            }
        }
    }
