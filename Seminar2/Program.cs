using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client("Ion", "Popescu", "ion@gmail.com", "0721000001");
            Client c1 = new Client("Andrei", "Popescu", "ion@gmail.com", "1234567890");
            CasaBilete casa = new CasaBilete();
            Bilet bNormal = new Bilet("Avatar 2", 1, TipFilm.Istoric, DateTime.Now.AddDays(1), c, 12, 50);
            casa.AdaugaBilet(bNormal);
            BiletStudent bStudent = new BiletStudent("Avatar 2", 1, TipFilm.Comedie, DateTime.Now.AddDays(1), c1, 13, 50, 12345, "ASE");
            casa.AdaugaBilet(bStudent);
            try
            {
                BiletSenior bSenior = new BiletSenior("Avatar 2", 1, TipFilm.Acitune, DateTime.Now.AddDays(1), c, 14, 50, 65);
                casa.AdaugaBilet(bSenior);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n--- STATISTICI CINEMA ---");
            Console.WriteLine($"Total încasări: {casa.PreturiFinale()} lei");
            Console.WriteLine($"Total reduceri oferite clienților: {casa.GetReduceriAcordate()} lei");
            Console.WriteLine($"Număr studenți în sală: {casa.GetNumarBietePerTip<BiletStudent>()}");
            Console.WriteLine($"Număr seniori în sală: {casa.GetNumarBietePerTip<BiletSenior>()}");
            Console.WriteLine("\nApăsați orice tastă pentru a închide...");
            Console.ReadKey();
        }
    }
    }

