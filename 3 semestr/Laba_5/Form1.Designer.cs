namespace Laba_5
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
            this.b_Show = new System.Windows.Forms.Button();
            this.b_Choose = new System.Windows.Forms.Button();
            this.b_Animate = new System.Windows.Forms.Button();
            this.b_Stop = new System.Windows.Forms.Button();
            this.b_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Show
            // 
            this.b_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Show.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Show.Location = new System.Drawing.Point(64, 64);
            this.b_Show.Name = "b_Show";
            this.b_Show.Size = new System.Drawing.Size(64, 64);
            this.b_Show.TabIndex = 0;
            this.b_Show.Text = "Show picture";
            this.b_Show.UseVisualStyleBackColor = false;
            this.b_Show.Click += new System.EventHandler(this.b_Show_Click);
            // 
            // b_Choose
            // 
            this.b_Choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b_Choose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Choose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Choose.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Choose.Location = new System.Drawing.Point(160, 64);
            this.b_Choose.Name = "b_Choose";
            this.b_Choose.Size = new System.Drawing.Size(64, 64);
            this.b_Choose.TabIndex = 1;
            this.b_Choose.Text = "Choose";
            this.b_Choose.UseVisualStyleBackColor = false;
            this.b_Choose.Click += new System.EventHandler(this.b_Choose_Click);
            // 
            // b_Animate
            // 
            this.b_Animate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b_Animate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Animate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Animate.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Animate.Location = new System.Drawing.Point(64, 160);
            this.b_Animate.Name = "b_Animate";
            this.b_Animate.Size = new System.Drawing.Size(64, 64);
            this.b_Animate.TabIndex = 2;
            this.b_Animate.Text = "Animate";
            this.b_Animate.UseVisualStyleBackColor = false;
            this.b_Animate.Click += new System.EventHandler(this.b_Animate_Click);
            // 
            // b_Stop
            // 
            this.b_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Stop.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Stop.Location = new System.Drawing.Point(160, 160);
            this.b_Stop.Name = "b_Stop";
            this.b_Stop.Size = new System.Drawing.Size(32, 64);
            this.b_Stop.TabIndex = 3;
            this.b_Stop.Text = "S\r\nT\r\nO\r\nP";
            this.b_Stop.UseVisualStyleBackColor = false;
            this.b_Stop.Click += new System.EventHandler(this.b_Stop_Click);
            // 
            // b_Quit
            // 
            this.b_Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Quit.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Quit.Location = new System.Drawing.Point(192, 160);
            this.b_Quit.Name = "b_Quit";
            this.b_Quit.Size = new System.Drawing.Size(32, 64);
            this.b_Quit.TabIndex = 4;
            this.b_Quit.Text = "Q\r\nU\r\nI\r\nT";
            this.b_Quit.UseVisualStyleBackColor = false;
            this.b_Quit.Click += new System.EventHandler(this.b_Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.b_Quit);
            this.Controls.Add(this.b_Stop);
            this.Controls.Add(this.b_Animate);
            this.Controls.Add(this.b_Choose);
            this.Controls.Add(this.b_Show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анимация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Show;
        private System.Windows.Forms.Button b_Choose;
        private System.Windows.Forms.Button b_Animate;
        private System.Windows.Forms.Button b_Stop;
        private System.Windows.Forms.Button b_Quit;
    }
}

