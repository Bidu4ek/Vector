using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectors
{
    public partial class Form1 : Form
    {
        VectorDB vectors;
        int helpcur = 0;
        int No=0;

        public Form1()
        {
            InitializeComponent();
            vectors = new VectorDB();
        }
        private void новыйСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vectors = new VectorDB();
            helpcur = 0;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vectors.Db.Clear();
            helpcur = 0;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vectors - калькулятор длин векторов.\nВадим Бидюк © 2018");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(textBoxX.Text.Replace(".", ","));
                double Y = Convert.ToDouble(textBoxY.Text.Replace(".", ","));
                double Z = Convert.ToDouble(textBoxZ.Text.Replace(".", ","));

                Vector vector = new Vector(X, Y, Z);

                ActiveForm.Text = (vectors.Db.Count + 1).ToString();
                vectors.Db.Add(vector);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vectors.Db.Count > 0)
            {
                if(No!=0)
                helpcur +=3;
                No++;
                if (helpcur >= vectors.Db.Count)
                {
                    helpcur = 0;
                    No = 1;
                }
                showInfo();
            }
        }
      
        private void changeNo(object sender, EventArgs e)
        {
            try
            {
                No = Convert.ToInt32(textBoxNum.Text.Replace(".", ","));
                helpcur = No - 1;
                showInfo();
            }
            catch
            {
                No = 1;
                helpcur =0;
            }
            
        }

        private void showInfo()
        {
            textBoxA.Text = vectors.Db.ElementAt(helpcur).Len.ToString();
            try
            {
                textBoxB.Text = vectors.Db.ElementAt(helpcur + 1).Len.ToString();
            }
            catch
            {
                textBoxB.Text = "Нет данных";
            }
            try
            {
                textBoxC.Text = vectors.Db.ElementAt(helpcur + 2).Len.ToString();
                textBoxR.Text = Convert.ToString(Math.Sqrt(Math.Pow(((vectors.Db.ElementAt(helpcur).Yv + vectors.Db.ElementAt(helpcur + 1).Yv) * vectors.Db.ElementAt(helpcur + 2).Zv - (vectors.Db.ElementAt(helpcur).Zv + vectors.Db.ElementAt(helpcur + 1).Zv) * vectors.Db.ElementAt(helpcur + 2).Yv), 2) + Math.Pow(((vectors.Db.ElementAt(helpcur).Zv + vectors.Db.ElementAt(helpcur + 1).Zv) * vectors.Db.ElementAt(helpcur + 2).Xv - (vectors.Db.ElementAt(helpcur).Xv + vectors.Db.ElementAt(helpcur + 1).Xv) * vectors.Db.ElementAt(helpcur + 2).Zv), 2) + Math.Pow(((vectors.Db.ElementAt(helpcur).Zv + vectors.Db.ElementAt(helpcur + 1).Zv) * vectors.Db.ElementAt(helpcur + 2).Yv - (vectors.Db.ElementAt(helpcur).Yv + vectors.Db.ElementAt(helpcur + 1).Yv) * vectors.Db.ElementAt(helpcur + 2).Xv), 2)));

                textBoxT.Text = Convert.ToString((vectors.Db.ElementAt(helpcur).Xv + vectors.Db.ElementAt(helpcur + 2).Xv) * vectors.Db.ElementAt(helpcur + 2).Xv + (vectors.Db.ElementAt(helpcur).Yv + vectors.Db.ElementAt(helpcur + 2).Yv) * vectors.Db.ElementAt(helpcur + 2).Yv + (vectors.Db.ElementAt(helpcur).Zv + vectors.Db.ElementAt(helpcur + 2).Zv) * vectors.Db.ElementAt(helpcur + 2).Zv);
            }
            catch
            {
                textBoxC.Text = "Нет данных";
                textBoxR.Text = "Нет данных";
                textBoxT.Text = "Нет данных";
            }
            textBoxNum.Text = Convert.ToString(No);
        }  
    }
}
