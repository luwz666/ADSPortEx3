using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    class ComplexityFunctions
    {
        //Big O calculation for Assessed Exercise 3A

        //Hints : 
        //Use lecture materials from Week 6B to aid with calculations.

        //See ExampleQuestion() to see a suggested format for showing your
        // working out and final answer, both of which must be shown with correct
        // answers for full marks.


        public void ExampleQuestion()
        {
            //F.C
            Console.WriteLine("Enter a number 1:");          // 1
            int num1 = Int32.Parse(Console.ReadLine());      // 1

            Console.WriteLine("Enter a number 2:");          // 1
            int num2 = Int32.Parse(Console.ReadLine());      // 1

            for (int i = 1; i <= num2; i++)                  // n + 1
            {
                Console.WriteLine(num1.ToString() + " X "
                    + i.ToString() + " = " + (num1 * i));   // n
            }

            Console.WriteLine("End of program...");         // 1

            Console.ReadLine();                             // 1


            //Working out

            // 7 + 2n - All F.Cs added together
            // 2n     - Constants removed
            // n      - Coefficients removed
            // O(n)   - Final answer
        }

        public void ScheduleCheck()
        {

            Console.WriteLine("Enter number of satellites: ");

            int satellites = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of time slots: ");

            int slots = Int32.Parse(Console.ReadLine());

            // Create a schedule matrix [satellites x slots]
            bool[,] schedule = new bool[satellites, slots];

            Console.WriteLine("Checking availability...");

            for (int i = 0; i < satellites; i++)
            {

                Console.WriteLine("Checking satellite " + (i + 1));

                for (int j = 0; j < slots; j++)
                {
                    schedule[i, j] = (i + j) % 2 == 0;
                    if (schedule[i, j])
                    {
                        Console.WriteLine("Satellite " + (i + 1) + " is available at slot " + (j + 1));
                    }

                }
            }

            Console.WriteLine("Schedule check complete.");

            Console.ReadLine();
        }

        public void SignalProcessing()
        {


            int n = Int32.Parse(Console.ReadLine());
            int primeCount = 0;

            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                int j = 2;
                while (j * j <= i)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime)
                    primeCount++;
                
            }
            Console.WriteLine("Number of primes up to " + n + ": " + primeCount);
        }
    }
}
