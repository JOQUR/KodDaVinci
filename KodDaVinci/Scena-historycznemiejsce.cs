using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace KodDaVinci
{
    class Scena_historycznemiejsce
    {
        private string haslo = "--..-..-.-.-..";
        public void wlamanie()
        {
            Console.WriteLine("Dotarliśmy, musimy w jakiś sposob ominąc sposób zabezpieczen, żeby alarmu nie włączyć");
            Console.WriteLine("Jakie może być hasło? A może graal, widzę że to w alfabecie morse'a, nie powinno byc skomplikowane, zresztą mam 3 próby!(Bez spacji)");
            string input;
            for(int i = 0; i < 3; i++)
            {
                input = Console.ReadLine();
                if(input == haslo)
                {
                    Console.WriteLine("Tak! Udało się");
                    break;
                }
                if(i == 2)
                {
                    Console.WriteLine("ALARM! (GAME OVER!)");
                    Thread.Sleep(1000);
                    Environment.Exit(1);
                }
            }
            Console.WriteLine("Sophie coś znalazłem, to chyba może sie przydać, mowa tutaj o wieży Eiffla oraz jakimś miejscu w Anglii. Dasz rady udać się do Anglii? Ja zobacze co tam w Paryżu");
            Console.WriteLine("Sophie: Okej!");
        }
    }
}
