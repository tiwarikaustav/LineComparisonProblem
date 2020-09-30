using System;
using System.Numerics;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = RandNum(), y1 = RandNum();
            int x2 = RandNum(), y2 = RandNum();
            Console.WriteLine("Coordinates of End Point One: ({0}, {0})", x1, y1);
            Console.WriteLine("Coordinates of End Point Two: ({0}, {0})", x2, y2);
            Console.WriteLine("Length of Line Segment is: {0}", DistanceFormula2D(x1, y1, x2, y2));
        }

        // Calculates distance between 2 points in 2-d cartesian plane
        static double DistanceFormula2D(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        //Generates random number between 1 and 99
        static int RandNum()
        {
            Random randObj = new Random();
            return randObj.Next(1, 100);
        }
    }
}
