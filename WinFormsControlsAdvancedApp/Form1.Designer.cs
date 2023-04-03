namespace WinFormsControlsAdvancedApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            trackBar100 = new TrackBar();
            txtTrackValue = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            btnStop = new Button();
            progressValue = new ProgressBar();
            dateTimePicker1 = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)trackBar100).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // trackBar100
            // 
            trackBar100.Location = new Point(12, 12);
            trackBar100.Maximum = 255;
            trackBar100.Name = "trackBar100";
            trackBar100.Size = new Size(247, 45);
            trackBar100.TabIndex = 0;
            trackBar100.TickFrequency = 10;
            trackBar100.TickStyle = TickStyle.Both;
            trackBar100.Value = 50;
            trackBar100.Scroll += trackBar1_Scroll;
            // 
            // txtTrackValue
            // 
            txtTrackValue.Enabled = false;
            txtTrackValue.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtTrackValue.Location = new Point(286, 12);
            txtTrackValue.Name = "txtTrackValue";
            txtTrackValue.Size = new Size(100, 36);
            txtTrackValue.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(35, 92);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(146, 92);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // progressValue
            // 
            progressValue.Location = new Point(12, 148);
            progressValue.Name = "progressValue";
            progressValue.Size = new Size(247, 23);
            progressValue.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(371, 148);
            dateTimePicker1.MaxDate = new DateTime(2023, 9, 1, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.AnnuallyBoldedDates = (new DateTime[] { new DateTime(2023, 4, 1, 0, 0, 0, 0) });
            monthCalendar1.Location = new Point(593, 148);
            monthCalendar1.MaxSelectionCount = 20;
            monthCalendar1.MonthlyBoldedDates = (new DateTime[] { new DateTime(2023, 4, 5, 0, 0, 0, 0) });
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 489);
            Controls.Add(pictureBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(progressValue);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(txtTrackValue);
            Controls.Add(trackBar100);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar100).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar100;
        private TextBox txtTrackValue;
        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
        private Button btnStop;
        private ProgressBar progressValue;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox1;
    }
}