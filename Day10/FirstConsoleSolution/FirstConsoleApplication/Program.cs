using System;

namespace FirstConsoleApplication
{
    class Program
    {
        static int num1, num2;//class level scope
        static void TakeTwoNumbersFromUser()
        {
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());//Unboxing - Converting the ref type to value type
            Console.WriteLine("Please enter the second number");
            num2 = Int32.Parse(Console.ReadLine());
        }
        static void FirstMethod()
        {
            //Console.WriteLine("Hello From My Method");
            //Console.WriteLine("Code snippet check");
            Console.WriteLine("User user please enter something");
            string data = Console.ReadLine();
            Console.WriteLine("User user u entered "+data);
        }
        static void DealingNumbers()
        {
            Console.WriteLine("Please enter a integer");
            //string number = Console.ReadLine();
            //int num1 = Convert.ToInt32(number);//explicit conversion
            int num1 = Convert.ToInt32(Console.ReadLine());
            num1 = num1 * 100;
            Console.WriteLine("The numebr multiplied by 100 is "+num1);

        }
        static void Calculate()
        {
            TakeTwoNumbersFromUser();
            Console.WriteLine("The numebrs are "+num1+" "+num2);
            int sum = num1 + num2;
            Console.WriteLine("The sum of the numbers {0} and {1} is {2} ",num1,num2,sum);
            float fNum1, fNum2;
            fNum1 = num1;
            fNum2 = num2;
            float result = (float)(fNum1 / fNum2);
            Console.WriteLine("The division result  of the numbers {0} and {1} is {2} ", num1, num2, result);
        }
        static void PrintBiggestOfTwo()
        {
            TakeTwoNumbersFromUser();
            if(num1==num2)
                Console.WriteLine("Num1 {0} and Num2 {1} are equal", num1,num2);
            else if (num1>num2)
                Console.WriteLine("Num1 {0} is greater ",num1);
            else
                Console.WriteLine("Num2 {0} is greater ", num2);
        }
        static void PrintDayOfWeek()
        {
            Console.WriteLine("Please enter a day");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine("Weekday");
                    break;
                case "Friday":
                    Console.WriteLine("Weekday but will be weekend soon");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }
        }
        static void UnderstandingIteration()
        {
            //for - finite iteration
            //for(init;cond;upd)
            //first time int and cond
            //then on upd and cond
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("For loop end");
            //while - check for every iteration
            //int flag = 0,sum=0;
            //while(flag>=0)
            //{
            //    //sum = sum + flag;
            //    sum += flag;
            //    Console.WriteLine("Please enter a number");
            //    flag = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Here we go... The sum is "+sum);
            //do while- check condition at end- loop executes minimum once
            int flag = -1, sum = 0;
            do
            {
                Console.WriteLine("Please enter a number");
                flag = Convert.ToInt32(Console.ReadLine());
                //sum = sum + flag;
                sum += flag;
            } while (flag >= 0);
            Console.WriteLine("Here we go... The sum is " + sum);
        }
        static void UnderstandingErrorHandling()
        {
            int num = 0;
            Console.WriteLine("Please enter the number");
            //num = Int32.Parse(Console.ReadLine());
            //bool check = Int32.TryParse(Console.ReadLine(), out num);
            while(Int32.TryParse(Console.ReadLine(), out num)==false)
                Console.WriteLine("Invalid input. Please enter an integer");
            Console.WriteLine("The number is "+num);
        }
        static void Main(string[] args)
        {
            //FirstMethod();
            // DealingNumbers();
            //Calculate();
            //PrintBiggestOfTwo();
            //PrintDayOfWeek();
            //UnderstandingIteration();
            UnderstandingErrorHandling();
            //Console.WriteLine("Hello World!");
        }
    }
   
}
