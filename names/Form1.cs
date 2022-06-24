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

namespace names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name = "..\\..\\names.txt";
        string rev = "..\\..\\review.txt";


        private void generate_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter(name, false, Encoding.GetEncoding("windows-1251"));
            string[] names = new string[] { "Alex", "Dave", "Steven", "John", "Mark", "Layla", "Peter", "Susan", "Jason", "Ariana" };
            Random r = new Random();
            int p = r.Next(0, 10);
            pictureBox1.Image = imageList1.Images[p];
            sw.WriteLine(names[p]);
            sw.Close();

            StreamWriter sw2 = new StreamWriter(rev, false, Encoding.GetEncoding("windows-1251"));
            string[] reev = new string[] { "Waste of money.","Don't buy it!", "Awful!","It could be better...","Good.", "Great!",  "The best product I've purchased!!!", "5 stars!", "My favourite!",   };
            r = new Random();
            int q = r.Next(0, 9);
            pictureBox2.Image = imageList2.Images[q];
            sw2.WriteLine(reev[q]);
            sw2.Close();

            listBox1.Items.Clear();
            StreamReader sr = new StreamReader(name, Encoding.GetEncoding("windows-1251"));
            string line = sr.ReadLine();


            listBox1.Items.Add(line);

            sr.Close();

            listBox2.Items.Clear();
            StreamReader sr2 = new StreamReader(rev, Encoding.GetEncoding("windows-1251"));

            string line2 = sr2.ReadLine();


            listBox2.Items.Add(line2);
            sr2.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {





        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            pictureBox1.Image = null;
            pictureBox2.Image = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
