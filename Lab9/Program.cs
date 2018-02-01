using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        

        static void Main(string[] args)
        {
            String answer = Console.ReadLine(); double r = Convert.ToDouble(answer);
            Circle c = new Circle(r);

            Console.WriteLine("The circumference of " + r + " is " + c.FormatCircumference() + "\nThe area of " + r + " is " + c.FormatArea());

        }
    }
}
