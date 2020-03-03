using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphDrawing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            points = new List<int>();
        }

        private const int pointsCount = 1024;
        private const string filePath = "sin.txt";

        int XMouseDown, YMouseDown, XMouse, YMouse, XOld;
        private bool OffOn = false;

        public static List<int> points;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            OffOn = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            pointsLimitCheckBox.Checked = false;
            points.Clear();
            XMouseDown = 0;
            YMouseDown = 0;
            XMouse = 0;
            YMouse = 0;
            XOld = 0;
            pointsCountLabel.Text = "0";
        }

        private void savePointsButton_Click(object sender, EventArgs e)
        {
            //TODO
            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                foreach (var point in points)
                {
                    sw.WriteLine(point.ToString()+"[\\n]");
                }
            }
        }

     

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            XMouse = e.X;
            YMouse = e.Y;

            Pen myPen = new Pen(Color.Red,3);

            if (OffOn)
            {
                g.DrawLine(myPen,XMouseDown,YMouseDown,XMouse,YMouse);

                XMouseDown = XMouse;
                YMouseDown = YMouse;

                if (points.Count < pointsCount)
                { 
                    if (XMouseDown > XOld)
                    {
                        points.Add(400-YMouseDown);
                        XOld = XMouseDown;
                        pointsCountLabel.Text = points.Count.ToString();
                    }

                }
                else
                {
                    pointsLimitCheckBox.Checked = true;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            XMouseDown = e.X;
            YMouseDown = e.Y;

            OffOn = true;
        }
    }
}
