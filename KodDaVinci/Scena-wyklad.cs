using System;
using System.Linq;
using System.Threading;

namespace KodDaVinci
{
    class Scena_wyklad
    {
        private string[] ciag = new string[8] { "w", "i", "e", "i", "t", "a", "g", "h" };
        private string[] answer = new string[8] { null, null, null, null, null, null, null, null };
        public void Wyklad()
        {
            Console.WriteLine("Witajcie na wykładzie, Opowiem wam o działaniu superkomputerów");
            Console.WriteLine("Wciskaj ENTER aby podtrzymać monolog");
            int x = 0;
            string input;
            while (x < 20)
            {
                input = Console.ReadLine();
                x++;
            }
            Console.WriteLine("Koniec wykładu");
            Thread.Sleep(3000);
            Console.WriteLine("Podchodzi Student, chyba ma jakas zagadke do rozwiklania :)");
            Console.WriteLine("Mam ciag liczb 24, 9, 5, 20, 1,7,8, jak to rozszyfrowac, dostałem od studenta AGH z polski? prawdopodobnie podstawienie, A-1, B-2, C-3 itd. ");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Podaj {0} znak", i + 1);
                answer[i] = Console.ReadLine();
            }
            bool equal = ciag.SequenceEqual(answer);
            if (equal == false)
            {
                Console.WriteLine("To nie tak! (GAME OVER!)");
                Thread.Sleep(1000);
                Environment.Exit(1);
            }
            Console.WriteLine("Okej, skoro zagadka rozwiazana to ide do Jacquesa, musze z nim pogadac");
            Console.WriteLine("*BRRRRRRRRRRRRRRRRRRRRRR* Halo? Polijant: Przyjedz do Luwru, Jacques został zamordowany.");
            Console.WriteLine("Musze kupic bilet i jechac zobaczyc co sie stalo!");

        }
    }
}
