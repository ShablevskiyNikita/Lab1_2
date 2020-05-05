using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(Color.Red);
            listBox1.Items.Add(Color.Yellow);
            listBox1.Items.Add(Color.Blue);
            pictureBox1.BackColor = Color.Green;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < listBox1.Items.Count)
            {
                pictureBox1.BackColor = (Color)listBox1.SelectedItem;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
        }
    }
}
