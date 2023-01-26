using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulConcept.Nullable
{
    internal class Conceptual
    {
        public static void ShowNullable()
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
