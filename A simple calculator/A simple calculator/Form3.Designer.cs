namespace A_simple_calculator
{
    partial class Form3
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
            this.butgreen = new System.Windows.Forms.Button();
            this.butyellow = new System.Windows.Forms.Button();
            this.butred = new System.Windows.Forms.Button();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butgreen
            // 
            this.butgreen.Location = new System.Drawing.Point(210, 90);
            this.butgreen.Name = "butgreen";
            this.butgreen.Size = new System.Drawing.Size(75, 23);
            this.butgreen.TabIndex = 0;
            this.butgreen.Text = "اخضر";
            this.butgreen.UseVisualStyleBackColor = true;
            // 
            // butyellow
            // 
            this.butyellow.Location = new System.Drawing.Point(113, 90);
            this.butyellow.Name = "butyellow";
            this.butyellow.Size = new System.Drawing.Size(75, 23);
            this.butyellow.TabIndex = 1;
            this.butyellow.Text = "اصفر";
            this.butyellow.UseVisualStyleBackColor = true;
            // 
            // butred
            // 
            this.butred.Location = new System.Drawing.Point(22, 90);
            this.butred.Name = "butred";
            this.butred.Size = new System.Drawing.Size(75, 23);
            this.butred.TabIndex = 2;
            this.butred.Text = "احمر";
            this.butred.UseVisualStyleBackColor = true;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(185, 36);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(35, 13);
            this.lab1.TabIndex = 3;
            this.lab1.Text = "جهاز1";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(62, 36);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(35, 13);
            this.lab2.TabIndex = 4;
            this.lab2.Text = "جهاز2";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(99, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 39);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 261);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.butred);
            this.Controls.Add(this.butyellow);
            this.Controls.Add(this.butgreen);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butgreen;
        private System.Windows.Forms.Button butyellow;
        private System.Windows.Forms.Button butred;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Button button4;
    }
}