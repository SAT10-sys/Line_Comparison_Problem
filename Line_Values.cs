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
    }
}
