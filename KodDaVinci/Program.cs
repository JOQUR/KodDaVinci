using System;

namespace KodDaVinci
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            firstScene();
        }
        public static void Start()
        {
            Postac doktor = new Postac("Robert", "Langdon", 40, "Wykładowca na MIT", "Elektronika");
            Console.WriteLine("Witaj w grze 'Kod Da Vinci'!");
            Console.WriteLine("Nazywasz się {0} {1}, masz {2} lat. Pracujesz jako {3}. W wolnej chwili twoja pasja to {4}", doktor.name, doktor.surname, doktor.age, doktor.profession, doktor.hobby);
        }
        public static void firstScene()
        {
            Scena_pokoj scena_Pokoj = new Scena_pokoj();
            scena_Pokoj.szukanie_laptopa();
        }
    }
}
