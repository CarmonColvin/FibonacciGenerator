using System;

namespace FibonacciGenerator
{
    /// <summary>
    /// Main program to run.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main starting point for console application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program.GenerateFibonacciSequence();
            Console.WriteLine("Press Any Key To Exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        protected static void GenerateFibonacciSequence()
        {
            // Setup local variables; start the fibonacci sequence at 1
            Int64 currentFib = 0;
            Int64 previous1 = 0;
            Int64 previous2 = 0;
            Int32 counter = 1;

            // Output the initial value
            Console.WriteLine($"{counter++} :{currentFib}");

            // Loop until we reach overflow
            while (true)
            {
                // Handle the special case when the fibonacci sequence is at 0
                if (currentFib == 0)
                {
                    // Increment to 1
                    currentFib++;

                    // Update the previous values
                    previous2 = previous1;
                    previous1 = currentFib;

                    // Output the value, increment the counter
                    Console.WriteLine($"{counter++} :{currentFib}");

                    // Jump to the next loop
                    continue;
                }

                // Calculate the current fibonacci number
                currentFib = previous1 + previous2;

                // Update the previous fibonacci numbers
                previous2 = previous1;
                previous1 = currentFib;

                // Does the current fibonacci number exceede the limit of Int64? (indicated by an overflow to a negative number)
                if (currentFib < 0)
                {
                    // Output the value
                    Console.WriteLine($"{counter} :Number Exceedes Int64 Display Limit: ({Int64.MaxValue})");

                    // Break out of the loop
                    break;
                }
                else
                {
                    // Output the value, increment the counter
                    Console.WriteLine($"{counter++} :{currentFib}");
                }
            }
        }
    }
}
