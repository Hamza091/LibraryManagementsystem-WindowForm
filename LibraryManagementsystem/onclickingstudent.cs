using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementsystem
{
    public partial class onclickingstudent : Form
    {
        public onclickingstudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            STonclickingviewbooklist list = new STonclickingviewbooklist();
            list.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            STonclickingsearchforbook st = new STonclickingsearchforbook();
            st.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }
    }
}
