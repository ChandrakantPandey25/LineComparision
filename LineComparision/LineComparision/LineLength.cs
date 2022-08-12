using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class LineLength
    {
        public  double Line_Length()
        {
            Console.WriteLine("Enter the value of first coordinate x1 and y1");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of second coordinate x2 and y2");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Double y2 = Convert.ToDouble(Console.ReadLine());

            Double num1 = Math.Pow((x2 - x1), 2);
            Double num2 = Math.Pow((y2 - y1), 2);
            Double line = Math.Sqrt(num1 + num2);
            return line;




        }
    }
}
