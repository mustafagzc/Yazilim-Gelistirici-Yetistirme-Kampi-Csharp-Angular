using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary sınıfı değişken boyutlu bir sınıftır. 2 adet kavramı mevcuttur. Anahtar (key) - Değer (value)

            Dictionary<int, string> eleman = new Dictionary<int, string>();

            eleman.Add(12,"MUSTAFA");
            eleman.Add(13, "SALİH");
            eleman.Add(14, "BAHADIR");

            foreach (var elm in eleman)
            {
                Console.WriteLine(elm);
            }

            Console.ReadLine();

            
        }
    }
}
