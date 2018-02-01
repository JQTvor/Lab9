using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle
    {

        private double radius;
        private const double PI = Math.PI;

        public Circle(double r)
        {
            radius = r;
        }


        public double GetCircumference()
        {
            double circum = 2 * PI * radius;
            return circum;
        }

        public double GetArea()
        {
            double area = (radius * radius) * PI;
            return area;
        }

        public string FormatCircumference()
        {
            double c = GetCircumference();
            c = Math.Round(c, 2);
            return c.ToString();
        }

        public string FormatArea()
        {
            double a = GetArea();
            a = Math.Round(a, 2);
            return a.ToString();
        }




    }
}
