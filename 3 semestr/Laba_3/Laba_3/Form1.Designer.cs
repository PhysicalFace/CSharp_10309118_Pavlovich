namespace Laba_3
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
            this.lB_vector = new System.Windows.Forms.ListBox();
            this.b_AddVector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.b_ShowAllVector = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.r_Mult = new System.Windows.Forms.RadioButton();
            this.r_Div = new System.Windows.Forms.RadioButton();
            this.r_Add = new System.Windows.Forms.RadioButton();
            this.r_Sub = new System.Windows.Forms.RadioButton();
            this.b_ActionVector = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_InfoVector = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lB_vector
            // 
            this.lB_vector.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lB_vector.FormattingEnabled = true;
            this.lB_vector.ItemHeight = 16;
            this.lB_vector.Location = new System.Drawing.Point(15, 28);
            this.lB_vector.Name = "lB_vector";
            this.lB_vector.Size = new System.Drawing.Size(110, 100);
            this.lB_vector.TabIndex = 0;
            this.lB_vector.SelectedIndexChanged += new System.EventHandler(this.lB_vector_SelectedIndexChanged);
            // 
            // b_AddVector
            // 
            this.b_AddVector.Enabled = false;
            this.b_AddVector.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_AddVector.Location = new System.Drawing.Point(15, 134);
            this.b_AddVector.Name = "b_AddVector";
            this.b_AddVector.Size = new System.Drawing.Size(110, 29);
            this.b_AddVector.TabIndex = 1;
            this.b_AddVector.Text = "Создать массив";
            this.b_AddVector.UseVisualStyleBackColor = true;
            this.b_AddVector.Click += new System.EventHandler(this.b_AddVector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список массивов:";
            // 
            // b_ShowAllVector
            // 
            this.b_ShowAllVector.Enabled = false;
            this.b_ShowAllVector.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_ShowAllVector.Location = new System.Drawing.Point(131, 134);
            this.b_ShowAllVector.Name = "b_ShowAllVector";
            this.b_ShowAllVector.Size = new System.Drawing.Size(110, 29);
            this.b_ShowAllVector.TabIndex = 3;
            this.b_ShowAllVector.Text = "Показать массив";
            this.b_ShowAllVector.UseVisualStyleBackColor = true;
            this.b_ShowAllVector.Click += new System.EventHandler(this.b_ShowAllVector_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(131, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Действие над массивом:";
            // 
            // r_Mult
            // 
            this.r_Mult.AutoSize = true;
            this.r_Mult.Checked = true;
            this.r_Mult.Location = new System.Drawing.Point(3, 3);
            this.r_Mult.Name = "r_Mult";
            this.r_Mult.Size = new System.Drawing.Size(139, 17);
            this.r_Mult.TabIndex = 5;
            this.r_Mult.TabStop = true;
            this.r_Mult.Text = "Умножение на скаляр";
            this.r_Mult.UseVisualStyleBackColor = true;
            // 
            // r_Div
            // 
            this.r_Div.AutoSize = true;
            this.r_Div.Location = new System.Drawing.Point(3, 26);
            this.r_Div.Name = "r_Div";
            this.r_Div.Size = new System.Drawing.Size(124, 17);
            this.r_Div.TabIndex = 6;
            this.r_Div.Text = "Деление на скаляр";
            this.r_Div.UseVisualStyleBackColor = true;
            // 
            // r_Add
            // 
            this.r_Add.AutoSize = true;
            this.r_Add.Location = new System.Drawing.Point(3, 49);
            this.r_Add.Name = "r_Add";
            this.r_Add.Size = new System.Drawing.Size(129, 17);
            this.r_Add.TabIndex = 7;
            this.r_Add.Text = "Сложение массивов";
            this.r_Add.UseVisualStyleBackColor = true;
            // 
            // r_Sub
            // 
            this.r_Sub.AutoSize = true;
            this.r_Sub.Location = new System.Drawing.Point(3, 72);
            this.r_Sub.Name = "r_Sub";
            this.r_Sub.Size = new System.Drawing.Size(133, 17);
            this.r_Sub.TabIndex = 8;
            this.r_Sub.Text = "Вычитание массивов";
            this.r_Sub.UseVisualStyleBackColor = true;
            // 
            // b_ActionVector
            // 
            this.b_ActionVector.Enabled = false;
            this.b_ActionVector.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_ActionVector.ForeColor = System.Drawing.Color.Green;
            this.b_ActionVector.Location = new System.Drawing.Point(247, 134);
            this.b_ActionVector.Name = "b_ActionVector";
            this.b_ActionVector.Size = new System.Drawing.Size(75, 29);
            this.b_ActionVector.TabIndex = 9;
            this.b_ActionVector.Text = "Действие";
            this.b_ActionVector.UseVisualStyleBackColor = true;
            this.b_ActionVector.Click += new System.EventHandler(this.b_ActionVector_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.r_Mult);
            this.panel1.Controls.Add(this.r_Div);
            this.panel1.Controls.Add(this.r_Sub);
            this.panel1.Controls.Add(this.r_Add);
            this.panel1.Location = new System.Drawing.Point(134, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 100);
            this.panel1.TabIndex = 10;
            // 
            // tB_InfoVector
            // 
            this.tB_InfoVector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_InfoVector.Location = new System.Drawing.Point(328, 28);
            this.tB_InfoVector.Multiline = true;
            this.tB_InfoVector.Name = "tB_InfoVector";
            this.tB_InfoVector.ReadOnly = true;
            this.tB_InfoVector.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB_InfoVector.Size = new System.Drawing.Size(143, 130);
            this.tB_InfoVector.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(325, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Информация о массиве:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 170);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_InfoVector);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_ActionVector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_ShowAllVector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_AddVector);
            this.Controls.Add(this.lB_vector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список массивов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lB_vector;
        private System.Windows.Forms.Button b_AddVector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_ShowAllVector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton r_Mult;
        private System.Windows.Forms.RadioButton r_Div;
        private System.Windows.Forms.RadioButton r_Add;
        private System.Windows.Forms.RadioButton r_Sub;
        private System.Windows.Forms.Button b_ActionVector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tB_InfoVector;
        private System.Windows.Forms.Label label3;
    }
}

