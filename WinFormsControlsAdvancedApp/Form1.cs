namespace WinFormsControlsAdvancedApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTrackValue.Text = trackBar100.Value.ToString();
            monthCalendar1.SelectionStart = new DateTime(2023, 4, 2);
            monthCalendar1.SelectionEnd = new DateTime(2023, 4, 12);

            pictureBox1.Image = Image.FromFile(@"D:\img01.png");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtTrackValue.Text = trackBar100.Value.ToString();
            Color color = Color.FromArgb(trackBar100.Value, trackBar100.Value, trackBar100.Value);

            this.BackColor = color;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Random random = new Random();

            //this.BackColor = Color.FromArgb((byte)random.Next(0, 255),
            //                                (byte)random.Next(0, 255),
            //                                (byte)random.Next(0, 255));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            progressValue.Maximum = trackBar100.Value;
            for (int i = 0; i <= progressValue.Maximum; i++)
            {
                progressValue.Value = i;
                Thread.Sleep(50);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string message = monthCalendar1.SelectionStart.ToLongDateString()
                            + " " + monthCalendar1.SelectionEnd.ToLongDateString();
            MessageBox.Show(message);
        }
    }
}