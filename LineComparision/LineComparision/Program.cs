using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision");
            Console.WriteLine("Enter 1 for Line Length");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    LineLength line = new LineLength();
                    double lineOne=line.Line_Length();
                    Console.WriteLine("Length of the Line is :"+lineOne);
                    break;
            }

        }
    }
}
