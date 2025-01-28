using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzlucnoNatjecanje
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

/*
 dostave - 
    omogućuje uredjivanje metoda dostave koje se u bazi nalaze u tablici MetodaDostave
    drop down list ponudi sve metode dostave iz baze, odabirom jedne metode, 
    prikazati naziv i cijenu metode te omogućiti da ih promijeni
    Potrebno je osigurati da naziv ima minimalno 3 znaka, a cijena samo pozitivan broj

    Ne treba dodavati nove ili brisati postojeće, moguć povratak na glavni ekran. 
 */