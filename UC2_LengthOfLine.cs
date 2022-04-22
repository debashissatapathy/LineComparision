using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison
{
    class UC2_LengthOfLine
    {
        public static void Equality_of_Line()
        {
            Console.WriteLine("Enter thevalue of First coordinate value");
            Console.WriteLine("Enter the value of x1, y1, x2, y2 ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double fresult1 = len1(x1, x2, y1, y2);

            Console.WriteLine("len between {0},{1} and {2}, {3} is {4:F}", x1, y1, x2, y2, fresult1);

            static double len1(double x1, double x2, double y1, double y2)
            {
                var count1 = Math.Pow((x2 - x1), 2);
                var count2 = Math.Pow((y2 - y1), 2);
                var result = Math.Sqrt(count1 + count2);
                return result;
            }
            Console.WriteLine("Enter thevalue of Second coordinate value");
            Console.WriteLine("Enter the value of a1, b1,a2, b2 ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double fresult2 = len2(a1, a2, b1, b2);

            Console.WriteLine("len between {0},{1} and {2}, {3} is {4:F}", a1, b1, a2, b2, fresult2);

            static double len2(double a1, double a2, double b1, double b2)
            {
                var count3 = Math.Pow((a2 - a1), 2);
                var count4 = Math.Pow((b2 - b1), 2);
                var result1 = Math.Sqrt(count3 + count4);
                return result1;
            }
            bool status = fresult1.Equals(fresult2);
            if (status)
            {
                Console.WriteLine("Line1({0}) is equal to line2 ({1})", fresult1, fresult2);
            }
            else
            {
                Console.WriteLine("Line1({0}) is not equal to line2 ({1})", fresult1, fresult2);
            }


        }

    }
    
        
    
}
