using System;

namespace TaulukkoTesti1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[5];

            luvut[0] = 2;

            for (int i = 1; i < luvut.Length; i++)
            {
                luvut[i] = i + 6;
            }

            for (int i = 0; i < luvut.Length; i++)
            {
                Console.Write(luvut[i] + " ");
            }
            Console.WriteLine();

            foreach (int item in luvut)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
