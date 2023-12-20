using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Modele
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        public Samochód samochód;

        public Tuple<string, string> Zwroc()
        {
            return Tuple.Create(this.imie,this.nazwisko);
        }

        public Osoba(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;   
            this.wiek = wiek;
        }

        public bool czyPelnoletnia()
        {
            if (this.wiek >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void zmienNazwisko(string nazwisko)
        {
            this.nazwisko=nazwisko;
        }
        public void ustawSamochod(Samochód samochód)
        {
            this.samochód = samochód;
        }

        public Samochód infoSamochod()
        {
            return this.samochód;
        }


    }
}
