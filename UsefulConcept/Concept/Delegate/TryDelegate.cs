using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulConcept.Concept.Delegate
{
    internal class TryDelegate
    {
        public static void DelegateRun()
        {
            //HandleTopicsOneRun();
            HandleTopicTwoRun();
        }

        static void  HandleTopicTwoRun()
        {
            Calculate calc = Sum;

            int a = 10;
            int b = 5;

            int AddOne(int a, int b) => a + b;
            int MinOne(int a, int b) => a - b;

            Console.WriteLine($"Call addOne Invoke : {new Calculate(AddOne).Invoke(a, b)}");
            Console.WriteLine($"Call minOne Invoke : {new Calculate(MinOne).Invoke(a, b)}");
        }

        static void HandleTopicsOneRun()
        {
            int a = 8;
            int b = 2;
            //call without delegate
            Console.WriteLine($"Call without delegate, a + b = {Sum(a, b)}");
            Console.WriteLine($"Call without delegate, a - b = {Difference(a, b)}");

            //call delegate
            Calculate calc = Sum;
            Console.WriteLine($"Sum Delegate : {calc.Invoke(a, b)}");

            calc = Difference;
            Console.WriteLine($"Difference Delegate : {calc.Invoke(a, b)}");

        }

        static int Sum(int a, int b)
        {
            return a+b;
        }
        static int Difference(int a, int b)
        {
            return a-b;
        }
        //delegate is references type, it's like non-static methods
        delegate int Calculate(int a, int b);

    }
}
