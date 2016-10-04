namespace _3D
{
    using System.Collections.Generic;

    class Path
    {
        private List<Point3D> pointsInSpace;

        public Path()
        {
            this.pointsInSpace = new List<Point3D>();
        }

        public List<Point3D> PointsInSpace
        {
            get
            {
                return this.pointsInSpace;
            }
            set
            {
                this.pointsInSpace = value;
            }
        }

        public void Add(Point3D point)
        {
            this.pointsInSpace.Add(point);
        }

        public void Delete(Point3D point)
        {
            this.pointsInSpace.Remove(point);
        }
    }
}
