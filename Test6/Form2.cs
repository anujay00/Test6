using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Test6
{
    public partial class Form2 : Form
    {
        public Form2(String name)
        {
            InitializeComponent();
            greeting_lbl.Text = "Welcome " + name;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        public void greeting_lbl_Click(object sender, EventArgs e)
        {
            
        }
    }
}
