using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulConcept.Concept.MultipleValue
{
    internal class Employee
    {
        public const decimal baseSalary = 100_000;

        public readonly int _id = 100;

        public Employee(int id)
        {
            _id = id;
        }


        /*  public int Age { get; } --Jika re-assign contoh. Employee.Age = 25 akan error, dikarenakan 
         *  hanya terdapat method Get, dan tidak Setter untuk mengubah value, dan penulisan seperti ini
         *  sama seperti ReadOnly*/

        public int Age { get; set; } = 10; //untuk syntax seperti ini, data dapat di re-assign atau diubah

        public readonly List<int> numList = new();

        public void AddNum(int num) { numList.Add(num); }

        public void DisplayNum() { numList.ForEach(item => Console.WriteLine(item)); }

        public static void UpdatePromo(double price, float promo, 
            out decimal totalPrice, out decimal totalDiscount)
        {
            totalPrice= (decimal)(price *(promo/100) + price);
            totalDiscount= (decimal)(price - promo);
        }
    }
}
