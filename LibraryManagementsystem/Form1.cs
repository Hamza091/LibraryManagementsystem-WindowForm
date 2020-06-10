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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            onclickinglibrarian librarian= new onclickinglibrarian();
            librarian.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            onclickingstudent st = new onclickingstudent();
            st.Show();
        }
    }
}
