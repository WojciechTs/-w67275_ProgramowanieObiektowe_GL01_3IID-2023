using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4.Zad2
{
    public class Nauczyciel : Uczen
    {
        public string Title { get; set; }
        public List<Uczen> Uczens { get; set; } = new List<Uczen>();

        public override string GetFullName()
        {
            return $"{Title} {base.GetFullName()}";
        }

        public void WhichUczenCanGoHomeAlone()
        {
            foreach (var Uczen in Uczens.Where(x => x.CanGoAloneToHome()))
            {
                Console.WriteLine(Uczen.GetFullName());
            }
        }

        public void DisplayClass(DateTime date)
        {
            Console.WriteLine($"{GetEducationInfo()} Day {date.DayOfWeek}");
            Console.WriteLine($"Nauczyciel {GetFullName()}");
            Console.WriteLine(GetEducationInfo());
            var i = 0;
            foreach (var Uczen in Uczens)
            {
                i++;
                Console.WriteLine($"{i}. {Uczen.GetFullName()} {Uczen.GetGender()} {Uczen.CanGoAloneToHome()} {Uczen.Info()}");
            }
        }

    }
}
