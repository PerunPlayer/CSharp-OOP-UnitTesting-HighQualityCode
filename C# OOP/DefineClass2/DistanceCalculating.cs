namespace _3D
{
    using System;

    static class DistanceCalculating
    {
        public static double Calculating(Point3D point1, Point3D point2)
        {
            double distance = Math.Sqrt(
               ((point1.X - point2.X) * (point1.X - point2.X)) +
               ((point1.Y - point2.Y) * (point1.Y - point2.Y)) +
               ((point1.Z - point2.Z) * (point1.Z - point2.Z)));
            return distance;
        }
    }
}
