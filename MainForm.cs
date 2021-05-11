using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Task0
{
    public partial class MainForm : Form
    {
        public struct RealTime
        {
            public static int hours;
            public static int minutes;
            public static int seconds;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void DoBtn_Click(object sender, EventArgs e)
        {
            bool isValueInteger = Int32.TryParse(deltaTimeField.Text, out int deltaTime);
            if (isValueInteger)
            {
                if (deltaTime < 0)
                {
                    errorMessage2.Text = "Entered value should be > 0!";
                }
                else
                {
                    errorMessage2.Text = "";
                    ChangeTime(deltaTime, units.SelectedIndex);
                }
            }
            else
            {
                errorMessage2.Text = "Invalid value of time!";
            }
        }

        private void SetTimeBtn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\d{2}:\d{2}:\d{2}");
            string strTime = setTimeField.Text;
            MatchCollection match = regex.Matches(strTime);

            if (match.Count > 0)
            {
                RealTime.hours = strTime[1] - 48 + (strTime[0] - 48) * 10;
                RealTime.minutes = strTime[4] - 48 + (strTime[3] - 48) * 10;
                RealTime.seconds = strTime[7] - 48 + (strTime[6] - 48) * 10;
                bool isTimeValid = true;
                if (RealTime.hours > 23 || RealTime.minutes > 59 || RealTime.seconds > 59)
                {
                    isTimeValid = false;
                }
                if (isTimeValid)
                {
                    errorMessage1.Text = "";
                    SetTime(RealTime.seconds, RealTime.minutes, RealTime.hours);
                }
                else
                {
                    errorMessage1.Text = "Invalid value of time!";
                }
            }
            else
            {
                errorMessage1.Text = "Invalid format of time!\nRequired - hh:mm:ss";
            }
        }
        // 0 - sec, 1 - min, 2 - hours
        readonly ArrowsPosition[] arrowsEndPos = { new ArrowsPosition(141, 21), new ArrowsPosition(141, 40), new ArrowsPosition(141, 60) };
        readonly int[] anglesOfRotation = new int[3];
        readonly int[] radius = { 120, 100, 80 }; 
        private void PaintArrows(object sender, PaintEventArgs e)
        {
            Pen[] MyPens = { new Pen(Color.Red, 4), new Pen(Color.Gray, 4), new Pen(Color.Black, 6) };

            Point rectangleLocation = new Point(Watch.Width / 2 - 7, Watch.Height / 2 - 7);
            Size rectangleSize = new Size(14, 14);
            Rectangle rectangle = new Rectangle(rectangleLocation, rectangleSize);

            for (int i = 0; i < 3; i++)
            {
                MyArrows.DrawArrow(MyPens[i], arrowsEndPos[i].X, arrowsEndPos[i].Y, e);
            }

            e.Graphics.FillEllipse(new SolidBrush(Color.Black), rectangle);
        }
        private void SetTime(int s, int m, int h)
        {
            int[] timeUnits = { 6 * s, 6 * m, 30 * h };

            for (int i = 0; i < 3; i++)
            {
                anglesOfRotation[i] = timeUnits[i] - 90;
                float cos = (float)Math.Cos(((Math.PI * anglesOfRotation[i]) / 180));
                float sin = (float)Math.Sin(((Math.PI * anglesOfRotation[i]) / 180));
                arrowsEndPos[i].X = Watch.Width / 2 + radius[i] * cos;
                arrowsEndPos[i].Y = Watch.Height / 2 + radius[i] * sin;
            }

            Watch.Refresh();
        }
        private void ChangeTime(int value, int kindOfArrow)
        {
            int h, m = 0, s = 0;

            if (kindOfArrow == 0)
            {
                h = value / 3600;
                m = (value - h * 3600) / 60;
                s = value - m * 60 - h * 3600;
            }
            else if (kindOfArrow == 1)
            {
                h = value / 60;
                m = value - h * 60;
            }
            else
            {
                h = value;
            }

            while (h >= 24)
            {
                h -= 24;
            }

            if (radioBtnBack.Checked)
            {
                h *= -1;
                m *= -1;
                s *= -1;
            }
            RealTime.hours += h;
            RealTime.minutes += m;
            RealTime.seconds += s;
            SetTime(RealTime.seconds, RealTime.minutes, RealTime.hours);
        }
    }
}
