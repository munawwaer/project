namespace A_simple_calculator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.number1 = new System.Windows.Forms.TextBox();
            this.opration1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.opration2 = new System.Windows.Forms.TextBox();
            this.number3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Resulte = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(48, 24);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 20);
            this.number1.TabIndex = 0;
            // 
            // opration1
            // 
            this.opration1.Location = new System.Drawing.Point(48, 62);
            this.opration1.Name = "opration1";
            this.opration1.Size = new System.Drawing.Size(100, 20);
            this.opration1.TabIndex = 1;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(48, 102);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 20);
            this.number2.TabIndex = 2;
            // 
            // opration2
            // 
            this.opration2.Location = new System.Drawing.Point(48, 146);
            this.opration2.Name = "opration2";
            this.opration2.Size = new System.Drawing.Size(100, 20);
            this.opration2.TabIndex = 3;
            this.opration2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(48, 184);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(100, 20);
            this.number3.TabIndex = 4;
            this.number3.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.number3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "العدد الاول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "العملية";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "العدد الثاني";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "العملية";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "العدد الثالث";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "الناتج";
            // 
            // Resulte
            // 
            this.Resulte.Location = new System.Drawing.Point(48, 230);
            this.Resulte.Name = "Resulte";
            this.Resulte.Size = new System.Drawing.Size(100, 20);
            this.Resulte.TabIndex = 11;
            this.Resulte.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "حساب";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "اغلاق";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resulte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.opration2);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.opration1);
            this.Controls.Add(this.number1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox opration1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox opration2;
        private System.Windows.Forms.TextBox number3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Resulte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}