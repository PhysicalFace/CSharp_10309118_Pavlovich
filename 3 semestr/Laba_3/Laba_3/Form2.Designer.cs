namespace Laba_3
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
            this.num_lowRange = new System.Windows.Forms.NumericUpDown();
            this.num_highRange = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_AddVector = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_vectorName = new System.Windows.Forms.TextBox();
            this.b_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_lowRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_highRange)).BeginInit();
            this.SuspendLayout();
            // 
            // num_lowRange
            // 
            this.num_lowRange.Location = new System.Drawing.Point(152, 39);
            this.num_lowRange.Name = "num_lowRange";
            this.num_lowRange.Size = new System.Drawing.Size(120, 20);
            this.num_lowRange.TabIndex = 0;
            // 
            // num_highRange
            // 
            this.num_highRange.Location = new System.Drawing.Point(152, 70);
            this.num_highRange.Name = "num_highRange";
            this.num_highRange.Size = new System.Drawing.Size(120, 20);
            this.num_highRange.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Левый индекс массива";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Правый индекс массива";
            // 
            // b_AddVector
            // 
            this.b_AddVector.Location = new System.Drawing.Point(15, 110);
            this.b_AddVector.Name = "b_AddVector";
            this.b_AddVector.Size = new System.Drawing.Size(106, 23);
            this.b_AddVector.TabIndex = 4;
            this.b_AddVector.Text = "Создать массив";
            this.b_AddVector.UseVisualStyleBackColor = true;
            this.b_AddVector.Click += new System.EventHandler(this.b_AddVector_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя массива";
            // 
            // tB_vectorName
            // 
            this.tB_vectorName.Location = new System.Drawing.Point(152, 13);
            this.tB_vectorName.Name = "tB_vectorName";
            this.tB_vectorName.Size = new System.Drawing.Size(120, 20);
            this.tB_vectorName.TabIndex = 6;
            // 
            // b_Cancel
            // 
            this.b_Cancel.Location = new System.Drawing.Point(166, 110);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(106, 23);
            this.b_Cancel.TabIndex = 7;
            this.b_Cancel.Text = "Отмена";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 152);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.tB_vectorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_AddVector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_highRange);
            this.Controls.Add(this.num_lowRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание массива";
            ((System.ComponentModel.ISupportInitialize)(this.num_lowRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_highRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_lowRange;
        private System.Windows.Forms.NumericUpDown num_highRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_AddVector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_vectorName;
        private System.Windows.Forms.Button b_Cancel;

    }
}