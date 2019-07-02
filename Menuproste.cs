using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojapierwszaapka
{
   static class Menu
   {
      public static void StartMenu()
      {
         Console.Title = "Witaj w moim kalkulatorze";

         while (true)
         {
            Console.Clear();
            Console.WriteLine("Wybierz opcję");
            Console.WriteLine("1 - Dodawanie");
            Console.WriteLine("2 - Odejmowanie");
            Console.WriteLine("3 - Mnożenie");
            Console.WriteLine("4 - Dzielenie");

            ConsoleKeyInfo klawisz = Console.ReadKey();
            switch (klawisz.Key)
            {
               case ConsoleKey.D1:
                  Console.Clear(); Dodawanie(); break;
               case ConsoleKey.D2:
                  Console.Clear(); Odejmowanie(); break;
               case ConsoleKey.D3:
                  Console.Clear(); Mnożenie(); break;
               case ConsoleKey.D4:
                  Console.Clear(); Dzielenie(); break;
               case ConsoleKey.Escape:
                  Environment.Exit(0); break;
               default: break;
            }
            

         }
      }
      static void Dodawanie()
      {

         Int32 Number1;
         Int32 Number2;
         Int32 Final;

         Console.WriteLine("Dodawanie");
         Console.Write("Wybierz pierwszą liczbę ");
         Number1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Wybierz drugą liczbę ");
         Number2 = Convert.ToInt32(Console.ReadLine());
         Final = Number1 + Number2;
         Console.Write("Rezultat to: " + Final);
         Console.ReadKey();
      }

      static void Odejmowanie()
      {
         Int32 Number1;
         Int32 Number2;
         Int32 Final;

         Console.WriteLine("Odejmowanie");
         Console.Write("Wybierz pierwszą liczbę ");
         Number1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Wybierz drugą liczbę ");
         Number2 = Convert.ToInt32(Console.ReadLine());
         Final = Number1 - Number2;
         Console.Write("Rezultat to: " + Final);
         Console.ReadKey();
      }

      static void Mnożenie()
      {
         Int32 Number1;
         Int32 Number2;
         Int32 Final;

         Console.WriteLine("Mnożenie");
         Console.Write("Wybierz pierwszą liczbę ");
         Number1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Wybierz drugą liczbę ");
         Number2 = Convert.ToInt32(Console.ReadLine());
         Final = Number1 * Number2;
         Console.Write("Rezultat to: " + Final);
         Console.ReadKey();
      }


      static void Dzielenie()
      {
         Int32 Number1;
         Int32 Number2;
         Int32 Final;

         Console.WriteLine("Dzielenie");
         Console.Write("Wybierz pierwszą liczbę ");
         Number1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Wybierz drugą liczbę ");
         Number2 = Convert.ToInt32(Console.ReadLine());
         Final = Number1 / Number2;
         Console.Write("Rezultat to: " + Final);
         Console.ReadKey();
      }
   }
}
