﻿namespace PenPositionSim
{
    public static class Util
    {
        public static double clamp(double v, double lower, double upper)
        {
            double nv = System.Math.Max(v, 0.0);
            nv = System.Math.Min(nv, 1.0);
            return nv;
        }
        public static double lerp(double a, double b, double alpha)
        {
            alpha = Util.clamp(alpha, 0.0, 1.0);
            double ac = a * (1.0 - alpha);
            double bc = b * alpha;
            return (ac + bc);
        }


        public static PointD lerp(PointD a, PointD b, double alpha)
        {
            double x = lerp(a.X, b.X, alpha);
            double y = lerp(a.Y, b.Y, alpha);
            return new PointD(x, y);
        }

        public static PointD add(PointD p, int x, int y)
        {
            return new PointD(p.X + x, p.Y + y);
        }


        public static Point subtract(Point p, int x, int y)
        {
            return new Point(p.X - x, p.Y - y);
        }
        public static PointD subtract(PointD p, int x, int y)
        {
            return new PointD(p.X - x, p.Y - y);
        }

        public static PointD subtract(PointD p, double x, double y)
        {
            return new PointD(p.X - x, p.Y - y);
        }
        public static PointD subtract(PointD p1, PointD p2)
        {
            return subtract(p1, p2.X, p2.Y);
        }
        public static string pointd_to_string(PointD p)
        {
            return string.Format("{0}x{1}", p.X, p.Y);
        }

    }

}