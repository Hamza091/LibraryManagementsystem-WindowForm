﻿using System;
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
    public partial class modifyabook : Form
    {
        public modifyabook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

       }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string line;
            string bookname;
            string authorname = textBox1.Text;
            string publisher = textBox3.Text;
            string quantity = textBox4.Text;
            string price = textBox5.Text;
            bookname = textBox2.Text;
            int flagg = 5;
           // file=@"C:/Users/hp/Desktop/OOP project/Window Form/LibraryManagementsystem/LibraryManagementsystem/bin/Debug/book.txt";
            StreamReader read = new StreamReader("book.txt");
            line = read.ReadLine();
            //string path = @"C:/Users/hp/Desktop/OOP project/Window Form/LibraryManagementsystem/LibraryManagementsystem/bin/Debug/newfile.txt";
            //FileStream ps = File.Create(path);
            while (line != null)
            {
                if (line == bookname)
                {
                    while (flagg != 0)
                    {
                        flagg = flagg - 1;
                        line = read.ReadLine();

                    }
                 }

                using (StreamWriter sw = File.AppendText("newfile.txt"))
                {
                    sw.WriteLine(line);
                }
                //File.AppendAllLines(path, new[] { line });
                line = read.ReadLine();

    
            }
                read.Close();
                //string book = @"C:/Users/hp/Desktop/OOP project/Window Form/LibraryManagementsystem/LibraryManagementsystem/bin/Debug/book.txt";
                File.Delete("book.txt");
                //FileStream fs=File.Create(book);
                File.Copy("newfile.txt", "book.txt");
                using (StreamWriter sw = File.AppendText("book.txt"))
                {
                    sw.WriteLine(bookname);
                    sw.WriteLine(authorname);
                    sw.WriteLine(publisher);
                    sw.WriteLine(quantity);
                    sw.WriteLine(price);
                }
                File.Delete("newfile.txt");

            







        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarianloggedin menu = new Librarianloggedin();
            menu.Show();
        }
    }
}
    
