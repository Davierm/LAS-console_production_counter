using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Look and See == Konzole pro výpočet zbývajícího času produkce. ");
            Console.WriteLine("(C)2019 David Čermák aka DAVIERM");
            Console.WriteLine("");

            int next = 1;

            while (next == 1)
            {
                Console.WriteLine("Zadej plánované množství dílů: ");
                int part_plan = int.Parse(Console.ReadLine());

                Console.WriteLine("Zadej vyrobené množství dílů: ");
                int part_real = int.Parse(Console.ReadLine());

                int part_remain = part_plan - part_real;
                Console.WriteLine("Počet chybějících dílů do konce zakázky: " + part_remain);
                Console.WriteLine("");


                Console.WriteLine("Zadej skutečný čas cyklu v sekundách: ");
                float cycle_time = float.Parse(Console.ReadLine());

                Console.WriteLine("Zadej počet kavit nástroje: ");
                int cavit_number = int.Parse(Console.ReadLine());

                float a = (part_remain * cycle_time) / cavit_number;

                var totalSeconds = a;

                var ss = Convert.ToInt32(totalSeconds % 60).ToString("00");

                var mm = (Math.Floor(totalSeconds / 60) % 60).ToString("00");

                var hh = Math.Floor(totalSeconds / 60 / 60).ToString("00");

                Console.WriteLine("Do dokončení produkce zbývá: " + hh + ":" + mm + ":" + ss);
                Console.WriteLine("");
                Console.WriteLine("Přeješ si zadat další? [Ano(1)/Ne(0)]");
                next = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
            
        }
    }
}
