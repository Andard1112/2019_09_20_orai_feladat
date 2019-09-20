using System;

namespace github_proba
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            int max = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("Kérem adja meg "+ (i+1)+" számot: ");
                tomb[i] = int.Parse(Console.ReadLine());
                if (max< i)
                {
                    max = i;
                }
            }
            Console.WriteLine("A legnagyobb szám:{0}",max);
            Console.ReadKey();
        }
    }
}
