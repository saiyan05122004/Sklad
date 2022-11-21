using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnePlace
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = DataBank.a;
            label3.Text = DataBank.b;
            label4.Text = DataBank.c;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
          

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
