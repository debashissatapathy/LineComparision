using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison
{
    class UC1_EqualityOfLine
    {
        public void Len_of_Line()
        {
            Console.WriteLine("Enter thevalue of First coordinate value");
            Console.WriteLine("Enter the value of x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of b1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double finalresult = len(x1, x2, y1, y2);

            Console.WriteLine("len between {0},{1} and {2}, {3} is {4:F}", x1, y1, x2, y2, finalresult);

            static double len(double x1, double x2, double y1, double y2)
            {
                var count1 = Math.Pow((x2 - x1), 2);
                var count2 = Math.Pow((y2 - y1), 2);
                var result = Math.Sqrt(count1 + count2);
                return result;
            }
        }
    }
}
