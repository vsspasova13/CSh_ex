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

namespace failove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name = "..\\..\\vilieqka.txt";

        private void button1_Click(object sender, EventArgs e)
        {


            StreamWriter sw = new StreamWriter(name, false, Encoding.GetEncoding("windows-1251"));
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(r.Next(1, 51));
            }
            sw.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(name, Encoding.GetEncoding("windows-1251"));
            string line = "";
            while (line!=null)
            {
                line = sr.ReadLine();
                if (line!=null)
                {
                    listBox1.Items.Add(line);

                }

            }
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader(name, Encoding.GetEncoding("windows-1251"));
            string line = "";
            int sum = 0;
            while (line!=null)
            {
                line = sr.ReadLine();
                if (line!=null)
                {
                    sum = sum + int.Parse(line);

                }

            }
            sr.Close();
            MessageBox.Show("Сумата е "+sum);

            StreamWriter sw = new StreamWriter(name, true, Encoding.GetEncoding("windows-1251"));
            sw.WriteLine(sum);
            sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
