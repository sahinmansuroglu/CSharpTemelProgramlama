using System;

namespace cEgitim
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesaj = "13 Ekim 1923'te TBMM'de ANKARA başkent olarak kabul edilmiştir";
            string kelime1 = "  Ankara   ";
            string kelime2 = "  BAŞKENT   ";

            kelime1 = kelime1.Trim();
            kelime1 = kelime1.ToUpper();
            kelime2 = kelime2.Trim();
            kelime2 = kelime2.ToLower();

            Console.WriteLine(mesaj.Contains(kelime1));
            Console.WriteLine(mesaj.Contains(kelime2));
        }
    }
}
