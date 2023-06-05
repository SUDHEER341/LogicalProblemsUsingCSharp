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


    }
    }
