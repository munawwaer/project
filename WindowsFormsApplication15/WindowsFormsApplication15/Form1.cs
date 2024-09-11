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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private void colo(object sender, EventArgs e)
        {
            double x,y,z;
            if (Num1.Text != "" && Num2.Text != "")
            {
                try
                {
                    x = Convert.ToDouble(Num1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("تـحذبـر ادخل الـعدد الاول بشـكل صحـيـح");
                    Num1.Clear();
                    Num1.Focus();
                    return;
                }
                try
                {
                    y = Convert.ToDouble(Num2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("تـحذبـر ادخل الـعدد الثاني بشـكل صحـيـح");
                    Num2.Clear();
                    Num2.Focus();
                    return;
                }
                z = x + y;
                bool f = true;
                string op = lisB.Text.Trim();
                switch (op)
                {
                    case "+": z = x + y; break;
                    case "-": z = x - y; break;
                    case "*": z = x * y; break;
                    case "/":
                        if (y != 0)
                        {
                            z = x / y;

                            break;
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن القسمه على صفر", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            f = false;
                            Num2.Text = null;
                            Num2.Focus();
                        }
                        break;
                    default: break;
                }
                if (f)
                {
                    Result.Text = z.ToString();

                }
            }
            }
        private void clear(object sender, EventArgs e)
    {
        if (Num1.Text == "" || Num2.Text == "")
            Result.Text = "";
    }
        private void Form1_Load(object sender, EventArgs e)
        {
            Num1.TextChanged += colo;
            Num2.TextChanged += colo;
            Result.TextChanged += colo;
            lisB.SelectedIndexChanged += colo;
            //
            //Num1.Click += clear;
            //Num2.Click += clear;
            //lisB.Click += clear;


            label1.Text = "الــعـدد الاول";
            label2.Text = "العـمـلـية";
            label3.Text = "الـعـدد الثاني";
            label4.Text = "الـنـاتج";
           
            button2.Text = "حـذف";
            button3.Text = "اغــلاق";
            this.Text = "ListBox";
            // this.lisB.Items.AddRange(op);
            //lisB.Items.AddRange(op);
            lisB.Items.Add("+");
            lisB.Items.Add("-");
            lisB.Items.Add("*");
            lisB.Items.Add("/");

            lisB.SelectedIndex = 0;
            //lisB.SelectedItems=lisB.items[0];
            //lisB.Text="+";
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Num2.Text = Num1.Text=Result.Text = null;
        }
        }
    }

