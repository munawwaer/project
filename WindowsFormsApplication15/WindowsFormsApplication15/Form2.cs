using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            multy.Click += opreations;
            sumation.Click += opreations;
            squre.Click += opreations;
            label1.Text = "ادخل الــعـدد";
            label2.Text ="؟؟؟؟";
            label3.Text = "؟؟؟؟";
            label4.Text = "؟؟؟؟";
            multy.Text = "الـمـضروب";
            sumation.Text = "الـمـجموع";
            squre.Text = "الـجـذر";
            textBox1.Focus();
        }
        private void opreations(object sender, EventArgs e)
        {
             int n;
             if (int.TryParse(textBox1.Text, out n))
             {
                 if (sender == sumation)
                 {
                         n = (n * (n + 1)) / 2;
                         label3.Text = n.ToString();
                 }
                 else if (sender == multy)
                 {
                     int i = 1, f = 1;
                         while (i <= n)
                         {
                             f = f * i;
                             i=i+1;
                         }
                         label2.Text = f.ToString();
                 }
                 else if (sender == squre)
                 {
                     if (n==0)
                     {
                         label4.Text = "0";
                         return;
                     }
                     else if (n < 0)
                     {
                         MessageBox.Show("لا يمكن ايجاد جذر لعدد سالب:");
                         textBox1.Clear();
                         textBox1.Focus();
                         return;
                     }
                     int i = n / 2,f=0;
                     while (i >= 2)
                     {
                         if (i * i == n)
                         {
                             label4.Text = i.ToString();
                             f = 1;
                             break;
                         }
                         i--;
                     }
                     if(f==0)
                         label4.Text ="لا يوجد";
                     }
                 }
             else
             {
                 MessageBox.Show("العدد غير صحيح");
             }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int i = 1, f = 1;
            //int n;
            //if (int.TryParse(textBox1.Text, out n))
            //{
            //    while (i >= n)
            //    {
            //        f = f * i;
            //        i++;
            //    }
            //    label2.Text = f.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("العدد غير صحيح");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int n;
            //if (int.TryParse(textBox1.Text, out n))
            //{
            //    n = (n * (n + 1)) / 2;
            //    label3.Text = n.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("العدد غير صحيح");
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int n;
            //if (int.TryParse(textBox1.Text, out n))
            //{
            //    int i = 1;
            //    if (n == 1)
            //    {
            //        label4.Text = "1";
            //        return;
            //    }
            //    else if (n < 0)
            //    {
            //        MessageBox.Show("لا يمكن ايجاد جذر لعدد سالب:");
            //        return;
            //    }

            //    while (i > n)
            //    {
            //        i = i * i;
            //        if (i == n)
            //            label4.Text = i.ToString();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("العدد غير صحيح");
            //}

        }
    }
}
