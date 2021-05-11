using System;
using System.Linq;

namespace UnderstandingLINQProject
{
    class Program
    {
        int[] feedbackScores = { 90, 76, 45, 53, 1, 80, 22, 78, 99 };
        IQueryable<int> numbers;

        /// <summary>
        /// Feedback below 60 is low
        /// </summary>
        void PrintLowFeedbackCount()
        {
            //var count = from n in feedbackScores where n < 60 select n;

            var count = feedbackScores.Where(score => score < 60).Count();
            Console.WriteLine("The number of feedback that are less than 60 is "+count);
        }
        void PrintFeedbackInAscendingOrder()
        {
            var sortedFeedback = feedbackScores.OrderBy(score => score);
            Console.WriteLine("Printing sorted feedbacks");
            foreach (var item in sortedFeedback)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            program.PrintLowFeedbackCount();
            program.PrintFeedbackInAscendingOrder();
            Console.ReadKey();
        }
    }
}
