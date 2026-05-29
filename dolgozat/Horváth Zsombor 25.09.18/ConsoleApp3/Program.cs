using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Helló Világ!";
            Console.WriteLine("mi a neved?");
            string nev = Console.ReadLine();
            Console.WriteLine($"változók kiírása: 1.feladat: {hello} 2.feladat: {nev}");

            int a = 617;
            Console.WriteLine("adj meg egy számot");
            int b = int.Parse(Console.ReadLine());
            if (b > -1)
            {
                Console.WriteLine($"A {a} szám kétszerese:		{a*2}");
            }else
            {
                Console.WriteLine($"Kedves {nev} ! Az ön által megadott szám: {b}, amely negatív!");
            }
            Console.WriteLine("adj meg egy betűt");
            char x = char.Parse(Console.ReadLine());
            if (x == 'a' || x == 'A')
            {
                Console.WriteLine("háromszög oldala oldal:");
                int oldal = int.Parse(Console.ReadLine());
                Console.WriteLine("oldalmagasság:");
                int oldalm = int.Parse(Console.ReadLine());
                Console.WriteLine($"a háromszög területe: {(oldal*oldalm)/2}");
            }else
            {
                bool ertekeles = true;
                Console.WriteLine((a>=0)&&(a<=100) !|(b>=100 || b==0) || ertekeles);
            }
        }
    }
}
