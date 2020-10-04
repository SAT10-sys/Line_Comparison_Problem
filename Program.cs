﻿using System;

namespace Line_Comparison_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthOfLine1 = 0, lengthOfLine2 = 0;
            Console.WriteLine(" Enter the following values of Line 1 in order: ");
            Console.WriteLine("\n 1. X co-ordinate of starting point\n 2. Y co-ordinate of starting point\n 3. X co-ordinate of ending point\n 4. Y co-ordinate of ending point\n");
            double abscissa11 = Double.Parse(Console.ReadLine());
            double ordinate11= Double.Parse(Console.ReadLine());
            double abscissa21= Double.Parse(Console.ReadLine());
            double ordinate21= Double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the following values of Line 2 in order: ");
            Console.WriteLine("\n 1. X co-ordinate of starting point\n 2. Y co-ordinate of starting point\n 3. X co-ordinate of ending point\n 4. Y co-ordinate of ending point\n");
            double abscissa12 = Double.Parse(Console.ReadLine());
            double ordinate12 = Double.Parse(Console.ReadLine());
            double abscissa22 = Double.Parse(Console.ReadLine());
            double ordinate22 = Double.Parse(Console.ReadLine());
            Line_Values lineValues1 = new Line_Values(abscissa11, ordinate11, abscissa21, ordinate21);
            Line_Values lineValues2 = new Line_Values(abscissa12, ordinate12, abscissa22, ordinate22);
            lengthOfLine1 = lineValues1.LineLength(abscissa11, ordinate11, abscissa21, ordinate21);
            lengthOfLine2 = lineValues2.LineLength(abscissa12, ordinate12, abscissa22, ordinate22);

            //checking by Equals Method
            bool checkOutputEquality = lengthOfLine1.Equals(lengthOfLine2);
            if (checkOutputEquality)
                Console.WriteLine(" Both the lines are of equal length ");
            else if (lengthOfLine1 > lengthOfLine2)
                Console.WriteLine(" The first line is longer ");
            else
                Console.WriteLine(" The second line is longer ");
        }
    }
}
