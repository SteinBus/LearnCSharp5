using System;

namespace LearnCSharp5
{
    class Ellipse
    {
        public Point CenterPoint { get; private set; }
        public int XAxis { get; private set; }
        public int YAxis { get; private set; }
        public Ellipse(Point centerPoint, int xAxis, int yAxis)
        {
            if (xAxis < 0)
            {
                throw new ArgumentException($"X Axis can't be negative ({xAxis} was entered)");
            }
            if (yAxis < 0)
            {
                throw new ArgumentException($"Y Axis can't be negative ({yAxis} was entered)");
            }
            CenterPoint = centerPoint;
            XAxis = xAxis;
            YAxis = yAxis;
        }
        public double GetPerimeter()
        {
            double formulaTop = Math.PI * XAxis * YAxis + (XAxis - YAxis) * (XAxis - YAxis);
            return 4 * formulaTop / (XAxis + YAxis);
        }
        public double GetSquare()
        {
            return Math.PI * XAxis * YAxis;
        }
    }
}
