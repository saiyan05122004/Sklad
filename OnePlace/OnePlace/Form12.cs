using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnePlace
{
 

        public partial class Form12 : Form
    {
        
        public Form12()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            this.Hide();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataBank.a = textBox3.Text;
            DataBank.b = textBox2.Text;
            DataBank.c = textBox1.Text;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
