using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class PayForm : Form
    {
        SearchForm sf = new SearchForm();
        Form1 form1= new Form1 ();
        public PayForm()
        {
            InitializeComponent();
            sf.pf = this;
        }

        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sf.textBox1.Text = "";
            sf.Show();
        }

        private void PayForm_Load(object sender, EventArgs e)
        {

        }

        public string users;

        private void button1_Click(object sender, EventArgs e)
        {
            String input1= textBox2.Text;
            String input2 = textBox1.Text;
            DateTime now = DateTime.Now;
            users=$"{now.ToString("hh:mm:sstt")}-{input1}-{input2}";
            form1.LB.Items.Add(users);


        }
    }
}
