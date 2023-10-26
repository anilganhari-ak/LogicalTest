using System;

namespace LogicalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Print(100);
            Reverse("Sample");
        }


        // Print text

        static void Print(int number)
        {
            for (int i = 1; i <= number; i++)
            {

                if(i%5 == 0)
                {
                    Console.WriteLine(i + "buzz");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + "fizz");
                }

                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i + "fizzbuzz");
                }
            }
        }

        static void Reverse(string value)
        {
            char[] chars = value.ToCharArray();
            string reverse = string.Empty;
            for (int i = chars.Length -1 ; i > - 1; i--)
            {
                reverse += chars[i];
            }

            Console.WriteLine(reverse);
        }
    }
}
