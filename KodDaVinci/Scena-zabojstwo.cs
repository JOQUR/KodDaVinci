using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace KodDaVinci
{
    class Scena_zabojstwo
    {
        public static int fib(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return fib(n - 1) + fib(n - 2);
        }
        private List<int> fibo = new List<int>() { fib(1), fib(2), fib(3), fib(4) };
        private List<int> answer = new List<int>();
        private List<String> wybor = new List<string>() { "Pentagram", "Hexagon", "Oktagon" };
        private int input_;
        private string fibo_input;
        private string passw = Convert.ToString(6, 2);
        private string pass_input;

        public void zabojstwo()
        {
            Console.WriteLine("Jego cialo jest ulozone w dziwnej figurze... Jaka to jest?{0}, {1} czy {2}", wybor[0], wybor[1], wybor[2]);
            Console.WriteLine("Podaj odpowiedni index(0, 1, 2)");
            string input = Console.ReadLine();
            try
            {
                input_ = Int16.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (input_ != 0)
                {
                    Console.WriteLine("Bład! (GAME OVER!)");
                    Thread.Sleep(1000);
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Tak to {0}! Zabojstwo na tle religijnym?", wybor[input_]);
                }
            }
            Console.WriteLine("Dostałem smsa od Sophie, zaszyfrowane? O jest wskazowka, liczba szatana? Chodzi o 6, zapisane na 3 miejscach? Achh.... w systemie binarnym!");
            for (int i = 0; i < 4; i++)
            {
                pass_input = Console.ReadLine();
                if (pass_input == passw)
                {
                    Console.WriteLine("Tak, udało mi sie!");
                    break;
                }
                if (i == 3)
                {
                    Console.WriteLine("Nie umiesz binarnego? ;) (GAME OVER!)");
                    Thread.Sleep(1000);
                    Environment.Exit(1);
                }
            }
            Console.WriteLine("Muszę spotkac sie z Sophie!");
            Console.WriteLine("Hej Sophie!, co teraz robimy? \nSophie: Musimy sprawdzić komputer Jacquesa, tam moga być dane! \nRobert: Ok, jaki był pin? \nSophie: Sprawdz 4 pierwsze wyrazy ciagu fibonacciego");
            for (int i = 0; i < fibo.Count; i++)
            {
                fibo_input = Console.ReadLine();
                answer.Add(Convert.ToInt32(fibo_input));
            }
            bool areEqual = Enumerable.SequenceEqual(answer, fibo);
            if (areEqual == false)
            {
                
            }
            Console.WriteLine("Udało się! Jedzmy teraz do miejsca o którym miał Jacques notatki, tam musi być coś ciekawego w związku z św graalem!");
        }

    }
}
