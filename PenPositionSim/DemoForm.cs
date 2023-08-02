using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace PenPositionSim
{
    public partial class DemoForm : Form
    {
        private MouseDataSource mds = new MouseDataSource();

        private bool isDrawing;

        EMASmoother smoother;
        private PointD reported_pos_prev;
        private PointD reported_pos_cur;
        private PointD smoothed_pos_prev;

        private Pen reported_pen;
        private Pen smoothed_pen;
        private Brush smoothedbrush;

        private System.Windows.Forms.Timer report_rate_timer;

        public DemoForm()
        {
            InitializeComponent();
            InitializeDrawing();

            this.smoother = new EMASmoother(0.0);

            this.report_rate_timer = new System.Windows.Forms.Timer();
            this.report_rate_timer.Interval = (int)ReportRateInterval.High;
            this.report_rate_timer.Tick += Timer_Tick;

            this.reported_pen = new Pen(Color.Black, 3);
            this.reported_pen.StartCap = this.reported_pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            this.smoothedbrush = new SolidBrush(Color.Red);
            this.smoothed_pen = new Pen(this.smoothedbrush, 5);
            this.smoothed_pen.StartCap = this.smoothed_pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            this.UpdateAlphaVal();

        }


        private void update_reported_pos()
        {
            var mp = this.mds.GetMousePosition(this);
            reported_pos_cur = Util.add(new PointD(mp), -inkCanvas.Left, -inkCanvas.Top);
        }


        private void Timer_Tick(object? sender, EventArgs e)
        {
            this.update_reported_pos();

            var rect_size = new Size(3, 3);

            this.smoother.Alpha = GetSmoothingAlpha();

            var smoothed_pos_cur = this.smoother.Smooth(reported_pos_cur);

            var reported_rect = new Rectangle(reported_pos_cur.ToPointRounded(), rect_size);
            var smoothed_rect = new Rectangle(smoothed_pos_cur.ToPointRounded(), rect_size);

            if (isDrawing)
            {
                using (Graphics g = inkCanvas.CreateGraphics())
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    if (this.checkBox_connect_points.Checked)
                    {
                        if (this.checkBox_show_reportedposition.Checked)
                        {
                            g.DrawLine(reported_pen, reported_pos_prev.ToPointRounded(), reported_pos_cur.ToPointRounded());
                        }

                        if (this.checkBox1_show_processedposition.Checked)
                        {
                            g.DrawLine(smoothed_pen, smoothed_pos_prev.ToPointRounded(), smoothed_pos_cur.ToPointRounded());
                        }
                    }
                    else
                    {
                        if (this.checkBox_show_reportedposition.Checked)
                        {
                            g.DrawEllipse(reported_pen, reported_rect);
                        }

                        if (this.checkBox1_show_processedposition.Checked)
                        {
                            g.DrawEllipse(smoothed_pen, smoothed_rect);
                        }
                    }
                }
            }

            smoothed_pos_prev = smoothed_pos_cur;
            reported_pos_prev = reported_pos_cur;
        }

        private double GetSmoothingAlpha()
        {
            return this.trackBar_alpha.Value / (double)100;
        }

        private void InitializeDrawing()
        {
            isDrawing = false;
        }

        private void inkCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                reported_pos_prev = reported_pos_cur;
                smoothed_pos_prev = reported_pos_cur;
                this.smoother.SetOldSmoothed(reported_pos_cur);
                return;
            }

            if (e.Button == MouseButtons.Right)
            {
                this.EraseCanvas();
                return;
            }
        }

        private void inkCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                return;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            EraseCanvas();
        }

        private void EraseCanvas()
        {
            using (Graphics g = inkCanvas.CreateGraphics())
            {
                using (var b = new SolidBrush(System.Drawing.Color.White))
                {
                    g.FillRectangle(b, 0, 0, inkCanvas.Width, inkCanvas.Height);

                }

            }
        }

        private void trackBar_Alpha_Scroll(object sender, EventArgs e)
        {
            UpdateAlphaVal();
        }

        private void UpdateAlphaVal()
        {
            this.label_alphavalue.Text = (this.trackBar_alpha.Value / (double)100).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetupPenCursorForCanvas();
            this.report_rate_timer.Start();
        }

        private void SetupPenCursorForCanvas()
        {
            int width = 256;
            int height = 256;
            using (Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.Transparent);

                    using (Pen pen = new Pen(Color.Blue, 4))
                    using (Brush brush = new SolidBrush(Color.Yellow))
                    {
                        int centerx = width / 2 + 10;
                        int centery = height / 2 - 10;
                        int delta = 10;

                        var center = new Point(centerx, centery);
                        var p1 = new Point(width - 1 - delta, 0);
                        var p2 = new Point(width - 1, 0 + delta);


                        var trianglePoints = new Point[]
                        {
                            center,   // Top point
                            p1,   // Bottom-left point
                            p2,  // Bottom-right point
                        };

                        graphics.FillPolygon(brush, trianglePoints);
                        graphics.DrawPolygon(pen, trianglePoints);
                    }
                }


                PictureBox pb = new PictureBox() { Image = bitmap };
                var frm = this.inkCanvas;
                frm.Cursor = new Cursor(((Bitmap)pb.Image).GetHicon());
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void radioButton_ReportRateLow_CheckedChanged(object sender, EventArgs e)
        {
            if (this.report_rate_timer != null)
            {
                this.report_rate_timer.Interval = (int)ReportRateInterval.Low;
            }
        }

        private void radioButton_ReportRateHigh_CheckedChanged(object sender, EventArgs e)
        {
            if (this.report_rate_timer != null)
            {
                this.report_rate_timer.Interval = (int)ReportRateInterval.Medium;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.report_rate_timer != null)
            {
                this.report_rate_timer.Interval = (int)ReportRateInterval.High;
            }

        }


        private void radioButton_LowLatency_CheckedChanged(object sender, EventArgs e)
        {
            this.mds.Latency = Latency.Low;
        }

        private void radioButton_highlatency_CheckedChanged(object sender, EventArgs e)
        {
            this.mds.Latency = Latency.High;

        }
    }

}