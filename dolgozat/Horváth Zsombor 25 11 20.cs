using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("szám");
            //int n = int.Parse(Console.ReadLine());
            int i = 1;
            //int fact = 1;
            //while (i < n+1)
            //{
            //    fact = fact * i;
            //    i++;
            //}
            //Console.WriteLine($"a számod faktoriálisa: {fact}");
            Random rnd = new Random();
            //Console.WriteLine("hány oldalú kockával szeretnél dobni?");
            //int sides = int.Parse(Console.ReadLine());
            //Console.WriteLine("hányszor szertnél dobni?");
            //int n = int.Parse(Console.ReadLine());
            //int dob = new int();
            //int ossz = new int();
            //i = 1;
            //Console.WriteLine("dobások:");
            //do
            //{
            //    dob = rnd.Next(1,sides+1);
            //    ossz += dob;
            //    Console.WriteLine(dob);
            //    i++;
            //} while (i < n + 1);
            //Console.WriteLine($"{ossz} lépést mehetsz előre");
            int[] tomb = new int[10];
            i = 0;
            int neg_tres = new int();
            while (true)
            {
                tomb[i] = rnd.Next(-25, 26);
                Console.Write($"{tomb[i]},");
                i++;
                if (i == 10)
                {
                    break;
                }
            }
            Console.WriteLine();
            i = 0;
            do
            {
                if (tomb[i] % -3 == 0)
                {
                    neg_tres += 1;
                }
                i++;
            } while (i < tomb.Length);
            Console.WriteLine($"{neg_tres} darab -3-mal osztható szám van");
            int min = new int();
            int max = new int();
            i = 0;
            while (i < tomb.Length)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
                i++;
            }
            Console.WriteLine($"a legkisebb érték: {min} \na legnagyobb érték: {max}");
        }
    }
}
