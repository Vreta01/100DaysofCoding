using System;
using System.Drawing;

namespace Polygons;

class Program
{
    static void Main(string[] args)
    {
        //CustomSquare sq1 = new CustomSquare(3);
        CustomRectangle rect1 = new CustomRectangle(5, 5);
        CustomSquare sqr2 = new CustomSquare(10);

        IPolygon[] polygons = new IPolygon[4];
        polygons[0] = rect1;
        polygons[1] = new CustomSquare(2);
        polygons[2] = sqr2;
        CustomSquare sqr1 = (CustomSquare)polygons[1];

        foreach (IPolygon polygon in polygons)
        {
            
            if (polygon != null)
            {
                Console.WriteLine($"This {polygon.Name} has {polygon.Sides} sides, an area of {polygon.Area}, and a perimeter of {polygon.Perimeter}.");
                
            }

        }
    }
}