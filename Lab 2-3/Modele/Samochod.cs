using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Modele
{
    public class Samochód
    {
        enum stan { URUCHOMIONY, ZATRZYMANY, checkEngine
        };
        public string marka;
        public string model;
        public int rokProdukcji;
        private int predkosc;
        private int przebieg;
        private stan stanSilinka;


        public Samochód(string marka, string model, int rok)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rok;
            this.predkosc = 0;
            this.przebieg = 0;
            this.stanSilinka = stan.ZATRZYMANY;

        }

        public void ustawPredkosc(int predkosc)
        {
            if (this.stanSilinka != stan.ZATRZYMANY && this.stanSilinka != stan.checkEngine)
            { this.predkosc = predkosc; }

        }

        public void przyspiesz()
        {
            if (this.stanSilinka != stan.ZATRZYMANY && this.stanSilinka != stan.checkEngine)
            { this.predkosc += 5; }

        }
        public void zwolnij()
        {
            if (this.stanSilinka != stan.ZATRZYMANY && this.stanSilinka != stan.checkEngine)
            { this.predkosc -= 5; }

        }

        public void uruchomSilnik()
        {
            if (this.przebieg > 10000 && this.przebieg % 10000 >= 1)
            {
                this.stanSilinka = stan.checkEngine;
                Console.WriteLine("Error");
            }
            else
            {
                this.stanSilinka = stan.URUCHOMIONY;
            }
            
        }

        public void zatrzymajSilnik()
        {
            this.stanSilinka = stan.ZATRZYMANY;
        }

        public void naprawSilnik()
        {
            this.stanSilinka = stan.ZATRZYMANY;
        }

        public int dystans(int trasa)
        {
            if (this.przebieg > 10000 && this.przebieg % 10000 >= 1)
            {
                this.stanSilinka = stan.checkEngine;
                Console.WriteLine("Error");
                return 0;
            }
            else
            {
                return trasa / this.predkosc;
            }
            
        }

        public int sprawdzPredkosc()
        {
            return this.predkosc;
        }

       
    }
}
