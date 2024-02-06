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
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.pictureBox1, "Вы попали в кроличью нору");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.ImageLocation = folderBrowserDialog1.SelectedPath;
        }
    }
}
