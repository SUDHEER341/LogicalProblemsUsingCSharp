using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Programs
    {
        public static void Reverse_Number()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int numberCopy = number;
            int reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse number of {0} is {1}", numberCopy, reverse);
        }

        public static void Prime_Number()
        {
            Console.WriteLine("Enter the number to check whether it is prime or not");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
                if (count > 0)
                {
                    break;
                }
            }

            if (count > 0)
            {
                Console.WriteLine("{0} is not a prime number  ", number);
            }
            else
            {
                Console.WriteLine("{0} is a prime number ", number);
            }
        }

        public static void Perfect_Number()
        {
            Console.WriteLine("Please enter the number to check it is Perfect number or not");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;

                }
            }
            if (sum == number)
            {
                Console.WriteLine("{0} is a perfect number", number);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", number);
            }
        }
        public static void Fibanocci_Series()
        {
            Console.WriteLine("Please enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(a);

                c = a + b;
                a = b;
                b = c;
            }
        }

        public static void StopWatch()
        {
            Console.WriteLine("Press any key to start the stopwatch...");
            Console.ReadKey();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Stopwatch started. Press any key to stop...");
            Console.ReadKey();

            stopwatch.Stop();

            TimeSpan elapsedTime = stopwatch.Elapsed;
            Console.WriteLine($"Elapsed time: {elapsedTime}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
