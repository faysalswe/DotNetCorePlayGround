using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceCSharpTopic
{
    /*
        1. ref and out keyword set before method parameter as a reference type
        2. normal and ref parameter must have to assign value
    */
    public class RefAndOutKeyword
    {
        public static void Init()
        {
            int number = 10;
            Assign100(number);
            Console.WriteLine("normal {0}", number);

            Assign100WithRef(ref number);
            Console.WriteLine("with ref {0}", number);

            Assing200WithOut(out number);
            Console.WriteLine("with Out {0}", number);
        }

        static void Assign100(int number)
        {
            number = 100;
        }

        static void Assign100WithRef(ref int number)
        {
            number = 100;
        }

        static void Assing200WithOut(out int number)
        {
            number = 200;
        }
    }
}
