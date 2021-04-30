using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class AnotherCSharpFeatures
    {
        void UnderstandingNull()
        {
            string name = null;
            Console.WriteLine(name);
            int? num1 = 200;
            int num2 = num1 ?? 100;
            Console.WriteLine(num2);
        }
        void UnderstandingCheckedBlock()
        {
            int num = int.MaxValue;
            checked
            {
                num = num + 1000;
            }
            
            Console.WriteLine(num);
        }
        //static void Main(string[] a)
        //{
        //    new AnotherCSharpFeatures().UnderstandingCheckedBlock();
        //    Console.ReadKey();
        //}
    }
}
