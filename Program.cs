using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz zadanie numer zadania od 1 do 6:");
            var input = Console.ReadLine();
            switch (int.Parse(input))
            {
                case 1:
                    Zad1();
                    break;
                case 2:
                    Zad2();
                    break;
                case 3:
                    Zad3();
                    break;
                case 4:
                    Zad4();
                    break;
                case 5:
                    Zad5();
                    break;
                case 6:
                    Zad6();
                    break;
                default:
                    Console.WriteLine("...");
                    break;

                

                
                    

            }
                


        }

        static void Zad1()
        {
            Console.WriteLine("Zadanie 1");
            Console.Write("Podaj liczbę do sprawdzenia czy jest parzysta czy nieparzysta:  ");
            var input = Console.ReadLine();
            int liczba = int.Parse(input);
            string czyParzysta = "";

            if (liczba%2 == 0)
            {

                czyParzysta = "parzysta";
            }
            else
            {
                czyParzysta = "nieparzysta";
            }
            Console.WriteLine($"Podana liczba {liczba} jest {czyParzysta}");

            

        }

        static void Zad2()
        {
            Console.WriteLine("Zadanie 2");
            Console.WriteLine("Podaj N, aby wypisać na konsoli wszystkie parzyste liczby od 1 do N");
            var input = Console.ReadLine();
            int liczba = int.Parse(input);

            for (int i = 1; i <= liczba; i++)
            {
                if ( i % 2 == 0)
                {
                    Console.Write(i+" ");
                }
            }

        }

        static void Zad3()
        {
            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Menu");
            Console.WriteLine("Wybierz jedną z podanych funkcji poprzez podanie odpowiedniej liczby");
            Console.WriteLine("Pozycja 1: Sprawdź czy liczba jest parzysta");
            Console.WriteLine("Pozycja 2: Wypisz liczby parzyste od 1 do N");
            Console.WriteLine("Pozycja 3: Oblicz silnię");
            Console.WriteLine("Pozycja 4: Zgadywanie liczby");
            Console.WriteLine("Pozycja 5: Konwersja temperatury");
            var input = Console.ReadLine();
            switch (int.Parse(input))
            {
                case 1:
                    Zad1();
                    break;
                case 2:
                    Zad2();
                    break;
                case 3:
                    Zad4();
                    break;
                case 4:
                    Zad5();
                    break;
                case 5:
                    Zad6();
                    break;

            }
        }

        static void Zad4()
        {
            Console.WriteLine("Zadanie 4");
            Console.WriteLine("Podaj liczbę, aby obliczyć silnię");
            var input = Console.ReadLine();
            int liczba = int.Parse(input);
            int silnia = 1;

            for (int i = 1; i <= liczba; i++)
            {
                silnia *= i;
            }
            Console.WriteLine("Silnia wynosi: "+silnia);
        }

        static void Zad5()
        {
            Random rand = new Random();
            var x = rand.Next(10);
            Console.WriteLine("Zadanie 5");
            Console.WriteLine("Spróbuj odgadnąć liczbę w najmniejszej ilości prób (od 0 do 10)");
            int liczba;
            int proby = 0;

            do
            {
                var input = Console.ReadLine();
                liczba = int.Parse(input);
                proby++;
            }
            while (x != liczba);
            Console.WriteLine("Brawo zgadłeś za "+proby+" razem!");
        }

        static void Zad6()
        {
            Console.WriteLine("Zadanie 6");
            Console.WriteLine("Wybierz opcję poprzez podanie odpowiedniej liczby");
            Console.WriteLine("1 - stopnie Celsjusza na stopnie Fahrenheita");
            Console.WriteLine("2 - stopnie Celsjusza na Kelviny");
            Console.WriteLine("3 - Kelviny na stopnie Celsjusza");
            Console.WriteLine("4 - Kelviny na stopnie Fahrenheita");
            Console.WriteLine("5 - stopnie Fahrenheita na stopnie Celsjusza");
            Console.WriteLine("6 - stopnie Fahrenheita na stopnie Kelviny");
            var input = Console.ReadLine();
            Console.Write("Wartość: ");
            var input2 = Console.ReadLine();
            float liczba = float.Parse(input2);
            float zmienna;
            switch (int.Parse(input))
            {
                case 1:
                    zmienna = (1.8f * liczba) + 32;
                    Console.WriteLine(liczba+" stopni Celsjusza to "+zmienna+ " stopni Fahrenheita");
                    break;
                case 2:
                    zmienna = liczba + 273.15f;
                    Console.WriteLine(liczba + " stopni Celsjusza to " + zmienna + " Kelvinów");
                    break;
                case 3:
                    zmienna = liczba - 273.15f;
                    Console.WriteLine(liczba + " Kelvinów to " + zmienna + " stopni Celsjusza");
                    break;
                case 4:
                    zmienna = (1.8f * liczba) - 459.67f;
                    Console.WriteLine(liczba + " Kelvinów to " + zmienna + " stopni Fahrenheita");
                    break;
                case 5:
                    zmienna = ( liczba-32)/ 1.8f ;
                    Console.WriteLine(liczba + " stopni Fahrenheita to " + zmienna + " stopni Celsjusza");
                    break;
                case 6:
                    zmienna = (liczba + 459.67f) / 1.8f;
                    Console.WriteLine(liczba + " stopni Fahrenheita to " + zmienna + " Kelvinów");
                    break;
            }
                

        }
     }


}