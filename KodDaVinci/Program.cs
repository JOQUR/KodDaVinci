using System;

namespace KodDaVinci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start();
            game();
        }
        public static void Start()
        {
            Postac doktor = new Postac("Robert", "Langdon", 40, "Wykładowca na MIT", "Elektronika");
            Console.WriteLine("Witaj w grze 'Kod Da Vinci'!");
            Console.WriteLine("Nazywasz się {0} {1}, masz {2} lat. Pracujesz jako {3}. W wolnej chwili twoja pasja to {4}", doktor.name, doktor.surname, doktor.age, doktor.profession, doktor.hobby);
            Console.WriteLine("============================================================================================");
        }
        public static void game()
        {
            Scena_pokoj scena_Pokoj = new Scena_pokoj();
            Scena_wyklad scena_Wyklad = new Scena_wyklad();
            Scena_zabojstwo scena_Zabojstwo = new Scena_zabojstwo();
            Scena_historycznemiejsce scena_Historycznemiejsce = new Scena_historycznemiejsce();
            scena_Pokoj.szukanie_laptopa();
            scena_Wyklad.Wyklad();
            scena_Zabojstwo.zabojstwo();
            scena_Historycznemiejsce.wlamanie();
        }
    }
}
