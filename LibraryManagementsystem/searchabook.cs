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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            string bookname;
            int check;
            check = 0;
            //string words;
            //bookname = textBox1.Text;
            //string file = "C:/Users/hp/Desktop/OOP project/Window Form/LibraryManagementsystem/LibraryManagementsystem/bin/Debug/book.txt";
            StreamReader myFile = new StreamReader("book.txt");
            line = myFile.ReadLine();
            bookname = textBox1.Text;
            while(line!=null)
            {
            
                if (line==bookname)
                {
                    richTextBox1.Text = "Book Name: "+line + Environment.NewLine + "Author Name: "+myFile.ReadLine() + Environment.NewLine + "Publisher Name: "+myFile.ReadLine() + Environment.NewLine + "Quantity: "+myFile.ReadLine() + Environment.NewLine + "Price: "+myFile.ReadLine();
                    check = 1;
                    break;
                   
                }
                line = myFile.ReadLine();
            }

            
            if (check==0)
            {
                      MessageBox.Show("Book not found!");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarianloggedin menu = new Librarianloggedin();
            menu.Show();
        }
    }
}
