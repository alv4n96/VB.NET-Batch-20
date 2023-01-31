using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using UsefulConcept.Concept.Delegate;
using UsefulConcept.Concept.Lambda;
using UsefulConcept.Concept.Model;
using UsefulConcept.Concept.MultipleValue;
using static UsefulConcept.Concept.Model.AllShapeModel;

namespace UsefulConcept.Nullable
{
    internal class Conceptual
    {
        public static void Run()
        {
            //ShowNullable();
            //RunPassing();
            //RunIsOperator();
            //RunAsOperator();
            //RunMultipleValue();
            //GenericTestRun();

            /* -- This is handle for topic delegate -- */
            //TryDelegate.DelegateRun();

            /* -- This is handle for topic Lambda -- */
            TryLambda.LambdaRun();
        }

        static void GenericTestRun()
        {
            var emp = new Employee(101);

            var _this = new Employee(102);
            _this.AddNum(23);
            _this.AddNum(23);
            _this.DisplayNum();
            Console.WriteLine(emp._id);
        }

        static void RunMultipleValue()
        {
            decimal totalPrice, totalDiscount;

            Employee.UpdatePromo(50_000,1000,out totalPrice, out totalDiscount);

            Console.WriteLine(totalPrice);
            Console.WriteLine(totalDiscount);
        }

        static void RunAsOperator()
        {
            Shape shape = new();
            Circle circle = new();

            Shape? convertToShape = circle as Shape;
            Console.WriteLine($"Convertions 'Circle as shape' produces {convertToShape}");

            Circle? convertToCircle = shape as Circle;
            if (convertToCircle == null) Console.WriteLine("Convertions 'Circle as shape' produces is null");
            else Console.WriteLine($"Convertions 'Circle as shape' produces {convertToCircle}");

        }

        static void RunIsOperator()
        {
            Circle circle = new();
            Rectangle rectangle = new();

            Console.WriteLine($"Is circle inherit from shape : {circle is Shape}");
            Console.WriteLine($"Is rectangle inherit from shape : {rectangle is Shape}");
        }

        static void RunPassing()
        {

            int _byVal = 10; //immutable
            PassingByValue(_byVal);
            Console.WriteLine($"Final value {nameof(_byVal)} : {_byVal}");
            Console.WriteLine();

            int _byRef = 10; //mutable
            Console.WriteLine($"Final value {nameof(_byRef)} : {_byRef}");
            PassingByReference(ref _byRef);
            Console.WriteLine($"Final value {nameof(_byRef)} : {_byRef}");
            PassingByReference(ref _byRef);
            Console.WriteLine($"Final value {nameof(_byRef)} : {_byRef}");
            Console.WriteLine();
        }


        static void PassingByValue (int ByValue)
        {
            ByValue *= 2;
            Console.WriteLine($"Body PassingByValue, {nameof(ByValue)} value : {ByValue}");
        }

        static void PassingByReference (ref int ByRef)
        {
            ByRef *= 2;
            Console.WriteLine($"Body PassingByReference, {nameof(ByRef)} value : {ByRef}");
        }

        static void ShowNullable()
        {
            //variable reference Type
            string? name = "Test";

            if (name == null || name == string.Empty) Console.WriteLine("null value");
            else Console.WriteLine($"Name : {name}");


            //variable value Type
            int? age = null;

            if (age.HasValue) Console.WriteLine($"Age : {age}");
            else Console.WriteLine("Age has no value");

        }
    }
}
