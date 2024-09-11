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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void traingforsender(object sender,EventArgs e)
        {
            
            if(sender is Button )
            {
               Button button=(Button)sender;
                if (button.Text == "اخضر")
                    button4.BackColor = Color.Green;
                else if ( button.Text== "احمر")
                    button4.BackColor = Color.Red;
                else if (button.Text =="اصفر")
                    button4.BackColor = Color.Yellow;
            }
            else if(sender is Label)
            {
                Label labl=(Label)sender;
                if (labl.Text == "جهاز1")
                    button4.Text = lab1.Text;
                else if (labl.Text == "جهاز2")
                    button4.Text = lab2.Text;
            }
            //هذه طريقة بدون تعريف متغيرات 
            //if (sender is Button)
            //{
            //    if (sender == butgreen)
            //        button4.BackColor = Color.Green;
            //    else if (sender == butred)
            //        button4.BackColor = Color.Red;
            //    else if (sender == butyellow)
            //        button4.BackColor = Color.Yellow;
            //}
            //else if (sender is Label)
            //{
            //    if (sender == lab1)
            //        button4.Text = lab1.Text;
            //    else if (sender == lab2)
            //        button4.Text = lab2.Text;
            //}
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            butgreen.Click += traingforsender;
            butred.Click += traingforsender;
            butyellow.Click +=traingforsender;
              lab1.Click += traingforsender;
              lab2.Click += traingforsender;
        }
    }
}
