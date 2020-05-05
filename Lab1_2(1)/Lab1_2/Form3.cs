using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2
{
    public partial class Form3 : Form
    {
        Form2 form2Ref;
        public Form3(Form2 form2Ref)
        {
            this.form2Ref = form2Ref;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2Ref.Close();
            Close();
        }
    }
}
