using System;

namespace LearnCSharp5
{
    class Rectangle
    {
        public Point LeftTopPoint { get; private set; }
        public Point RightBottomPoint { get; private set; }

        public Rectangle(Point leftTopPoint, Point rightBottomPoint)
        {
            if (leftTopPoint.Y < rightBottomPoint.Y)
            {
                throw new ArgumentException("Bottom point is higher than top point");
            }
            if (leftTopPoint.X > rightBottomPoint.X)
            {
                throw new ArgumentException("left point is further right than right point");
            }
            LeftTopPoint = leftTopPoint;
            RightBottomPoint = rightBottomPoint;
        }
        public int GetSquare()
        {
            int height = LeftTopPoint.Y - RightBottomPoint.Y;
            int width = RightBottomPoint.X - LeftTopPoint.X;
            return height * width;
        }
    }
}
