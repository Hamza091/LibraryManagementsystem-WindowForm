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
    public partial class issueabook : Form
    {
        public issueabook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lineno=1;
            int checkline = 4;
            string bookname = textBox1.Text;
            string name = textBox2.Text;
            string id = textBox3.Text;
            //string file;
            //file = @"C:/Users/hp/Desktop/OOP project/Window Form/LibraryManagementsystem/LibraryManagementsystem/bin/Debug/book.txt";
            StreamReader read = new StreamReader("book.txt");
            string line;
            line = read.ReadLine();
            while (line != null)
            {
                if (line == bookname)
                {
                    while (checkline!=1)
                    {
                        line = read.ReadLine();
                        checkline--;
                        lineno++;
                    }
                    break;
                
                }

                line = read.ReadLine();
                lineno++;
            }
            if (line == null)
            {
                MessageBox.Show("Book not found");
                read.Close();
            }
            else
            {
                //string student;
                int quantity;
                quantity = Int32.Parse(line);
                quantity =quantity- 1;
                read.Close();
                //student = @"C:/Users/hp/Desktop/OOP project/Window Form/LibraryManagementsystem/LibraryManagementsystem/bin/Debug/student.txt";
                using (StreamWriter st = File.AppendText("student.txt"))
                { 
                    st.WriteLine(name);
                    
                    st.WriteLine(id);

                    st.WriteLine(bookname);
                }

                StreamReader findline = new StreamReader("book.txt");
                string[] arrLine = File.ReadAllLines("book.txt");
                findline.Close();
                arrLine[lineno - 1] = quantity.ToString();
                File.WriteAllLines("book.txt", arrLine);
                findline.Close();
                if (quantity == 0) 
                {
                    int checkbook;
                    checkbook = 5;
                    string p;
                    string r;
                    StreamReader delete = new StreamReader("book.txt");
                    r = delete.ReadLine();
                    p = "new.txt";
                    //File.Create(p);
                    

                    while (r != null)
                    {
                        if (r == bookname)
                        {
                            while (checkbook != 0)
                            {
                                checkbook -= 1;
                                r = delete.ReadLine();
                            }
                            
                        }
                       // File.AppendAllText(p, r + Environment.NewLine);
                        using (StreamWriter stream = File.AppendText(p))
                        {
                            stream.WriteLine(r);
                           
                        }
                        r = delete.ReadLine();
                    }
                    delete.Close();

                    File.Delete("book.txt");
                    //File.Create(file);
                    File.Copy(p, "book.txt", true);
                    
                    File.Delete(p);
                    
                }

                
    }
                
                
            }

        private void label3_Click(object sender, EventArgs e)
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

