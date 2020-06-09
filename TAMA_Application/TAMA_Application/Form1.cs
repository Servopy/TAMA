using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAMA_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics graphics;
        Brush brush;
        Pen kalem;

        int count = 0;
        int[] konumX = new int[10];
        int[] konumZ = new int[10];

        Point lastPoint;

        private void MapButton_Click(object sender, EventArgs e)
        {
            StreamPanel.Visible = false;
            SensorPanel.Visible = false;
            MapPanel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = MapPictureBox.CreateGraphics();
            brush = new SolidBrush(Color.Red);
            kalem = new Pen(brush, 2);
            StreamPanel.Visible = false;
            MapPanel.Visible = false;
            SensorPanel.Visible = true;
        }

        private void SendLocationButton_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Red);
            kalem = new Pen(brush, 4);
            konumX[count] = Convert.ToInt32(textBox1.Text);
            konumZ[count] = Convert.ToInt32(textBox2.Text);
            lastPoint = new Point(konumX[count], konumZ[count]);
            if (count > 0)
            {
                graphics.DrawLine(kalem, new Point(konumX[count - 1], konumZ[count - 1]), new Point(konumX[count], konumZ[count]));
            }
            else
            {
                graphics.DrawLine(kalem, new Point(konumX[count] - 3, konumZ[count] - 3), new Point(konumX[count], konumZ[count]));
            }
            count++;
        }

        private void SensorDataButton_Click(object sender, EventArgs e)
        {
            StreamPanel.Visible = false;
            MapPanel.Visible = false;
            SensorPanel.Visible = true;
        }

        private void SaveMapButton_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Blue);
            kalem = new Pen(brush, 10);
            graphics.DrawLine(kalem, new Point(lastPoint.X - 5, lastPoint.Y - 5), lastPoint);
        }

        private void PiCamButton_Click(object sender, EventArgs e)
        {
            MapPanel.Visible = false;
            SensorPanel.Visible = false;
            StreamPanel.Visible = true;
        }
    }
}
