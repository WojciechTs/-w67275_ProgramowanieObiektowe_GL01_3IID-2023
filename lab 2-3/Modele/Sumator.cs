using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Modele
{
    public class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] liczba)
        {
            Liczby = liczba;
        }


        public int Suma()
        {
            int suma = 0;
            for (int i = 0; i < Liczby.Length; i++)
            {
                suma += Liczby[i];
            }
            return suma;
        }
        public int SumaPodziel3()
        {
            int suma = Suma();
            return suma / 3;
        }

        public int IleElementów()
        {
            return Liczby.Length;
        }

        public int[] Print()
        {
            return Liczby;
        }

        public int[] Zakres(int lowIndex, int highIndex)
        {
            int[] list_liczb = { };
            if (lowIndex < 0)
            {
                lowIndex = 0;
            }
            if (highIndex > Liczby.Length - 1)
            {
                highIndex = Liczby.Length - 1;
            }

            for (int i = lowIndex; i < highIndex; i++)
            {
                list_liczb = new int[Liczby[i]];
            }
            return list_liczb;
        }

    }

}
