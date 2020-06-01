using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int ile = 10;
            stopwatch.Start();
            Console.WriteLine(BudujStringa(ile));
            stopwatch.Stop();
            Console.WriteLine("Dodawanie za pomoca konkatenacji zajmuje: "+stopwatch.ElapsedTicks+" tikow procesora");
            stopwatch.Restart();
            Console.WriteLine(BudujStringBuilder(ile));
            stopwatch.Stop();
            Console.WriteLine("Dodawanie za pomoca StringBuildera zajmuje: "+stopwatch.ElapsedTicks+ " tikow procesora");

            Console.ReadKey();
        }
        /// <summary>
        /// Metoda buduje stringa
        /// </summary>
        /// <param name="ile">Podaj dlugosc petli</param>
        /// <returns>Zwracamy gotowy tekst</returns>
        public static string BudujStringa(int ile)
        {
            string tekst = "";
            for (int i = 0; i < ile; i++)
            {
                tekst += i;
            }
            return tekst;
        }

        public static string BudujStringBuilder(int ile)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ile; i++)
            {
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();
            
        }
    }
}
