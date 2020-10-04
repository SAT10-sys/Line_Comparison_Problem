using System;

namespace Line_Comparison_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Line Comparison Computation Program ");
            Console.WriteLine(" Enter the X and Y co-ordinates of starting point of line: ");
            double abscissa1 = Double.Parse(Console.ReadLine());
            double ordinate1 = Double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the X and Y co-ordinates of ending point of line: ");
            double abscissa2 = Double.Parse(Console.ReadLine());
            double ordinate2 = Double.Parse(Console.ReadLine());
            Line_Values lineValues = new Line_Values(abscissa1, ordinate1, abscissa2, ordinate2);
            Console.WriteLine(" Length of the line is: " + lineValues.LineLength(abscissa1, ordinate1, abscissa2, ordinate2));
        }
    }
}
