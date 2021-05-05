using System;

namespace UndersandingDelegateProject
{
    class Program
    {
      
        void AddBassByValue(int num1)
        {
            Console.WriteLine("Pass by val before incr " + num1) ;
            num1 = num1 + 1;
            Console.WriteLine("Pass by val after incr " + num1);
        }
        void AddBassByRef(ref int num1)
        {
            Console.WriteLine("Pass by ref before incr " + num1);
            num1 = num1 + 1;
            Console.WriteLine("Pass by ref after incr " + num1);
        }

        void CallMethods()
        {
            int num1 = 10;
            //Console.WriteLine("Calling method- before passby val call "+num1);
            //AddBassByValue(num1);
            //Console.WriteLine("Calling method- after passby val call " + num1);
            Console.WriteLine("Calling method- before passby ref call " + num1);
            AddBassByRef(ref num1);
            Console.WriteLine("Calling method- after passby ref call " + num1);
        }

        void WorkWithNothing(SummaClass summa)
        {
            summa.PrintNothing();
            Console.WriteLine(summa.Nothing);
            summa.Nothing = 200;
        }

        void CallWork()
        {
            SummaClass summa = new SummaClass();
            summa.Nothing = 100;
            WorkWithNothing(summa);
            Console.WriteLine(summa.Nothing);
        }
        //public delegate void myDelegate();//we are creating out type delegate matching the method signature(as in return type and parameter)
        //void MyMethod()
        //{
        //    Console.WriteLine("This is the  my method");
        //}
        //void YourMethod()
        //{
        //    Console.WriteLine("This is the your method");
        //}
        //void GetMthodAsParameter(myDelegate del)
        //{
        //    del();
        //}
        void GetMthodAsParameter(Action del)
        {
            del();
        }

        void GetMethodWithParamAsParameter(Action<int,int> action)
        {
            action(10,20);
        }
        void GetMethodWithParamAndReturnAsParameter(Func<int, int> func)
        {
            int value = func(10);
            Console.WriteLine(value);
        }
        void GetMethodWithParamAndReturnsBoolAsParameter(Predicate<SummaClass> func)
        {
            SummaClass summa = new SummaClass();
            summa.Nothing = 10;
            bool value = func(summa);
            Console.WriteLine("The result "+value);
        }

        void CallMethodWithMethodParameter()
        {
            //myDelegate objDelegate = new myDelegate(MyMethod);
            // objDelegate += new myDelegate(YourMethod);//Mulicast delegate
            //myDelegate objDelegate = delegate () { Console.WriteLine("From a  anon method"); };//Anon method
            //objDelegate += delegate () { Console.WriteLine("From a  another anon method"); };//Another Anon method
            //myDelegate objDelegate = ()=>{ Console.WriteLine("From a  anon method"); };//Lambda expression
            //objDelegate += ()=> { Console.WriteLine("From a  another anon method"); };//adding one more Lambda expression
            //Action objDelegate = () => { Console.WriteLine("From a  anon method"); };//Pre built delegate and Lambda expression
            //objDelegate += () => { Console.WriteLine("From a  another anon method"); };//Pre built delegate adding one more Lambda expression 
            //GetMthodAsParameter(objDelegate);
            //Action<int, int> action = (num1, num2) => Console.WriteLine("The product is "+ (num1 * num2));
            //GetMethodWithParamAsParameter(action);
            //Func<int, int> myFunc = (num1) => num1 * 100;
            //GetMethodWithParamAndReturnAsParameter(myFunc);
            Predicate<SummaClass> predicate = s => s.Nothing > 10;//exclusive bool return type
            GetMethodWithParamAndReturnsBoolAsParameter(predicate);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //new Program().CallMethods();
            //new Program().CallWork();
            new Program().CallMethodWithMethodParameter();
            Console.ReadKey();
        }
    }
}
