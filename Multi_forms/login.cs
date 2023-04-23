using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        Form1 Main = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Admin") && textBox2.Text.Contains("Admin123"))
            {
                Main.Show();
                this.Hide();
            }
        }
    }
}
