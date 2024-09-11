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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
        private void mer(object sender, EventArgs e)
        {
            int f = 0 ;
            string opr1 = opration1.Text;
            string opr2 = opration2.Text;
            double intermediatrersult = 0.0, finalresult = 0.0;
            if (number1.Text!=""&&number2.Text!=""&&number3.Text!=""&&opration1.Text!=""&&opration2.Text!="")
            {
               
                    if (opr1 == "/" || opr1 == "*")
                    {
                        intermediatrersult = PerFormOpreation(double.Parse(number1.Text), double.Parse(number2.Text), opr1);
                        f = 1;
                    }
                    else
                        intermediatrersult = PerFormOpreation(double.Parse(number2.Text), double.Parse(number3.Text), opr2);

                    if (intermediatrersult.ToString() == double.NaN.ToString())
                    {
                        
                        MessageBox.Show("العملية  غير صحصحة");
                        if (f > 0)
                        {
                            opration1.Focus();
                            opration1.Clear();
                        }
                        else
                        {
                            opration2.Focus();
                            opration2.Clear();
                        }
                        return;
                    }

                    if (f == 1)
                        finalresult = PerFormOpreation(intermediatrersult, double.Parse(number3.Text), opr2);
                    else
                        finalresult = PerFormOpreation(intermediatrersult, double.Parse(number1.Text), opr1);

                    if (finalresult.ToString() == double.NaN.ToString())
                    {    
                        MessageBox.Show("العملية غير صحيحة");
                        if (f > 0)
                        {
                            opration2.Focus();
                            opration2.Clear();
                        }
                        else
                        {
                            opration1.Focus();
                            opration1.Clear();
                        }
                        return;
                    }

                    Resulte.Text = finalresult.ToString();
                }
         
        }
        private void Resultclare(object sender, EventArgs e)
        {
            if (number3.Text == "" || number1.Text == "" || opration1.Text == "" || number2.Text == "" || opration2.Text == "")
             Resulte.Clear();  
         
               
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            string opr1 = opration1.Text;
            string opr2 = opration2.Text;
            double intermediatrersult = 0.0, finalresult = 0.0;
            if (double.TryParse(number1.Text, out num1) &&
                double.TryParse(number2.Text, out num2) &&
                double.TryParse(number3.Text, out num3))
            {
                int f=0;
                if (opr1 == "/" || opr1 == "*")
                {
                    intermediatrersult = PerFormOpreation(num1, num2, opr1);
                    f=1;
                }
                else
                    intermediatrersult = PerFormOpreation(num2, num3, opr2);

                if (intermediatrersult.ToString() == double.NaN.ToString())
                    {
                        MessageBox.Show("العملية الاولي غير صحصحة");
                        opration1.Focus();
                        return;
                    }
                
               if(f==1)
                   finalresult = PerFormOpreation(intermediatrersult, num3, opr2);
               else
                   finalresult = PerFormOpreation(intermediatrersult, num1, opr1);
               if (finalresult.ToString() == double.NaN.ToString())
                    {
                        MessageBox.Show("العملية الثانيه غير صحيحة");
                        opration2.Focus();
                        return;
                    }

               Resulte.Text = finalresult.ToString();
            }
            else
                MessageBox.Show("ادخل ارقام صحيحه:");

        }
        private double PerFormOpreation(double num1, double num2, string ch)
        { 
            switch(ch)
            {
                case "+":
                    return num1 + num2;//break;
                case "-":
                    return num1 - num2;//break;
                case "*":
                    return num1 * num2;//break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("لا يمكن القسمه علي صفر ");
                        
                    }
                    return num2 != 0 ? num1 / num2 : -1;//break;
                default:
                    return double.NaN;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        { // هذه الداله في تنظف القيمه الاوليه للنتيجه في حال تم حذف رقم او عمليه اثناء التنفيذ
            number1.TextChanged += Resultclare;
            opration1.TextChanged += Resultclare;
            number2.TextChanged += Resultclare;
            opration2.TextChanged += Resultclare;
            number3.TextChanged += Resultclare;
            //هذه الداله الرئيسيه التي تعمل علي العملبات 
            opration2.TextChanged += mer;
            number3.TextChanged += mer;
            number1.TextChanged += mer; 
            opration1.TextChanged += mer;
            number2.TextChanged += mer;
            //تم اسنخدام الحدث لانه الداله mer تستدعي نفسها عند الضغط علي اي اداة
            number1.KeyPress += isnumber;
            number2.KeyPress += isnumber;
            number3.KeyPress += isnumber;

            Resulte.ReadOnly = true;
        }
        private void isnumber(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57)&&(e.KeyChar!=8))
                e.Handled = true;
        }
      

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void number3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
       
    }
}
