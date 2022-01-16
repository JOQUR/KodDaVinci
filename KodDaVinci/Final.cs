using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace KodDaVinci
{
    class Final
    {
        private string haslo = "TOURING";
        private string[] odp = new string[7];
        private string godzina = "godzina 18.00";
        private string x;
        public void cambridge()
        {
            Console.WriteLine("Sprawdźmy pokój Hawkinga, tam może coś być, w sejfie szczególnie, tylko jakie hasło?");
            Console.WriteLine("Sophie: TOURING! Tak pisało na poprzedniej karteczce chyba!");
            Console.WriteLine("TOURING chyba nie działa, a jakbyśmy odwrócili to słowo, zapiszemy od prawej do lewej!");
            for(int i = 0; i < haslo.Length; i++)
            {
                Console.WriteLine("Podaj kolejne znaki hasla!");
                string znaki = Console.ReadLine();
                odp[i] = znaki;
            }
            Array.Reverse(odp);
            x = String.Join("", odp);
            if(x != haslo)
            {
                Console.WriteLine("Sejf Zablokowany!(GAME OVER!)");
                Thread.Sleep(1000);
                Environment.Exit(1);
            }
            Console.WriteLine("Jest coś tutaj, Londyn Restauracja GRAAL, godzina 18.00");
            Console.WriteLine("Chyba musimy się tam udać!");

            Console.WriteLine("!!!W RESTAURACJI!!!");
            Console.WriteLine("Kelner: Na która byli państwo umówieni?");
            Console.WriteLine("Podaj godzinę w formacie <godzina xx.xx>");
            string kelner = Console.ReadLine();
            if(kelner != godzina)
            {
                Console.WriteLine("Niestety ale nie!(GAME OVER!)");
                Thread.Sleep(1000);
                Environment.Exit(1);
            }
            Console.WriteLine("Sophie: Niespodzianka!!!!!");
            Console.WriteLine("<Jacques wychodzi> Niespodzianka!!!!");
            Console.WriteLine("Sophie: Cała ta sytuacja była pretekstem! :) Masz urodziny, ta przygoda miała być prezentem :)");
        }
    }
}
