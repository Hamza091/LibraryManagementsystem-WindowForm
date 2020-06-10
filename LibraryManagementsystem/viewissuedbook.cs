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
    public partial class viewissuedbook : Form
    {
        public viewissuedbook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            //List<string> list=new List<string>();
            
            //file = @"C:/Users/hp/Desktop/OOP project/Window Form/LibraryManagementsystem/LibraryManagementsystem/bin/Debug/student.txt";
            StreamReader read = new StreamReader("student.txt");
            line = read.ReadLine();
            StringBuilder sb = new StringBuilder();
            while (line != null)
            {
                sb.Append("Student Name: ");
                sb.AppendLine(line);
                line = read.ReadLine();
                sb.Append("Student ID: ");
                sb.AppendLine(line);
                line = read.ReadLine();
                sb.Append("Book Issued: ");
                sb.AppendLine(line);
                line = read.ReadLine();
            }
                richTextBox1.Text = sb.ToString();
          
            read.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarianloggedin menu = new Librarianloggedin();
            menu.Show();
        }
    }
}
