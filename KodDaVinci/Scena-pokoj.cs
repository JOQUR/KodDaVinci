using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodDaVinci
{
    class Scena_pokoj
    {
        private string kod_2 = "110110";
        public void szukanie_laptopa()
        {
            Console.WriteLine("Ahhh... zaspałem, muszę się spieszyć, żeby zdążyć na wykład.");
            Console.WriteLine("Zaraz... Gdzie mój laptop? Muszę sprawdzić sejf oraz szafke, mogłem zapomnieć go schować(1 to szafka, 0 to sejf)");
            string decyzja = Console.ReadLine();
            if(decyzja == "0")
            {
                Console.WriteLine("Sprawdzę w sejfie! Tylko jaki był kod? Ahhh... muszę zamienic ten ciąg binarny na dziesiętny");
                Console.WriteLine(kod_2);
                string kod_10 = Convert.ToInt32(kod_2, 2).ToString();
                string code_input = Console.ReadLine();
                if(kod_10 == code_input)
                {
                    Console.WriteLine("Udało sie!");
                }
            }
        }
    }
}
