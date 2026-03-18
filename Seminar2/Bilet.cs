using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public enum TipFilm{
        Comedie,
        Acitune,
        Drama,
        Istoric
    }
    internal class Bilet
    {
        string NumeFilm;
        int NumarSala;
        TipFilm TipFilm;
        DateTime ExpiraLa;
        Client Client;
        int NumarLoc;
        public int numarLoc
        {
            get { return NumarLoc; }
            set
            {
                if(value >= 1 && value <= 200)
                {
                    NumarLoc = value;
                }
                else
                {
                    throw new ArgumentException("Numarul de locuri nu se afla in interval");
                }
            }
        }
        double PretBaza;
        public double pretBaza
        {
            get { return PretBaza; }
            set
            {
                if(value == 0 || value <= 0)
                {
                    throw new ArgumentException("Valoarea este nula sau negativa!");
                }
                else
                {
                    PretBaza = value;
                }
            }
        }
        public Bilet(string numeFilm,int numarSala,TipFilm tipFilm,DateTime expiraLa,Client client,int numarLoc,double pretBaza)
        {
            this.NumeFilm = numeFilm;
            this.NumarSala = numarSala;
            this.TipFilm = tipFilm;
            this.ExpiraLa = expiraLa;
            this.Client = client;
            this.numarLoc = numarLoc;
            this.pretBaza = pretBaza;
        }
        public virtual double GetReducere()
        {
            return 0;
        }
        public virtual  double CalculeazaPretFinal()
        {
            return pretBaza - GetReducere();
        }
        public virtual bool EsteValid()
        {
            if(ExpiraLa >= DateTime.Now && NumarLoc <= 200 && NumarLoc >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
