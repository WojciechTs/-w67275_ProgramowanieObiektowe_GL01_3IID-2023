using System;
using System.Collections.Generic;
using Lab4.Shapes;
using Lab4.Zad2;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad1();
            Zad2();
        }

        private static void Zad2()
        {
            var pesels = new List<long>()
            {
                13292313574,
                11272558326,
                11252623556,
                14222195514,
                13260515371,
                14281248851,
                13211445544,
                13290928392,
                14240472824,
                12310555824
            };

            var teacher = new Nauczyciel();

            teacher.SetFirstName("Nauczyciel");
            teacher.SetLastName("Nauczyciel");
            teacher.Title = "Dr";

            var Uczens = new List<Uczen>();

            var i = 0;
            foreach (var pesel in pesels)
            {
                var Uczen = new Uczen();
                Uczen.SetPesel(pesel.ToString());
                Uczen.SetFirstName("Uczen");
                Uczen.SetLastName(i.ToString());
                if (i == 4)
                    Uczen.SetCanGoHomeAlone(true);
                Uczens.Add(Uczen);
                i++;
            }

            teacher.Uczens.AddRange(Uczens);

            teacher.WhichUczenCanGoHomeAlone();

            teacher.DisplayClass(DateTime.Today);
        }

        static void Zad1()
        {
            var shapes = new List<Shape>();
            var shape1 = new Rectangle()
            {
                X = 5,
                Width = 2
            };

            shape1.Height = 3;

            shapes.Add(shape1);
            shapes.Add(new Rectangle()
            {
                X = 5,
                Width = 7
            });
            shapes.Add(new Rectangle()
            {
                X = 5,
                Width = 6
            });
            shapes.Add(new Rectangle()
            {
                X = 4,
                Width = 2
            });

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw();
            }


        }
    }
}
