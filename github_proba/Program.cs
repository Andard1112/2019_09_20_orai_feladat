using System;

namespace github_proba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg, hogy milyen hosszú legyen a tomb");
            int meret = int.Parse(Console.ReadLine());
            int[] tomb = new int[meret];
            int max = 0;
            for (int i = 0; i < meret; i++)
            {
                Console.WriteLine("Kérem adja meg "+ (i+1)+" számot: ");
                tomb[i] = int.Parse(Console.ReadLine());
                if (max< tomb[i])
                {
                    max = tomb[i];
                }
            }
            Console.WriteLine("A legnagyobb szám:{0}",max);
            Console.ReadKey();
        }
    }
}
