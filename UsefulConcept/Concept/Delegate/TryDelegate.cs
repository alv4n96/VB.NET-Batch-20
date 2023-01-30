using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UsefulConcept.Concept.Delegate
{
    internal class TryDelegate
    {

        public static void DelegateRun()
        {
            //Delegate implementation ( Part 1 )

            //HandleTopicOneRun();
            //HandleTopicTwoRun();

            //Action Implementation ( Part 2 )
            //HandleTopicTwoActionRun();

            //Func Implementation ( Part 3 )
            //HandleTopicThreeFuncRun();

            //Predicate Implementation ( Part 4 )
            HandleTopicFourPredicateRun();
            

        }

        //delegate is references type, it's like non-static methods
        delegate int Calculate(int a, int b); 

        //Topic 1 -- Delegate
        static void  HandleTopicDelTwoRun()
        {
            Calculate calc = Sum;

            int a = 10;
            int b = 5;

            int AddOne(int a, int b) => a + b;
            int MinOne(int a, int b) => a - b;

            Console.WriteLine($"Call addOne Invoke : {new Calculate(AddOne).Invoke(a, b)}");
            Console.WriteLine($"Call minOne Invoke : {new Calculate(MinOne).Invoke(a, b)}");
        }

        static void HandleTopicDelOneRun()
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

        //Topic 2 -- Action doesnt have return value
        static void HandleTopicTwoActionRun()
        {
            //pada deklarasi var untuk Action, itu harus sesuai dan urut dengan input parameter dari fungsi yang digunakan
            Action<string, string, int> actDel = Show1;

            //Single Action~!
            actDel("Test","First", 23); // ini hanya akan menampilkan show 1, dikarenakan, kita hanya assign Show1 di variabel actDel

            //Multi Delegate
            actDel += Show2;
            actDel += Show3;

            actDel("Action","Test",23); // ini akan menampilkan show 1 S.d 3, dikarenakan, untuk show 1 sudah di assign di awal, 
            // dan pada bagian Multi Delegate, kita membuat action, untuk menambahkan pemanggilan method untuk show 2 dan show 3.
        }

        static void Show1(string firstName, string lastName ,int age) => Console.WriteLine($"Show1 with name : {firstName} {lastName}, and Age {age} is Called");
        static void Show2(string firstName, string lastName ,int age) => Console.WriteLine($"Show2 with name : {firstName} {lastName}, and Age {age} is Called");
        static void Show3(string firstName, string lastName ,int age) => Console.WriteLine($"Show3 with name : {firstName} {lastName}, and Age {age} is Called");

        //Topic 3 -- Func<> just for 16 variable and must have return, int the last variable 

        static void HandleTopicThreeFuncRun()
        {
            // for Func, we use methods from Topic 1, wheter is Sum and Difference
            int a = 15;
            int b = 5;

            Func<int, int, int> funcDel = Sum;
            Console.WriteLine($"it's called {nameof(funcDel)} with method sum, and result is {funcDel(a, b)}");

            funcDel = Difference;
            Console.WriteLine($"it's called {nameof(funcDel)} with method Diff, and result is {funcDel(a, b)}");


            //for chain delegate, it will be invoke or call the last method called.
            Func<int, int, int> funcChainDel = Sum;
            funcChainDel += Difference;

            Console.WriteLine($"it's called {nameof(funcChainDel)} with method Diff, and result is {funcChainDel(a, b)}");

        }

        //Topic 4 -- predicatejust for 16 variable, and return must boolean

        static void HandleTopicFourPredicateRun()
        {
            Predicate<int> isGreaterThan20 = TestGreaterThan20;

            Console.WriteLine($"25 Greater Than 20? {isGreaterThan20(25)}");
            Console.WriteLine($"15 Greater Than 20? {isGreaterThan20(15)}");
        }

        static bool TestGreaterThan20(int num) => num > 20;
    }
}
