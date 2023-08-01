namespace PenPositionSim
{
    public enum ReportRateInterval
    {
        // this isn't really the report rate
        // it's the number of ticks to wait before polling the mouse position
        // that's why the high report rate is the smallest number
        High = 5,
        Medium = 50,
        Low =100
    }

}