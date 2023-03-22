using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPM_Denisov_13_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Clear(int Ox, int Oy)
        {
            Graphics GR = pictureBox1.CreateGraphics();
            GR.Clear(Color.White);
            GR.DrawLine(new Pen(Brushes.Black,2), 500, 0, 500, 500);
            GR.DrawLine(new Pen(Brushes.Black, 2), 0, 250, 1000, 250);

            int drawX = -10;
            for (int x = 0; x <= 1100; x += 50)
            {
                GR.DrawLine(new Pen(Brushes.Black, 1), x, 235, x, 265);
                GR.DrawString($"{drawX++ + Ox}", new Font("Microsoft Sans Serif", 14), Brushes.Black, x, 230);
            }
            int drawY = 5;
            for (int y = 0; y <= 500; y += 50)
            {
                GR.DrawLine(new Pen(Brushes.Black, 1), 485, y, 515, y);
                GR.DrawString($"{drawY-- + Oy}", new Font("Microsoft Sans Serif", 14), Brushes.Black, 500, y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int Ox);
            int.TryParse(textBox2.Text, out int Oy);

            pictureBox1_Clear(Ox, Oy);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        



        void GraphCalculate(long A, long B, long C)
        {
            double x;
            double y;




        }
    }
}
