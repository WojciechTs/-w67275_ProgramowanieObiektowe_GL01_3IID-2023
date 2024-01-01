using Lab5.Zadanie2;
using Lab5.Shapes;
using System;

namespace Lab5
{
    class Program5
    {
        static void Main(string[] args)
        {
            Zad2();
        }

        private static void Zad2()
        {
            var account = new Account();

            account.Add(new IncomeTransaction() { Amount = 500 });
            account.Add(new IncomeTransaction() { Amount = 500 });
   
            account.Add(new ExpenseTransaction() { Amount = 410 });
            account.Add(new ExpenseTransaction() { Amount = 200 });

            account.DisplaySumary();
        }

        static void Zad1()
        {
            Shape shape = new Circle(3);

            shape = new Square() { X = 6 };

            Console.WriteLine(shape.CalulateArea());
        }
    }
}