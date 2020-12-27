using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    class Menu
    {
        public Menu()
        {
            bool a = true;
            while (a)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Выберите функцию:" +
                "\n1. - 5 * x\u00B2" +
                "\n2 - 2 * Sin(x)" +
                "\n3 - x\u00B2 * Tg(x)" +
                "\n4 - для выхода из програмы.");
                Plot diapozon;
                Console.ResetColor();
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        diapozon = new Plot();
                        diapozon.lenght();
                        diapozon.Enter(diapozon.f);
                        diapozon.MinZnach();
                        break;

                    case 2:
                        diapozon = new Plot();
                        diapozon.lenght();
                        diapozon.Enter(diapozon.g);
                        diapozon.MinZnach();
                        break;

                    case 3:
                        diapozon = new Plot();
                        diapozon.lenght();
                        diapozon.Enter(diapozon.y);
                        diapozon.MinZnach();
                        break;

                    case 4:
                        a = false;
                        break;
                }

            }

        }
    }
}
