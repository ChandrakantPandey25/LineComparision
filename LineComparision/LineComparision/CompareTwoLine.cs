using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class CompareTwoLine
    {
        public static double Line_Length(Double x1, Double y1, Double x2, Double y2)
        {

            Double num1 = Math.Pow((x2 - x1), 2);
            Double num2 = Math.Pow((y2 - y1), 2);
            Double line = Math.Sqrt(num1 + num2);
            return line;
        }
        public  int LengthComparision()
        { 
            int i;
            double[] length = new double[2];

            for (i = 0; i < 2; i++)
            {

                Console.WriteLine("Enter the value of first coordinate x1 and y1");
                Double x1 = Convert.ToDouble(Console.ReadLine());
                Double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value of second coordinate x2 and y2");
                Double x2 = Convert.ToDouble(Console.ReadLine());
                Double y2 = Convert.ToDouble(Console.ReadLine());
                length[i] = Line_Length(x1, y1, x2, y2);

            }
            if (length[0] == length[1])

            {
                Console.WriteLine("given two lines length is equal");
            }
            else
            {
                Console.WriteLine("given two lines length is not equal");
            }
            return 0;

        }
    }
}
