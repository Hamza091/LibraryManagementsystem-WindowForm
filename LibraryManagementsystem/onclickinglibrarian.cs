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
    public partial class onclickinglibrarian : Form
    {
        public onclickinglibrarian()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if (name == "Hamza" && pass == "123")
            {
                this.Hide();
                Librarianloggedin menu = new Librarianloggedin();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
