using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wybieranie
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] tab = new int[20];
            Random generator = new Random();
            Console.WriteLine("Przed sortowaniem:");
            for (i = 0; i < 20; i++)
            {
                tab[i] = generator.Next(100);
                Console.Write("{0}, ", tab[i]);
            }
            for (i = 0; i < 20; i++)
            {
                int min = tab[i], k = i;
                for (j = i + 1; j < 20; j++)
                    if (min > tab[j])
                    {
                        min = tab[j];
                        k = j;
                    }
                tab[k] = tab[i];
                tab[i] = min;
            }
            Console.WriteLine("");
            Console.WriteLine("Po sortowaniu:");
            foreach (int k in tab)
                Console.Write("{0} ", k);


            Console.ReadKey();
        }
    }
}