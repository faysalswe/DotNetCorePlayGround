using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceCSharpTopic
{
    /*
        1. delegate is used to pass function as parameter or handle callback / event
        2. A delegate can point multiple methods called multi cast delegate
        3. predicate technically generic delegate
    */
    class Delegate
    {

        public delegate int SumDelegate(int num1, int num2);
        public static void Init()
        {
            SumDelegate sumDelegate = Sum;
            Console.WriteLine(sumDelegate(10, 20));

            int Sum(int num1, int num2) => num1 + num2;
        }
    }
}
