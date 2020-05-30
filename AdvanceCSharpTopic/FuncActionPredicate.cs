using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceCSharpTopic
{
    /*
         1. A Func, Action and predicate are built in generic type delegate(not need define as custom delegate)
         2. Func has 0 or more input parameters and one out parameter
         3. Action has 0 or more input parameters an not out parameter
         4. Predicate delegate takes one input parameter and return boolean
    */
    public class FuncActionPredicate
    {
        public static void Init()
        {
            Func<int, bool> isEvenFunc = IsEven;
            Console.WriteLine("Func " + isEvenFunc(4));

            // Lambda function 
            Action<int> incrimentAction = (number) => Console.WriteLine("Action " + ++number);
            incrimentAction(10);

            Predicate<int> isEven = IsEven;
            Console.WriteLine("Predicate " + isEven(9));

            // Anonymous method C# 2.0
            Predicate<int> isOdd = delegate(int number) {
                int remainder = number % 2;

                if (remainder == 0)
                {
                    return false;
                } 

                return false; 
            };
            Console.WriteLine("Anonymous method Predicate " + isOdd(9));
            
            // Local function C# 7.0
            bool IsEven(int number)
            { 
                return number % 2 == 0;  
            }
        }
    }
}
