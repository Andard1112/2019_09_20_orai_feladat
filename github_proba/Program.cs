using System;

namespace github_proba
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Kérem adja meg, hogy milyen hosszú legyen a tomb");
                int meret = int.Parse(Console.ReadLine());
                int[] tomb = new int[meret];

                for (int i = 0; i < meret; i++)
                {
                    Console.WriteLine("Kérem adja meg " + (i + 1) + " számot: ");
                    tomb[i] = int.Parse(Console.ReadLine());

                }
                int max = tomb[0];
                int min = tomb[0];
                for (int i = 0; i < meret; i++)
                {
                    if (max < tomb[i])
                    {
                        max = tomb[i];
                    }
                    if (min > tomb[i])
                    {
                        min = tomb[i];
                    }
                }
                Console.WriteLine("A legnagyobb szám:{0}", max);
                Console.WriteLine("A legkisebb szám:{0}", min);
                Console.ReadKey();
            }
            catch (Exception e)
            {

                Console.Write("Hiba történt, a megadott érték nem szám!");
                Console.ReadKey();
            }
            
        }
    }
}
