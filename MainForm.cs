using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System;

namespace FigureFormation
{
    public partial class MainForm : Form
    {
        private List<Point> points;
        private Color color;
        private Thread rotatingThread;

        public MainForm()
        {
            InitializeComponent();

            points = new List<Point>();
            color = Color.Black;
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        private void GetPoints()
        {
            points.Clear();

            var data = textBoxPoints.Lines;

            foreach (var str in data)
            {
                var split = str.Split(' ');
                points.Add(new Point(int.Parse(split[0]), int.Parse(split[1])));
            }
        }

        private void buttonLineColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                buttonLineColor.BackColor = color;
            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (rotatingThread != null)
            {
                rotatingThread.Abort();
                rotatingThread = null;
            }

            var figures = new Figures((Bitmap)pictureBox.Image, color);

            GetPoints();

            if (!checkBoxCircle.Checked)
            {
                if (points.Count == 1) figures.DrawPixel(points[0].X, points[0].Y);
                else
                {
                    for (var i = 0; i < points.Count - 1; ++i)
                    {
                        figures.DrawLine(points[i], points[i + 1]);
                    }

                    if (points.Count > 2)
                    {
                        figures.DrawLine(points[0], points[points.Count - 1]);
                    }
                }
            }

            if (!checkBoxEllipse.Checked)
            {
                figures.DrawCircle(points[0], (int)numericUpDownCircle.Value);
            }
            else
            {
                figures.DrawEllipse(points[0], (int)numericUpDownCircle.Value, (int)numericUpDownEllipse.Value);
            }

            if (checkBoxRotate.Checked)
            {
                var rotateLines = new RotateLines(
                    this,
                    figures,
                    points[0],
                    points[1].X,
                    points[1].Y,
                    (int)numericUpDownLength1.Value,
                    (int)numericUpDownVelocity1.Value,
                    checkBoxClockwise1.Checked,
                    (int)numericUpDownLength2.Value,
                    (int)numericUpDownVelocity2.Value,
                    checkBoxClockwise2.Checked);

                rotatingThread = new Thread(rotateLines.Run);
                rotatingThread.Start();
            }

            pictureBox.Image = figures.CurrentBitmap;
        }

        private void checkBoxCircle_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownCircle.Enabled = checkBoxCircle.Checked;
            checkBoxEllipse.Enabled = checkBoxCircle.Checked;
            checkBoxEllipse.Checked = checkBoxCircle.Checked;
            checkBoxRotate.Enabled = !checkBoxCircle.Checked;
        }

        private void checkBoxEllipse_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownEllipse.Enabled = checkBoxEllipse.Checked;
        }

        private void checkBoxRotate_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownLength1.Enabled = checkBoxRotate.Checked;
            numericUpDownVelocity1.Enabled = checkBoxRotate.Checked;
            checkBoxClockwise1.Enabled = checkBoxRotate.Checked;
            numericUpDownLength2.Enabled = checkBoxRotate.Checked;
            numericUpDownVelocity2.Enabled = checkBoxRotate.Checked;
            checkBoxClockwise2.Enabled = checkBoxRotate.Checked;
        }

        public void SetBitmap(Bitmap bitmap)
        {
            pictureBox.Invoke(new Action(() => pictureBox.Image = bitmap));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            rotatingThread?.Abort();
        }
    }
}
