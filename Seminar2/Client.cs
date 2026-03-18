using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Client
    {
        string Nume;
        string Prenume;
        string Email;
        public string email
        {
            get { return Email; }
            set
            {
                if(value.Contains("@") && value.Contains("."))
                {
                    Email = value;
                }
                else
                {
                    Console.WriteLine("Eroare, email-ul nu contine '@' sau '.'");
                }

            }
        }

        string Telefon;
        public string telefon
        {
            get { return Telefon; }
            set
            {
                if(value.Length == 10)
                {
                    Telefon = value; 
                }
                else
                {
                    Console.WriteLine("Telefonul are mai mult sau mai putin de 10 caractere");
                }
            }
        }
        public Client(string nume, string prenume, string email, string telefon)
        {
            Nume = nume;
            Prenume = prenume;
            this.email = email;
            this.telefon = telefon;
            
        }
    }
}
