using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace KodDaVinci
{
    class Scena_wiezaeiffla
    {
        private List<String> haslo = new List<String>() { "pod", "drzewem", "czy", "takim", "Newton?", "siedział"};
        private List<String> odpowiedz = new List<String>();
        private int prawda = 203154;
        public void paryz()
        {
            Console.WriteLine("!!PODRÓŻ DO PARYŻA!!!");
            Console.WriteLine("Okej według tej wskazówki muszę porozmawiać z przewodnikiem po wieży na temat obrazu, Newtona?");
            Console.WriteLine("!!!ROZMOWA Z PRZEWODNIKIEM!!!");
            Console.WriteLine("Przewodnik: Tutaj widzimy drzewo, jabłoń");
            Console.WriteLine("Przepraszam, mam pytanie");
            for(int i = 0; i < haslo.Count; i++)
            {
                Console.Write(haslo[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Złoż zdanie w sensowną treść! Podaj ciąg cyfr, aby odpowiadały od pierwszego do ostatniego słowa!");
            string answer = Console.ReadLine();
            int answer_ = Convert.ToInt32(answer);
            if(prawda != answer_)
            {
                Console.WriteLine("Niestety ale nie!(GAME OVER!)");
                Thread.Sleep(1000);
                Environment.Exit(1);
            }
            Console.WriteLine("Przewodnik: Tak, niech pan uda się do pewnoego miejsca w Anglii i zbada tę sprawę!");
            Console.WriteLine("!!!PODRÓŻ DO ANGLII!!!");

        }
    }
}
