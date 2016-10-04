namespace _3D
{
    using System.IO;

    public static class PathStorage
    {
        public static void Save(Path path, string pathIdentifier)
        {
            using (StreamWriter writer = new StreamWriter("..//..//path" + pathIdentifier + ".txt"))
            {

                for (int i = 0; i < path.PointsInSpace.Count; i++)
                {
                    writer.WriteLine(path.PointsInSpace[i]);
                }

            }
        }

        public static Path Load(string filePath)
        {
            Path path = new Path();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.EndOfStream == false)
                {
                    string nextPointTxt = reader.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.Add(nextPoint);
                }
            }
            return path;
        }
    }
}
