using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            string taj = "";
            Console.WriteLine("mi a taj számod? (9 számjegy): ");
            taj = Console.ReadLine();
            char elsz = taj[8];
            int ellen = new int();
            ellen = elsz - '0';
            Console.WriteLine($"az ellenörző számjegy: {elsz}");
            string ind = "";
            int[] tajszam = new int[8];
            int ossz = new int();
            for (int i = 0; i < 8; i++)
            {
                ind = Convert.ToString(taj[i]);
                tajszam[i] = int.Parse(ind);
            }
            for (int i = 0; i < 8; i++)
            {
                if (i%2==0)
                {
                    ossz = ossz + (tajszam[i] * 3);
                }
                else
                {
                    ossz = ossz + (tajszam[i] * 7);
                }
            }
            Console.WriteLine($"a sorozat összege: {ossz}");
            if (ossz%10==ellen)
            {
                Console.WriteLine("helyes tajszám");
            }
            else
            {
                Console.WriteLine("nem helyes tajszám");
            }
        }
    }
}
