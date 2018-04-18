using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector
{
    public partial class Form1 : Form
    {

        double[] decX = new double[3];
        double[] decY = new double[3];
        double[] decZ = new double[3];
        string[] Rez = new string[6];
        string help;
        string[] Help = new string[9];
        string s;
        int p;
        int p1;
        
        public Form1()
        {
            InitializeComponent();
            Rez[3] = "|a| = ";
            Rez[4] = "\r\n\r\n|b| = ";
            Rez[5] = "\r\n\r\n|c| = ";
            s = "-";
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            help = textBox1.Text;
            p = 1;
            if (help[0] == s[0])
            {
                p = -1;
                for(int i=1;i< help.Length; i++)
                {
                    Help[0] += help[i];
                }
            }
            else
            {
                Help[0] = help;
            }
            decX[0] =p * Convert.ToDouble(Help[0]);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            help = textBox2.Text;
            p = 1;
           
            if (help[0] == s[0])
            {
                p = -1;
                for (int i = 1; i < help.Length; i++)
                {
                    Help[1] += help[i];
                }
            }
            else
            {
                Help[1] = help;
            }
            decY[0] = p* Convert.ToDouble(Help[1]);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            help = textBox3.Text;
            p = 1;
            if (help[0] == s[0])
            {
                p = -1;
                for (int i = 1; i < help.Length; i++)
                {
                    Help[2] += help[i];
                }
            }
            else
            {
                Help[2] = help;
            }
            decZ[0] = p * Convert.ToDouble(Help[2]);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            help = textBox4.Text;
            p = 1;
            if (help[0] == s[0])
            {
                p = -1;
                for (int i = 1; i < help.Length; i++)
                {
                    Help[3] += help[i];
                }
            }
            else
            {
                Help[3] = help;
            }
            decX[1] = p * Convert.ToDouble(Help[3]);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            help = textBox5.Text;
            p = 1;
            if (help[0] == s[0])
            {
                p = -1;
                for (int i = 1; i < help.Length; i++)
                {
                    Help[4] += help[i];
                }
            }
            else
            {
                Help[4] = help;
            }
            decY[1] = p * Convert.ToDouble(Help[4]);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            help = textBox6.Text;
            p = 1;
            if (help[0] == s[0])
            {
                p = -1;
                for (int i = 1; i < help.Length; i++)
                {
                    Help[5] += help[i];
                }
            }
            else
            {
                Help[5] = help;
            }
            decZ[1] = p * Convert.ToDouble(Help[5]);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            help = textBox7.Text;
            p = 1;
            if (help[0] == s[0])
            {
                p = -1;
                for (int i = 1; i < help.Length; i++)
                {
                    Help[6] += help[i];
                }
            }
            else
            {
                Help[6] = help;
            }
            decX[2] = p * Convert.ToDouble(Help[6]);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            help = textBox8.Text;
            p = 1;
            if (help[0] == s[0])
            {
                p = -1;
                for (int i = 1; i < help.Length; i++)
                {
                    Help[7] += help[i];
                }
            }
            else
            {
                Help[7] = help;
            }
            decY[2] = p * Convert.ToDouble(Help[7]);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            help = textBox9.Text;
            p = 1;
            if (help[0] == s[0])
            {
                p = -1;
                for (int i = 1; i < help.Length; i++)
                {
                    Help[8] += help[i];
                }
            }
            else
            {
                Help[8] = help;
            }
            decZ[2] = p * Convert.ToDouble(Help[8]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Vector Vector = new Vector(decX, decY, decZ);
            Rez[0] = Rez[3] + Convert.ToString(Vector.Len0()) + Rez[4] + Convert.ToString(Vector.Len1()) + Rez[5] + Convert.ToString(Vector.Len2());
            MessageBox.Show(Rez[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vector Vector = new Vector(decX, decY, decZ);
            Rez[1] = Convert.ToString(Vector.r());
            MessageBox.Show(Rez[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vector Vector = new Vector(decX, decY, decZ);
            Rez[2] = Convert.ToString(Vector.t());
            MessageBox.Show(Rez[2]);
        }
    }
}
