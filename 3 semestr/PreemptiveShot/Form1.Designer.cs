namespace PreemptiveShot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCleatLogs = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxVYr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxVXr = new System.Windows.Forms.TextBox();
            this.textBoxVr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYVa = new System.Windows.Forms.TextBox();
            this.textBoxXr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxYr = new System.Windows.Forms.TextBox();
            this.buttonStartAnimation = new System.Windows.Forms.Button();
            this.labelSpeedBullet = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonFindSolution = new System.Windows.Forms.Button();
            this.textBoxXVa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYa = new System.Windows.Forms.TextBox();
            this.textBoxXa = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PreemptiveShot.Properties.Resources.tmb_201871_8046;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonCleatLogs);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxLog);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 400);
            this.panel2.TabIndex = 28;
            // 
            // buttonCleatLogs
            // 
            this.buttonCleatLogs.BackColor = System.Drawing.Color.Gray;
            this.buttonCleatLogs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCleatLogs.ForeColor = System.Drawing.Color.Black;
            this.buttonCleatLogs.Location = new System.Drawing.Point(11, 372);
            this.buttonCleatLogs.Name = "buttonCleatLogs";
            this.buttonCleatLogs.Size = new System.Drawing.Size(255, 23);
            this.buttonCleatLogs.TabIndex = 29;
            this.buttonCleatLogs.Text = "Очистить логи";
            this.buttonCleatLogs.UseVisualStyleBackColor = false;
            this.buttonCleatLogs.Click += new System.EventHandler(this.buttonCleatLogs_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(9, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Логи:";
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.Silver;
            this.textBoxLog.ForeColor = System.Drawing.Color.Black;
            this.textBoxLog.Location = new System.Drawing.Point(11, 25);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(255, 343);
            this.textBoxLog.TabIndex = 3;
            this.textBoxLog.Text = resources.GetString("textBoxLog.Text");
            // 
            // panelMap
            // 
            this.panelMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMap.Location = new System.Drawing.Point(282, 2);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(400, 400);
            this.panelMap.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PreemptiveShot.Properties.Resources.tmb_201871_8046;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBoxVYr);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBoxVXr);
            this.panel1.Controls.Add(this.textBoxVr);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxYVa);
            this.panel1.Controls.Add(this.textBoxXr);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBoxYr);
            this.panel1.Controls.Add(this.buttonStartAnimation);
            this.panel1.Controls.Add(this.labelSpeedBullet);
            this.panel1.Controls.Add(this.buttonGenerate);
            this.panel1.Controls.Add(this.buttonFindSolution);
            this.panel1.Controls.Add(this.textBoxXVa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxYa);
            this.panel1.Controls.Add(this.textBoxXa);
            this.panel1.Location = new System.Drawing.Point(2, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 115);
            this.panel1.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(172, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "VXr:";
            // 
            // textBoxVYr
            // 
            this.textBoxVYr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxVYr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxVYr.Location = new System.Drawing.Point(321, 88);
            this.textBoxVYr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxVYr.Name = "textBoxVYr";
            this.textBoxVYr.ReadOnly = true;
            this.textBoxVYr.Size = new System.Drawing.Size(67, 23);
            this.textBoxVYr.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(283, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "VYr:";
            // 
            // textBoxVXr
            // 
            this.textBoxVXr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxVXr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxVXr.Location = new System.Drawing.Point(211, 88);
            this.textBoxVXr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxVXr.Name = "textBoxVXr";
            this.textBoxVXr.ReadOnly = true;
            this.textBoxVXr.Size = new System.Drawing.Size(67, 23);
            this.textBoxVXr.TabIndex = 32;
            // 
            // textBoxVr
            // 
            this.textBoxVr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxVr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxVr.Location = new System.Drawing.Point(100, 88);
            this.textBoxVr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxVr.Name = "textBoxVr";
            this.textBoxVr.Size = new System.Drawing.Size(67, 23);
            this.textBoxVr.TabIndex = 2;
            this.textBoxVr.Text = "70";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Скорость Vr:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(9, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Пушка:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(100, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Координаты: Xr:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(291, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Yr:";
            // 
            // textBoxYVa
            // 
            this.textBoxYVa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxYVa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxYVa.Location = new System.Drawing.Point(321, 36);
            this.textBoxYVa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxYVa.Name = "textBoxYVa";
            this.textBoxYVa.Size = new System.Drawing.Size(67, 23);
            this.textBoxYVa.TabIndex = 30;
            this.textBoxYVa.Text = "20";
            // 
            // textBoxXr
            // 
            this.textBoxXr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxXr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxXr.Location = new System.Drawing.Point(211, 63);
            this.textBoxXr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxXr.Name = "textBoxXr";
            this.textBoxXr.Size = new System.Drawing.Size(67, 23);
            this.textBoxXr.TabIndex = 10;
            this.textBoxXr.Text = "20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(281, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "VYa:";
            // 
            // textBoxYr
            // 
            this.textBoxYr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxYr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxYr.Location = new System.Drawing.Point(321, 63);
            this.textBoxYr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxYr.Name = "textBoxYr";
            this.textBoxYr.Size = new System.Drawing.Size(67, 23);
            this.textBoxYr.TabIndex = 11;
            this.textBoxYr.Text = "200";
            // 
            // buttonStartAnimation
            // 
            this.buttonStartAnimation.BackColor = System.Drawing.Color.DarkGray;
            this.buttonStartAnimation.Enabled = false;
            this.buttonStartAnimation.ForeColor = System.Drawing.Color.Maroon;
            this.buttonStartAnimation.Location = new System.Drawing.Point(408, 69);
            this.buttonStartAnimation.Name = "buttonStartAnimation";
            this.buttonStartAnimation.Size = new System.Drawing.Size(257, 23);
            this.buttonStartAnimation.TabIndex = 28;
            this.buttonStartAnimation.Text = "Начать анимацию";
            this.buttonStartAnimation.UseVisualStyleBackColor = false;
            this.buttonStartAnimation.Click += new System.EventHandler(this.buttonStartAnimation_Click);
            // 
            // labelSpeedBullet
            // 
            this.labelSpeedBullet.AutoSize = true;
            this.labelSpeedBullet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelSpeedBullet.ForeColor = System.Drawing.Color.Gold;
            this.labelSpeedBullet.Location = new System.Drawing.Point(409, 95);
            this.labelSpeedBullet.Name = "labelSpeedBullet";
            this.labelSpeedBullet.Size = new System.Drawing.Size(152, 16);
            this.labelSpeedBullet.TabIndex = 25;
            this.labelSpeedBullet.Text = "Время до столкновения:";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.DarkGray;
            this.buttonGenerate.ForeColor = System.Drawing.Color.Maroon;
            this.buttonGenerate.Location = new System.Drawing.Point(408, 11);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(257, 23);
            this.buttonGenerate.TabIndex = 23;
            this.buttonGenerate.Text = "Сгенерировать объекты";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonFindSolution
            // 
            this.buttonFindSolution.BackColor = System.Drawing.Color.DarkGray;
            this.buttonFindSolution.Enabled = false;
            this.buttonFindSolution.ForeColor = System.Drawing.Color.Maroon;
            this.buttonFindSolution.Location = new System.Drawing.Point(408, 40);
            this.buttonFindSolution.Name = "buttonFindSolution";
            this.buttonFindSolution.Size = new System.Drawing.Size(257, 23);
            this.buttonFindSolution.TabIndex = 26;
            this.buttonFindSolution.Text = "Найти решение";
            this.buttonFindSolution.UseVisualStyleBackColor = false;
            this.buttonFindSolution.Click += new System.EventHandler(this.buttonFindSolution_Click);
            // 
            // textBoxXVa
            // 
            this.textBoxXVa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxXVa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxXVa.Location = new System.Drawing.Point(212, 37);
            this.textBoxXVa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxXVa.Name = "textBoxXVa";
            this.textBoxXVa.Size = new System.Drawing.Size(67, 23);
            this.textBoxXVa.TabIndex = 12;
            this.textBoxXVa.Text = "-40";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(100, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Скорость: VXa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(289, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ya:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(99, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Координаты: Xa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Танк:";
            // 
            // textBoxYa
            // 
            this.textBoxYa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxYa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxYa.Location = new System.Drawing.Point(321, 11);
            this.textBoxYa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxYa.Name = "textBoxYa";
            this.textBoxYa.Size = new System.Drawing.Size(67, 23);
            this.textBoxYa.TabIndex = 1;
            this.textBoxYa.Text = "20";
            // 
            // textBoxXa
            // 
            this.textBoxXa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxXa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxXa.Location = new System.Drawing.Point(211, 11);
            this.textBoxXa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxXa.Name = "textBoxXa";
            this.textBoxXa.Size = new System.Drawing.Size(67, 23);
            this.textBoxXa.TabIndex = 0;
            this.textBoxXa.Text = "200";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMap);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт упреждающего выстрела";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxXa;
        private System.Windows.Forms.TextBox textBoxYa;
        private System.Windows.Forms.TextBox textBoxVr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxXVa;
        private System.Windows.Forms.TextBox textBoxYr;
        private System.Windows.Forms.TextBox textBoxXr;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSpeedBullet;
        private System.Windows.Forms.Button buttonFindSolution;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Button buttonStartAnimation;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCleatLogs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxYVa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxVYr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxVXr;
    }
}

