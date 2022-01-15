using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace KodDaVinci
{
    class Scena_cambrige
    {
        private string[] ciag = new string[9] { "c", "a", "m", "b", "r", "i", "d", "g", "e" };
        private string[] answer = new string[9] { null, null, null, null, null, null, null, null, null };

        public void Cambridge()
        {
            Console.WriteLine("No dobrze, Sophie co mamy na kartcę. \n Kolejna zagadka, z która mamy się uporać.");
            Console.WriteLine("'Jest to miejsce w Anglii, bardzo znane, gdzie mało znany matematyk wraz z Hardym pracował nad nowymi teoriami. Tym miejscem jest 3, 1, 13, 2, 18, 9, 4, 7, 5' \nMałą podpowiedzią może być 'Człowiek, który poznał nieskończoność'. ");
            Console.WriteLine("Mamy mało czasu Sophie, znam ten szyfr. Na wykładzie, który prowadziłem we Francji podszedł do mnie student z takim samym problemem.");
            for (int i = 0; i < 9 ; i++)
            {
                Console.WriteLine("Podaj {0} znak", i + 1);
                answer[i] = Console.ReadLine();
            }
            bool equal = ciag.SequenceEqual(answer);
            if (equal == false)
            {
                Console.WriteLine("Teraz to na pewno nie zdążymy. (GAME OVER!) ");
                Thread.Sleep(1000);
                Environment.Exit(1);
            }
            Console.WriteLine("Jestem wielkim fanem Pana Ramanujana\n Musimy się spieszyć...");
            Console.WriteLine("Tam musi czekać na nas rozwiązanie.");
        }
    }
}
