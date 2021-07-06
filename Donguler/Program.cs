using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilimci";
            string kurs2 = "Yazilimci1";

            string kurs3 = "Yazilimci2";

            string kurs4 = "Yazilimci3";
            string kurs5 = "Yazilimci4";

            string[] kurslar = new string[] { "Yazilimci",
                "Yazilimci1",
                "Yazilimci11",
                "Yazilimci111" };



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("son");
        }
    }
}
