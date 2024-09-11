using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        //داله تحديث النص اذا كان فيه حروف تقوم بعمل الحدث keypress
        private void updata(string inp, string n)
        {
           
            switch (n)
            {
                    
                case "Num1":
                    if (isdigital(inp))
                    {
                        Num1.Text = inp;
                        Num1.SelectionStart = Num1.Text.Length;
                    }
                    else
                    {
                        string h = "";
                        if (inp[0] == '-')
                            h += inp[0];
                        else
                            h = "";
                    
                        for (int i=0;i<inp.Length;i++)
                        {
                            //if (inp[0] == '.')
                            //    continue;
                            if (inp[i] >= '0' && inp[i] <= '9' || h.Contains(".") == false&&h.Count()>1)//inp[i] == '.' && inp[i - 1] != '.'
                                h += inp[i];

                            else
                                continue;
                                //MessageBox.Show("لا يمكن ادخال علامتين  بنفس الحظه");
                        }
                        Num1.Text = h;
                        Num1.SelectionStart = Num1.Text.Length;
                    }
                    break;
                case "Num2":
                    if (isdigital(Num2.Text.Trim()))
                    {
                        Num2.Text = Num2.Text.Trim();
                        Num2.SelectionStart = Num2.Text.Length;
                    }
                    else
                    {
                       
                        string h = "";
                       
                        if (inp[0] == '-')
                            h += inp[0];
                        else
                            h = "";
                        for ( int i = 0; i < inp.Length; i++)// c in inp)
                        {
                            //if (inp[0] == '.' )
                            //    continue;
                            //الداله contains مهمتها اذا كانت العلامه العشريع موجوده من قبل ما تظيفه واذا غير موجوده تظيفه بشرط ان يكون عدد الحروف في النص اكثر من واحد
                            if (inp[i] >= '0' && inp[i] <= '9' || h.Contains(".") == false && h.Count() > 1)//inp[i] == '.' && inp[i - 1] != '.'
                                h += inp[i];
                            else
                                continue;
                               // MessageBox.Show("لا يمكن ادخال علامتين  بنفس الحظه");
                        }
                      
                        Num2.Text = h;
                        Num2.SelectionStart = Num2.Text.Length;
                    } break;

            }
        }
        //دالة تختبر التص اذا كان النص فيه حرف ترجع صفر
        
        private bool isdigital(string n)
        {
            foreach(char ch in n)
            {
                if (!(char.IsDigit(ch)))
                    return false;
            }
            return true;

            //طريقه اخري
            //int f = 1;
            //int size=n.Length;
            //for (int c=0 ;c<size;c++ )
            //{
               
               
            //    if (!((n[c] >= '0' && n[c] <= '9' )))
            //    {
            //        f = 0;
            //        break;
            //    }
               
            //}
            //if (f==1)
            //    return true;
            //else
            //return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = Num1.Text+" + "+Num2.Text+" ="+((Convert.ToDouble(Num1.Text) + Convert.ToDouble(Num2.Text)).ToString());
            Result.BackColor = Color.Red;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Result.Text = Num1.Text + " - " + Num2.Text + " =" + (Convert.ToDouble(Num1.Text) - Convert.ToDouble(Num2.Text)).ToString();
            Result.BackColor = Color.Red;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Result.Text = Num1.Text + " * " + Num2.Text + " =" + (Convert.ToDouble(Num1.Text) * Convert.ToDouble(Num2.Text)).ToString();
            Result.BackColor = Color.Red;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(Num2.Text) != 0)
            {
                Result.Text = Num1.Text + " / " + Num2.Text + " =" + (Convert.ToDouble(Num1.Text) / Convert.ToDouble(Num2.Text)).ToString();
               
                Result.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("تحذير لا يمكن القسمة على صفر");
                Num2.Clear();
                Num2.Focus();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Num1.Text = Num2.Text = Result.Text = null;
            Num1.Focus();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = (Num1.Text != "") && (Num2.Text != "");

            updata(Num1.Text.Trim(),"Num1");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = (Num1.Text != "") && (Num2.Text != "");
            //if (Num2.Text.First() == '-')
            //    str += Num2.Text.First();
           updata(Num2.Text.Trim(),"Num2");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
            Num1.TextChanged += textBox2_TextChanged;
            this.Text = " الة حاسبة بسيطة ";
            Result.ReadOnly = true;
            Num1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Num2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Result.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }
    }
}
