using System;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //1.--------------------------------------

            //Console.WriteLine("szám");
            //int a = int.Parse(Console.ReadLine());
            //int b = new int();
            //Console.Write("a szám osztói: ");
            //for (int i = 1; i < a+1; i++)
            //{
            //    if(a%i==0){
            //        Console.Write(i+",");
            //        b += 1;
            //    }
            //}
            //Console.WriteLine("");
            //Console.WriteLine($"{b} darab oszólya van");
            //if (b == 2)
            //{
            //    Console.WriteLine(a+" egy prím szám");
            //}else
            //{
            //    Console.WriteLine(a+" nem prím szám");
            //}

            //2.--------------------------------------------

            //int[] lista = new int[20];
            //for (int i = 0; i < lista.Length; i++)
            //{
            //    lista[i] = (random.Next(-20,25));
            //    Console.Write(lista[i]+" ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < lista.Length; i++)
            //{
            //    Console.WriteLine(lista[i] + " ");
            //}
            //Console.WriteLine("negatív számok: ");
            //for (int i = 0; i < lista.Length; i++)
            //{
            //    if (lista[i] < 0) {
            //        Console.Write(lista[i] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("pozitív páros számok: ");
            //for (int i = 0; i < lista.Length; i++)
            //{
            //    if (lista[i] > 0 && lista[i]%2==0)
            //    {
            //        Console.Write(lista[i] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine($"első elem: {lista[0]} utolsó elem: {lista[19]}");
            //Console.WriteLine("minden második eleme: ");
            //for (int i = 1; i < lista.Length; i+=2)
            //{
            //    Console.Write(lista[i] + " ");
            //}
            //Console.WriteLine();
            //int otoszt = new int();
            //int otosztatlag = new int();
            //Console.Write("5-el osztható számok átlaga: ");
            //for (int i = 0; i < lista.Length; i++)
            //{
            //    if (lista[i] % 5 == 0)
            //    {
            //        otoszt += lista[i];
            //        otosztatlag++;
            //    }
            //}
            //Console.Write(otoszt/otosztatlag);
            //int max = -20;
            //int min = 25;
            //for (int i = 0; i < lista.Length; i++)
            //{
            //    if (lista[i] > max)
            //    {
            //        max = lista[i];
            //    }
            //}
            //for (int i = 0; i < lista.Length; i++)
            //{
            //    if (lista[i] < min)
            //    {
            //        min = lista[i];
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine($"a legkisebb és a legnagyobb szám összege: {max+min}");

            //3.----------------------------------------

            int milliok = new int();
            int[] lotto = new int[5];
            for (int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = (random.Next(1, 90));
            }
            Array.Sort(lotto);
            Console.WriteLine("melyikek a nyerő számok?");
            int[] nyero = new int[5];
            for (int i = 0; i < 5; i++)
            {
                nyero[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(nyero);
            for (int i = 0; i < 5; i++)
            {
                if (nyero[0] == lotto[i] || nyero[1] == lotto[i] || nyero[2] == lotto[i] || nyero[3] == lotto[i] || nyero[4] == lotto[i])
                {
                    milliok += 1;
                }
            }
            if (milliok==0)
            {
                Console.WriteLine("nem nyert");
            }else
            {
                Console.WriteLine($"{milliok} szám lett jó");
            } 
        }
    }
}
