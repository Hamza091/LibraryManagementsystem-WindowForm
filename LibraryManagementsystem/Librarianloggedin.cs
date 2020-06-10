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
    public partial class Librarianloggedin : Form
    {
        public Librarianloggedin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBookList books = new ViewBookList();
            books.Show();

           




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 find = new Form2();
            find.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            onclickingaddbook menu = new onclickingaddbook();
            menu.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            modifyabook modify = new modifyabook();
            modify.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            onclickingdeleteabook deletee = new onclickingdeleteabook();
            deletee.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            issueabook issue = new issueabook();
            issue.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewissuedbook view = new viewissuedbook();
            view.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchforbook search = new searchforbook();
            search.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

      

      
    }
}
