using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulConcept.Concept.Lambda
{
    internal class TryLambda
    {
        public static void LambdaRun()
        {
            int number = 10;
            int[] testNumber = { 1,2,3,4,5,6,7,8,9,10 };
            var _lambada = new TryLambda();

            var x = _lambada.IsEvenNotLambda(num: number);
            var y = _lambada.IsEvenLambda(number);

            var testCount = _lambada.Count(testNumber, _lambada.IsEvenLambda);

            Console.WriteLine($"{x} dan {y}");
            Console.WriteLine($"total number is event in list {nameof(testNumber)} is {testCount}");

            //from this sample, you can simple it to lambda function
            //var checkResCount = _lambada.Count(testNumber, x =>
            //{
            //    Console.WriteLine(x);
            //    return x % 2 == 0;
            //});

            //to this 
            var checkResCount = _lambada.Count(testNumber, x => x % 2 == 0);



            Console.WriteLine(checkResCount);

        }

        bool IsEvenNotLambda(int num)
        {
            return num % 2 == 0;
        }

        bool IsEvenLambda(int num) => num % 2 == 0;

        int Count(int[] inputArray, Func<int, bool> isEven)
        {
            int count = 0;

            foreach (var item in inputArray)
            {
                if (isEven(item)) count++;
            }

            return count;
        }


    }
}
