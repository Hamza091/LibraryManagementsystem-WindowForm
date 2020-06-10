using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagementsystem
{
    public partial class onclickingaddbook : Form
    {
        public onclickingaddbook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
 
        
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookname;
            bookname = textBox1.Text;
            string authorname;
            authorname = textBox2.Text;
            string publisher;
            string price;
            string quantity;
            publisher = textBox3.Text;
            price = textBox5.Text;
            quantity = textBox4.Text;
            //string file = "C:/Users/hp/Desktop/OOP project/Window Form/LibraryManagementsystem/LibraryManagementsystem/bin/Debug/book.txt";
            StreamReader myFile = new StreamReader("book.txt");

            //Console.WriteLine("\n");
            string line;
            int x = 0;
            while ((line = myFile.ReadLine()) != null)
            {
                if (line.Contains(bookname))
                {
                    x = 1;
                    MessageBox.Show("Book already exists");
                    break;
                }

            }
            myFile.Close();

            if (x == 0)
            {
                //string f = "C:/Users/hp/Desktop/OOP project/Window Form/LibraryManagementsystem/LibraryManagementsystem/bin/Debug/book.txt";
                //StreamReader my = new StreamReader(f);
                //StreamWriter op = new StreamWriter(f);
                //File.AppendAllText(@"C:/Users/hp/Desktop/OOP project/Window Form/LibraryManagementsystem/LibraryManagementsystem/bin/Debug/book.txt", bookname + Environment.NewLine);
                //File.AppendText(bookname);
                //File.AppendText(authorname);
                //File.AppendText(publisher);
                //File.AppendText(quantity);
                //File.AppendText(price);
                File.AppendAllText(
                "book.txt",
                 bookname + Environment.NewLine +
                 authorname + Environment.NewLine +
                 publisher + Environment.NewLine+
                 quantity+ Environment.NewLine+
                 price+ Environment.NewLine);
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

