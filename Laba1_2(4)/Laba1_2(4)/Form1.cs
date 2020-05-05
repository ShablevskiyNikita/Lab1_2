using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1_2_4_
{
    public partial class Form1 : Form
    {
        int labelsNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label newLabel = new Label();
            labelsNumber++;
            newLabel.Name = $"{labelsNumber}";
            newLabel.Text = "Label" + labelsNumber;
            newLabel.Font = new Font("Arial", 15, FontStyle.Regular);
            newLabel.Location = new Point(40, 20 + labelsNumber * 30);
            newLabel.MouseClick += new MouseEventHandler(handleClick);

            Controls.Add(newLabel);
        }

        public void handleClick(object sender,EventArgs e)
        {
            Label clicked = (Label)sender;
            lastClicked_label.Text = clicked.Name;
        }
    }
}
