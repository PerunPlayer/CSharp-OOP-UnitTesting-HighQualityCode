using System;
using HighQualityClasses.Models;

namespace HighQualityClasses
{
    public class Startup
    {
        public static void Main()
        {
            var circleRadius = 7.5;
            var circle = new Circle(circleRadius);

            Console.WriteLine(circle);

            var rectangleWidth = 15;
            var rectangleHeight = 18.1;
            var rectangle = new Rectangle(rectangleWidth, rectangleHeight);

            Console.WriteLine(rectangle);
        }
    }
}
