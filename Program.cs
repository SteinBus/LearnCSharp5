using LearnCSharp5;
using System;


class Program
{
    static void Main(string[] args)
    {
        Point centerPoint = new Point
        {
            X = 10,
            Y = 10
        };
        int xAxis = 4;
        int yAxis = 2;
        try
        {
            Ellipse ellipse = new Ellipse(centerPoint, xAxis, yAxis);
            Console.WriteLine($"{ellipse.CenterPoint}, a:{ellipse.XAxis}, b:{ellipse.YAxis}");
            double area = ellipse.GetSquare();
            double perimeter = ellipse.GetPerimeter();
            Console.WriteLine($"Area:{area:f}, Perimeter:{perimeter:f}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}