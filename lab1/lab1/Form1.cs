using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public class myClass
    {
        private int _value = 10;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imperor.Text = Properties.Resources.String_imperatora;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x1, x2;
            x1 = double.Parse(X1_box.Text);
            x2 = double.Parse(X2_box.Text);
            chart1.Series.Add("Function");
            chart1.Series["Function"].SetDefault(true);
            double h = 0.1;
            for (int i = 0; i < 100; ++i)
            {
                chart1.Series["Function"].Points.AddXY(x1, function(x1, x2));
                x1 += h;
            }

        }

        private double function(double x1, double x2)
        {
            return x2 + Math.Sin(x1)*100;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 side = new Form2();
            side.Show();
        }


    }
}
