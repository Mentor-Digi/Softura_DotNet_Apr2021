using System;
using System.Collections.Generic;
using System.Collections;

namespace CollectionsProject
{
    class Program
    {
        //int[] numbers = new int[10];
        //ArrayList numbers = new ArrayList();
        List<int> numbers = new List<int>();
        //n number of numbers
        //count is not pre-defined
        /// <summary>
        /// Takes numbers from user until user enters a negative number
        /// </summary>
        List<int> TakeNumbersFromUser()
        {
            List<int> numbers = new List<int>();
            int number = 0;
            do
            {
                Console.WriteLine("Please enter a number. Enter a negative number to quite(example -1)");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    int result = 10 / number;
                    if (number >= 0)
                        numbers.Add(number);
                }
                catch (DivideByZeroException dbz)
                {
                    Console.WriteLine("We cannot divide a number by zero.");
                    Console.WriteLine(dbz.Message);
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("We are exepecting a number. Please enter a whole number");
                    Console.WriteLine(formatException.Message);
                }
                catch (OverflowException overflowException)
                {
                    Console.WriteLine("The number is too big");
                    Console.WriteLine(overflowException.Message);
                }

            } while (number>=0);
            Console.WriteLine("The number of numbers entered is "+numbers.Count);
            if (numbers.Count == 0)
                // return null;
                numbers = null;
            return numbers;
        }

        void SortGivenNumbers()
        {
            //Take numbers from user
            List<int> myNumbers = TakeNumbersFromUser();
            //Sort the numers
            try
            {
                if(myNumbers!= null)
                {
                    myNumbers.Sort();
                    //Print the sorted numbers
                    PrintTheCollection(myNumbers);
                }
                else
                {
                    Console.WriteLine("The collection is empty");
                }
            }
            catch (NullReferenceException nrException)
            {
                Console.WriteLine("There are no numbers to be sorted");
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot sort. Sorry");
            }
        }

        private void PrintTheCollection(List<int> myNumbers)
        {
            if(myNumbers.Count>0)
            {
                foreach (var item in myNumbers)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("Nothing to print");
        }

        //static void Main(string[] args)
        //{
        //    new Program().SortGivenNumbers();
        //    Console.ReadKey();
        //}
    }
}
