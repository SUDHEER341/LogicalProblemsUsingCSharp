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

            
        }
    }
