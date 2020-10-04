using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Line_Comparison_Problem
{
    class Line_Values
    {
        public double xcoOrdinate1;
        public double ycoOrdinate1;
        public double xcoOrdinate2;
        public double ycoOrdinate2;
        public Line_Values(double xcoOrdinate1, double ycoOrdinate1, double xcoOrdinate2, double ycoOrdinate2)
        {
            this.xcoOrdinate1 = xcoOrdinate1;
            this.ycoOrdinate1 = ycoOrdinate1;
            this.xcoOrdinate2 = xcoOrdinate2;
            this.ycoOrdinate2 = ycoOrdinate2;
        }
        public double LineLength(double xcoOrdinate1, double ycoOrdinate1, double xcoOrdinate2, double ycoOrdinate2)
        {
            double lineLength = Math.Sqrt(Math.Pow(xcoOrdinate2 - xcoOrdinate1, 2) + Math.Pow(ycoOrdinate2 - ycoOrdinate1, 2));
            return lineLength;
        }
        public double LineLength(Line_Values lineValues)
        {
            return Math.Sqrt(Math.Pow(lineValues.xcoOrdinate2 - lineValues.xcoOrdinate1, 2) + Math.Pow(lineValues.ycoOrdinate2 - lineValues.ycoOrdinate1, 2));
        }
        public int CompareLength(Line_Values lineValue1, Line_Values lineValue2)
        {
            if (LineLength(lineValue1) > LineLength(lineValue2))
                return 1;
            else if (LineLength(lineValue1) < LineLength(lineValue2))
                return -1;
            else 
                return 0;
        }
    }
}
