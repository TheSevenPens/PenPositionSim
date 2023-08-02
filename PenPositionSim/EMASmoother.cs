namespace PenPositionSim
{
    public class EMASmoother
    {
        public double Alpha;
        private PointD? SmoothingOld;
        
        public EMASmoother(double alpha)
        {
            this.Alpha = alpha;
            this.SmoothingOld = null;
        }

        public PointD Smooth(PointD value)
        {
            PointD smoothed_new = this.SmoothingOld.HasValue ?
                EMASmoother.lerp(this.SmoothingOld.Value, value, this.Alpha)
                : value;
            this.SmoothingOld = smoothed_new;
            return smoothed_new;
        }

        private static PointD lerp(PointD oldval, PointD newval, double alpha)
        {
            double newx = (alpha * oldval.X) + ((1 - alpha) * newval.X);
            double newy = (alpha * oldval.Y) + ((1 - alpha) * newval.Y);
            var p = new PointD(newx, newy);
            return p;
        }
    }
}