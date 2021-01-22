using System;
using System.Diagnostics;

namespace UsingMultipleAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            ConditionalAttribute[] conditionalAttribute = (ConditionalAttribute[])Attribute.GetCustomAttributes(typeof(ConditionalClass), typeof(ConditionalAttribute));
            Console.WriteLine(conditionalAttribute[0].ConditionString); // returns CONDITION1
            Console.WriteLine(conditionalAttribute[1].ConditionString); // returns CONDITION2
            Console.Read();
        }

        
    }

    [Conditional("CONDITION1"), Conditional("CONDITION2")]
    class ConditionalClass : Attribute
    {
      
    }
}

    
