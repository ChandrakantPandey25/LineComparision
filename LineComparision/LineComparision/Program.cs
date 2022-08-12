using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision");
            Console.WriteLine("Enter 1 for Line Length");
            Console.WriteLine("Enter 2 for Line Length comparision of two lines");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    LineLength line = new LineLength();
                    double lineOne=line.Line_Length();
                    Console.WriteLine("Length of the Line is :"+lineOne);
                    break;
                case 2:
                    CompareTwoLine compare = new CompareTwoLine();
                    double result = compare.LengthComparision();
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;

            }

        }
    }
}
