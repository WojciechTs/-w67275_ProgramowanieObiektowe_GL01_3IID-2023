using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Modele
{
    public class Licz
    {
        private int wartosc;

        public Licz(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public void Dodaj(int liczba)
        {
            wartosc += liczba;
        }
        public void Odejmij(int liczba)
        {
            wartosc -= liczba;
        }
        public int Pokaz()
        { return wartosc; }

    }
}
