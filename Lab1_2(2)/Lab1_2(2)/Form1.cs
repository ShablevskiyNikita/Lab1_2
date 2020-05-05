using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            //change eye o man
            for(int i=0; i< Controls.Count;i++)
            {
                if(Controls[i].GetType() == typeof(Label) && (Controls[i].Name == "LeftEye_label" || Controls[i].Name == "RightEye_label"))
                {
                    Controls[i].Text = "X";
                }
            }
            await Task.Delay(2000).ConfigureAwait(true);
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].GetType() == typeof(Label))
                {
                    Controls[i].Dispose();
                    i--;
                }
            }
        }

    }
}
