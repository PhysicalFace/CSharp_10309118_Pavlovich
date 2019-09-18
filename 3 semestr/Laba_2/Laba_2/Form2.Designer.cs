namespace Laba_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_Surname = new System.Windows.Forms.TextBox();
            this.tB_Initials = new System.Windows.Forms.TextBox();
            this.tB_Post = new System.Windows.Forms.TextBox();
            this.tB_Date = new System.Windows.Forms.TextBox();
            this.b_Add = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Инициалы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Год поступле-\r\nния на работу";
            // 
            // tB_Surname
            // 
            this.tB_Surname.Location = new System.Drawing.Point(141, 18);
            this.tB_Surname.Name = "tB_Surname";
            this.tB_Surname.Size = new System.Drawing.Size(194, 20);
            this.tB_Surname.TabIndex = 4;
            // 
            // tB_Initials
            // 
            this.tB_Initials.Location = new System.Drawing.Point(141, 54);
            this.tB_Initials.Name = "tB_Initials";
            this.tB_Initials.Size = new System.Drawing.Size(194, 20);
            this.tB_Initials.TabIndex = 5;
            // 
            // tB_Post
            // 
            this.tB_Post.Location = new System.Drawing.Point(141, 83);
            this.tB_Post.Name = "tB_Post";
            this.tB_Post.Size = new System.Drawing.Size(194, 20);
            this.tB_Post.TabIndex = 6;
            // 
            // tB_Date
            // 
            this.tB_Date.Location = new System.Drawing.Point(141, 115);
            this.tB_Date.Name = "tB_Date";
            this.tB_Date.Size = new System.Drawing.Size(194, 20);
            this.tB_Date.TabIndex = 7;
            // 
            // b_Add
            // 
            this.b_Add.Location = new System.Drawing.Point(141, 150);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(90, 36);
            this.b_Add.TabIndex = 8;
            this.b_Add.Text = "Добавить работника";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.b_Cancel.Location = new System.Drawing.Point(245, 150);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(90, 36);
            this.b_Cancel.TabIndex = 9;
            this.b_Cancel.Text = "Отмена";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 208);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.tB_Date);
            this.Controls.Add(this.tB_Post);
            this.Controls.Add(this.tB_Initials);
            this.Controls.Add(this.tB_Surname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление работника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_Surname;
        private System.Windows.Forms.TextBox tB_Initials;
        private System.Windows.Forms.TextBox tB_Post;
        private System.Windows.Forms.TextBox tB_Date;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Button b_Cancel;
    }
}