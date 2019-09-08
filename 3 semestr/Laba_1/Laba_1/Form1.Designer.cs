namespace Laba_1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_Input = new System.Windows.Forms.Button();
            this.b_Calc = new System.Windows.Forms.Button();
            this.b_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Input
            // 
            this.b_Input.Location = new System.Drawing.Point(80, 68);
            this.b_Input.Name = "b_Input";
            this.b_Input.Size = new System.Drawing.Size(122, 32);
            this.b_Input.TabIndex = 0;
            this.b_Input.Text = "Input";
            this.b_Input.UseVisualStyleBackColor = true;
            this.b_Input.Click += new System.EventHandler(this.b_Input_Click);
            // 
            // b_Calc
            // 
            this.b_Calc.Enabled = false;
            this.b_Calc.Location = new System.Drawing.Point(80, 106);
            this.b_Calc.Name = "b_Calc";
            this.b_Calc.Size = new System.Drawing.Size(122, 32);
            this.b_Calc.TabIndex = 1;
            this.b_Calc.Text = "Calc";
            this.b_Calc.UseVisualStyleBackColor = true;
            this.b_Calc.Click += new System.EventHandler(this.b_Calc_Click);
            // 
            // b_Quit
            // 
            this.b_Quit.Location = new System.Drawing.Point(80, 144);
            this.b_Quit.Name = "b_Quit";
            this.b_Quit.Size = new System.Drawing.Size(122, 32);
            this.b_Quit.TabIndex = 2;
            this.b_Quit.Text = "Quit";
            this.b_Quit.UseVisualStyleBackColor = true;
            this.b_Quit.Click += new System.EventHandler(this.b_Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.b_Quit);
            this.Controls.Add(this.b_Calc);
            this.Controls.Add(this.b_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Input;
        private System.Windows.Forms.Button b_Calc;
        private System.Windows.Forms.Button b_Quit;
    }
}

