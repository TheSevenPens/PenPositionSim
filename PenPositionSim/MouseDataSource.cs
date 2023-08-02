namespace PenPositionSim
{

    public class MouseDataSource
    {
        // this class handles getting the mouse position
        // and can also add some latency
        // latency expressed in terms of number of reports to queue up

        int posqueue_size = 5;
        Queue<Point> queue;

        public Latency Latency = Latency.Low;

        public MouseDataSource()
        {
            this.queue = new Queue<Point>(this.posqueue_size);
        }

        public Point GetMousePosition(Control ctrl)
        {
            // if low latency just return the current mouse position
            if (this.Latency == Latency.Low)
            {
                return GetMousePositionRaw(ctrl);
            }

            // in the high latency case, queue a few reports to create 
            // the delay. return a fake value for until there is enough
            // in the queue

            queue.Enqueue(GetMousePositionRaw(ctrl));

            if (queue.Count<this.posqueue_size) 
            {
                return Point.Empty;
            }

            // Once the queue is big enough, then start
            // reporting from the quque

            var p = queue.Dequeue();
            return p;
        }

        private static Point GetMousePositionRaw(Control ctrl)
        {
            return ctrl.PointToClient(Control.MousePosition);
        }

        public void ClearQueue()
        {
            this.queue = new Queue<Point>(this.posqueue_size);
        }
    }

}