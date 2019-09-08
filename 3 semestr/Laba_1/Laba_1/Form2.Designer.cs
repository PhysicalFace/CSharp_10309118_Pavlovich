namespace Laba_1
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
            this.tB_number1 = new System.Windows.Forms.TextBox();
            this.tB_number2 = new System.Windows.Forms.TextBox();
            this.cB_summa = new System.Windows.Forms.CheckBox();
            this.cB_multiply = new System.Windows.Forms.CheckBox();
            this.cB_maxdivisor = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_number1
            // 
            this.tB_number1.Location = new System.Drawing.Point(30, 28);
            this.tB_number1.Name = "tB_number1";
            this.tB_number1.Size = new System.Drawing.Size(215, 20);
            this.tB_number1.TabIndex = 0;
            this.tB_number1.Text = "Number 1";
            // 
            // tB_number2
            // 
            this.tB_number2.Location = new System.Drawing.Point(30, 54);
            this.tB_number2.Name = "tB_number2";
            this.tB_number2.Size = new System.Drawing.Size(215, 20);
            this.tB_number2.TabIndex = 1;
            this.tB_number2.Text = "Number 2";
            // 
            // cB_summa
            // 
            this.cB_summa.AutoSize = true;
            this.cB_summa.Location = new System.Drawing.Point(30, 81);
            this.cB_summa.Name = "cB_summa";
            this.cB_summa.Size = new System.Drawing.Size(61, 17);
            this.cB_summa.TabIndex = 2;
            this.cB_summa.Text = "Summa";
            this.cB_summa.UseVisualStyleBackColor = true;
            // 
            // cB_multiply
            // 
            this.cB_multiply.AutoSize = true;
            this.cB_multiply.Location = new System.Drawing.Point(97, 81);
            this.cB_multiply.Name = "cB_multiply";
            this.cB_multiply.Size = new System.Drawing.Size(61, 17);
            this.cB_multiply.TabIndex = 3;
            this.cB_multiply.Text = "Multiply";
            this.cB_multiply.UseVisualStyleBackColor = true;
            // 
            // cB_maxdivisor
            // 
            this.cB_maxdivisor.AutoSize = true;
            this.cB_maxdivisor.Location = new System.Drawing.Point(164, 81);
            this.cB_maxdivisor.Name = "cB_maxdivisor";
            this.cB_maxdivisor.Size = new System.Drawing.Size(81, 17);
            this.cB_maxdivisor.TabIndex = 4;
            this.cB_maxdivisor.Text = "Max Divisor";
            this.cB_maxdivisor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Action";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cB_maxdivisor);
            this.Controls.Add(this.cB_multiply);
            this.Controls.Add(this.cB_summa);
            this.Controls.Add(this.tB_number2);
            this.Controls.Add(this.tB_number1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_number1;
        private System.Windows.Forms.TextBox tB_number2;
        private System.Windows.Forms.CheckBox cB_summa;
        private System.Windows.Forms.CheckBox cB_multiply;
        private System.Windows.Forms.CheckBox cB_maxdivisor;
        private System.Windows.Forms.Button button1;
    }
}