using System;
using System.Linq;
using System.Collections.Generic;


namespace ConsoleApp30
{
    class Program
    {
        static string fordit(string szoveg)
        {
            string bucket = "";
            for (int i = szoveg.Length-1; i > -1; i--)
            {
                bucket = bucket + szoveg[i];
            }
            return bucket;
        }
        static int maxSrc(int[] arr)
        {
            int big = new int();
            foreach (int n in arr)
            {
                if (n > big) { big = n; }
            }
            return big;
        }
        static int pow2(int n)
        {
            return n * n;
        }
        static void vissza()
        {
            Console.WriteLine("szöveg");
            string szoveg = Console.ReadLine();
            string bucket = "";
            for (int i = szoveg.Length - 1; i > -1; i--)
            {
                bucket = bucket + szoveg[i];
            }
            Console.WriteLine(bucket);
        }
        static void nevszov()
        {
            Console.WriteLine("mi a neved");
            string nev = Console.ReadLine();
            Console.WriteLine("írj egy mondatot");
            string szoveg = Console.ReadLine();
            Console.WriteLine(nev+" "+szoveg);
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("szöveg: ");
            string word = Console.ReadLine();
            Console.WriteLine("a szöveg hossza " + word.Length + " karakter");
            Console.WriteLine(word.ToUpper());
            int AC = new int();
            foreach (char betu in word)
            {
                if (betu == 'a' || betu == 'A')
                {
                    AC += 1;
                }
            }
            if (AC > 0)
            {
                Console.WriteLine(AC + " darab \"a\" betű van a szövegben");
            }
            else { Console.WriteLine("nincs \"a\" betű a szövegben"); }
            int WC = 1;
            foreach (var betu in word)
            {
                if (betu == ' ')
                {
                    WC += 1;
                }
            }
            Console.WriteLine("a szavak száma: " + WC);
            Console.WriteLine(fordit(word));
            int[] testArr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                testArr[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("a lista maximuma: " + maxSrc(testArr));
            Console.WriteLine("szám");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(pow2(num));
            vissza();
            nevszov();
        }
    }
}
