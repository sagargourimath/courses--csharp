using System;

namespace Multiplier
{
    class Program
    {
        static void Main()
        {
            // Create a console application with a for loop that multiplies a number by five
            // and adds it to the total each time. Step through the code.

            Console.WriteLine("Enter the number");
            var number = Console.ReadLine();

            var isValidInteger = int.TryParse(number, out int num);

            if(isValidInteger)
            {
                var sum = 0;

                for (int i = 0; i < 10; i++)
                {
                    sum += num * 5;
                }

                Console.WriteLine($"The final output is {sum}");
            }
            else
            {
                Console.WriteLine("You did not enter a valid integer");
            }

            Console.ReadLine();
        }
    }
}
