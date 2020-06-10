using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagementsystem
{
    public partial class STonclickingviewbooklist : Form
    {
        public STonclickingviewbooklist()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader read = new StreamReader("book.txt"))
            {
                richTextBox1.Text = await read.ReadToEndAsync();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            onclickingstudent st = new onclickingstudent();
            st.Show();
        }
    }
}
