using System;

namespace Loop1To100
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Looper(i));
            }
            Console.ReadKey();
        }

        static string Looper(int number)
        {
            string val = "";
            if (number % 3 == 0)
            {
                val += ("Aksel");
            }

            if (number % 5 == 0)
            {
                val += ("Gregersen");
            }

            if (val == "")
            {
                val += number;
            }

            return val;
        }
    }
}
