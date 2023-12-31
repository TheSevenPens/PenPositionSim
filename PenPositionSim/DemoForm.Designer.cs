﻿namespace PenPositionSim
{
    partial class DemoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inkCanvas = new Panel();
            buttonClear = new Button();
            trackBar_alpha = new TrackBar();
            label_alpha = new Label();
            label_alphavalue = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton_ReportRateHigh = new RadioButton();
            radioButton_ReportRateLow = new RadioButton();
            checkBox1_show_smoothededposition = new CheckBox();
            checkBox_show_reportedposition = new CheckBox();
            label4 = new Label();
            radioButton_highlatency = new RadioButton();
            radioButton_LowLatency = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            checkBox_markpositions = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trackBar_alpha).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // inkCanvas
            // 
            inkCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inkCanvas.BackColor = Color.White;
            inkCanvas.Location = new Point(12, 12);
            inkCanvas.Name = "inkCanvas";
            inkCanvas.Size = new Size(1222, 968);
            inkCanvas.TabIndex = 0;
            inkCanvas.MouseDown += inkCanvas_MouseDown;
            inkCanvas.MouseUp += inkCanvas_MouseUp;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClear.Location = new Point(1423, 922);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(453, 58);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Erase canvas (right-click)";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // trackBar_alpha
            // 
            trackBar_alpha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trackBar_alpha.AutoSize = false;
            trackBar_alpha.Location = new Point(1384, 416);
            trackBar_alpha.Maximum = 100;
            trackBar_alpha.Name = "trackBar_alpha";
            trackBar_alpha.Size = new Size(381, 61);
            trackBar_alpha.TabIndex = 3;
            trackBar_alpha.TickFrequency = 5;
            trackBar_alpha.TickStyle = TickStyle.TopLeft;
            trackBar_alpha.Scroll += trackBar_Alpha_Scroll;
            // 
            // label_alpha
            // 
            label_alpha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_alpha.AutoSize = true;
            label_alpha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_alpha.Location = new Point(1267, 425);
            label_alpha.Name = "label_alpha";
            label_alpha.Size = new Size(101, 41);
            label_alpha.TabIndex = 4;
            label_alpha.Text = "Alpha";
            // 
            // label_alphavalue
            // 
            label_alphavalue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_alphavalue.AutoSize = true;
            label_alphavalue.Location = new Point(1794, 425);
            label_alphavalue.Name = "label_alphavalue";
            label_alphavalue.Size = new Size(78, 41);
            label_alphavalue.TabIndex = 5;
            label_alphavalue.Text = "UNK";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1261, 363);
            label1.Name = "label1";
            label1.Size = new Size(435, 50);
            label1.TabIndex = 6;
            label1.Text = "POSITION SMOOTHING";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1263, 530);
            label2.Name = "label2";
            label2.Size = new Size(185, 50);
            label2.TabIndex = 7;
            label2.Text = "OPTIONS";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1584, 55);
            label3.Name = "label3";
            label3.Size = new Size(181, 50);
            label3.TabIndex = 8;
            label3.Text = "LATENCY";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(34, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(216, 45);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "High (good)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton_ReportRateHigh
            // 
            radioButton_ReportRateHigh.AutoSize = true;
            radioButton_ReportRateHigh.Location = new Point(34, 85);
            radioButton_ReportRateHigh.Name = "radioButton_ReportRateHigh";
            radioButton_ReportRateHigh.Size = new Size(116, 45);
            radioButton_ReportRateHigh.TabIndex = 1;
            radioButton_ReportRateHigh.Text = "Med";
            radioButton_ReportRateHigh.UseVisualStyleBackColor = true;
            radioButton_ReportRateHigh.CheckedChanged += radioButton_ReportRateHigh_CheckedChanged;
            // 
            // radioButton_ReportRateLow
            // 
            radioButton_ReportRateLow.AutoSize = true;
            radioButton_ReportRateLow.Location = new Point(34, 136);
            radioButton_ReportRateLow.Name = "radioButton_ReportRateLow";
            radioButton_ReportRateLow.Size = new Size(109, 45);
            radioButton_ReportRateLow.TabIndex = 0;
            radioButton_ReportRateLow.Text = "Low";
            radioButton_ReportRateLow.UseVisualStyleBackColor = true;
            radioButton_ReportRateLow.CheckedChanged += radioButton_ReportRateLow_CheckedChanged;
            // 
            // checkBox1_show_smoothededposition
            // 
            checkBox1_show_smoothededposition.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1_show_smoothededposition.AutoSize = true;
            checkBox1_show_smoothededposition.Location = new Point(1278, 715);
            checkBox1_show_smoothededposition.Name = "checkBox1_show_smoothededposition";
            checkBox1_show_smoothededposition.Size = new Size(459, 45);
            checkBox1_show_smoothededposition.TabIndex = 13;
            checkBox1_show_smoothededposition.Text = "Show smoothed position (red)";
            checkBox1_show_smoothededposition.UseVisualStyleBackColor = true;
            // 
            // checkBox_show_reportedposition
            // 
            checkBox_show_reportedposition.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox_show_reportedposition.AutoSize = true;
            checkBox_show_reportedposition.Checked = true;
            checkBox_show_reportedposition.CheckState = CheckState.Checked;
            checkBox_show_reportedposition.Location = new Point(1278, 652);
            checkBox_show_reportedposition.Name = "checkBox_show_reportedposition";
            checkBox_show_reportedposition.Size = new Size(464, 45);
            checkBox_show_reportedposition.TabIndex = 14;
            checkBox_show_reportedposition.Text = "Show reported position (black)";
            checkBox_show_reportedposition.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1261, 55);
            label4.Name = "label4";
            label4.Size = new Size(261, 50);
            label4.TabIndex = 16;
            label4.Text = "REPORT RATE";
            // 
            // radioButton_highlatency
            // 
            radioButton_highlatency.AutoSize = true;
            radioButton_highlatency.Location = new Point(43, 34);
            radioButton_highlatency.Name = "radioButton_highlatency";
            radioButton_highlatency.Size = new Size(118, 45);
            radioButton_highlatency.TabIndex = 1;
            radioButton_highlatency.Text = "High";
            radioButton_highlatency.UseVisualStyleBackColor = true;
            radioButton_highlatency.CheckedChanged += radioButton_highlatency_CheckedChanged;
            // 
            // radioButton_LowLatency
            // 
            radioButton_LowLatency.AutoSize = true;
            radioButton_LowLatency.Checked = true;
            radioButton_LowLatency.Location = new Point(41, 90);
            radioButton_LowLatency.Name = "radioButton_LowLatency";
            radioButton_LowLatency.Size = new Size(207, 45);
            radioButton_LowLatency.TabIndex = 0;
            radioButton_LowLatency.TabStop = true;
            radioButton_LowLatency.Text = "Low (good)";
            radioButton_LowLatency.UseVisualStyleBackColor = true;
            radioButton_LowLatency.CheckedChanged += radioButton_LowLatency_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton_ReportRateHigh);
            panel1.Controls.Add(radioButton_ReportRateLow);
            panel1.Location = new Point(1267, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 228);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(radioButton_highlatency);
            panel2.Controls.Add(radioButton_LowLatency);
            panel2.Location = new Point(1595, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 228);
            panel2.TabIndex = 19;
            // 
            // checkBox_markpositions
            // 
            checkBox_markpositions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox_markpositions.AutoSize = true;
            checkBox_markpositions.Checked = true;
            checkBox_markpositions.CheckState = CheckState.Checked;
            checkBox_markpositions.Location = new Point(1278, 592);
            checkBox_markpositions.Name = "checkBox_markpositions";
            checkBox_markpositions.Size = new Size(252, 45);
            checkBox_markpositions.TabIndex = 20;
            checkBox_markpositions.Text = "Mark positions";
            checkBox_markpositions.UseVisualStyleBackColor = true;
            // 
            // DemoForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1888, 992);
            Controls.Add(checkBox_markpositions);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(trackBar_alpha);
            Controls.Add(label4);
            Controls.Add(label_alpha);
            Controls.Add(label_alphavalue);
            Controls.Add(checkBox_show_reportedposition);
            Controls.Add(checkBox1_show_smoothededposition);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonClear);
            Controls.Add(inkCanvas);
            MinimumSize = new Size(800, 800);
            Name = "DemoForm";
            Text = "Pen Position Simulator";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Resize += DemoForm_Resize;
            ((System.ComponentModel.ISupportInitialize)trackBar_alpha).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel inkCanvas;
        private Button buttonClear;
        private TrackBar trackBar_alpha;
        private Label label_alpha;
        private Label label_alphavalue;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioButton_ReportRateHigh;
        private RadioButton radioButton_ReportRateLow;
        private CheckBox checkBox1_show_smoothededposition;
        private CheckBox checkBox_show_reportedposition;
        private RadioButton radioButton1;
        private Label label4;
        private RadioButton radioButton_LowLatency;
        private RadioButton radioButton_highlatency;
        private Panel panel1;
        private Panel panel2;
        private CheckBox checkBox_markpositions;
    }
}