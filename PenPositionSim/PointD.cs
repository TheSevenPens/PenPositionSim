namespace PenPositionSim
{
    public struct PointD
    {
        // simple point struct with x,y of datatype double

        public double X;
        public double Y;

        public static PointD Empty
        {
            get
            {
                return new PointD(0, 0);
            }
        }

        public PointD(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public PointD(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;
        }

        public Point ToPointRounded()
        {
            double rx = System.Math.Round(this.X);
            double ry = System.Math.Round(this.Y);
            var p = new Point((int)rx, (int)ry);
            return p;
        }
    }

}