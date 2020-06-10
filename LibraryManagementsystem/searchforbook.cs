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
    public partial class searchforbook : Form
    {
        public searchforbook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string id;
            string line;
            string book = textBox1.Text;
            richTextBox1.Text = "";
           
            int check = 0;
           // file = @"C:/Users/hp/Desktop/OOP project/Window Form/LibraryManagementsystem/LibraryManagementsystem/bin/Debug/student.txt";
            StreamReader read = new StreamReader("student.txt");
            line = read.ReadLine();
            while (line != null)
            {
                name = line;
                line = read.ReadLine();
                id = line;
                line = read.ReadLine();
                if (line == book)
                {
                    check = 1;
                    StringBuilder st = new StringBuilder();
                    st.Append("Student name: ");
                    st.AppendLine(name);
                    st.Append("Student ID: ");
                    st.AppendLine(id);
                    richTextBox1.Text += st.ToString();
                }
                line = read.ReadLine();
            }
            if (check == 0)
            {
                MessageBox.Show("Book not found");
            }
            
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarianloggedin menu = new Librarianloggedin();
            menu.Show();
        }
    }
}
