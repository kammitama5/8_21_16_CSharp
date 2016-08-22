using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pyth
{
    class Pyth
    {
        /// <summary>
        /// Print Welcome Message
        /// </summary>
        /// <param name="args">command-line</param>
        static void Main(string[] args)
        {

            //Print Welcome message
            Console.WriteLine("Welcome to this application!");
            Console.WriteLine("This application will: ");
            Console.WriteLine("1)Calculate the distance between two points.");
            Console.WriteLine("2)The angle Between those two points. ");
            Console.WriteLine();

            //Ask for the values of x1 and y1 for first point
            Console.WriteLine("Please enter the value of x1 for the first point");
            double pointx1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of y1 for the first point");
            double pointy1 = double.Parse(Console.ReadLine());

            //Ask for the values of x2 and y2 for second point
            Console.WriteLine("Please enter the value of x2 for the first point");
            double pointx2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of y2 for the first point");
            double pointy2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            //Calculate distance between two pionts
            double xdist = Math.Abs(pointx2 - pointx1);
            double ydist = Math.Abs(pointy2);

            //Calculate Hypotenuse using Pythagorean's theorem
            double Pyth = Math.Sqrt((Math.Pow(xdist, 2)) + (Math.Pow(ydist, 2)));

            //Calculate the delta between the two points (in degrees, not radians)
            //double angle = (ydist / Pyth);
            //Sin inverse
            //double sinangle = Math.Asin(angle);
            //double degrees = (sinangle * 180) / Math.PI;
            double deltaY = pointy2 - pointy1;
            double deltaX = pointx2 - pointx1;
            double degrees = (Math.Atan2(deltaY, deltaX) * 180.00 / Math.PI);

            //Print out the message of angle in degrees and distance to 3 decimal places
            Console.WriteLine("The angle between the two points is " + String.Format("{0:0.00}",(Math.Round(degrees , 3))));

            Console.WriteLine("The distance between the two points ie Hypotenuse is " + Math.Round(Pyth, 3));
        }
    }
}

