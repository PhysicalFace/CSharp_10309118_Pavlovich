
namespace ImageInjector
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button selFile1Btn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button selFile2Btn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button selFileForEndode;
		private System.Windows.Forms.Button saveFileDecoded;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.selFileForEndode = new System.Windows.Forms.Button();
            this.selFile1Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFileDecoded = new System.Windows.Forms.Button();
            this.selFile2Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxEncoded = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxForDecode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxEncoded);
            this.panel1.Controls.Add(this.selFileForEndode);
            this.panel1.Controls.Add(this.selFile1Btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(9, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 382);
            this.panel1.TabIndex = 0;
            // 
            // selFileForEndode
            // 
            this.selFileForEndode.Location = new System.Drawing.Point(38, 260);
            this.selFileForEndode.Margin = new System.Windows.Forms.Padding(2);
            this.selFileForEndode.Name = "selFileForEndode";
            this.selFileForEndode.Size = new System.Drawing.Size(225, 33);
            this.selFileForEndode.TabIndex = 6;
            this.selFileForEndode.Text = "Выбрать шифруемый файл";
            this.selFileForEndode.UseVisualStyleBackColor = true;
            this.selFileForEndode.Click += new System.EventHandler(this.SelFileForEndodeClick);
            // 
            // selFile1Btn
            // 
            this.selFile1Btn.Location = new System.Drawing.Point(235, 2);
            this.selFile1Btn.Margin = new System.Windows.Forms.Padding(2);
            this.selFile1Btn.Name = "selFile1Btn";
            this.selFile1Btn.Size = new System.Drawing.Size(80, 27);
            this.selFile1Btn.TabIndex = 5;
            this.selFile1Btn.Text = "Выбрать";
            this.selFile1Btn.UseVisualStyleBackColor = true;
            this.selFile1Btn.Click += new System.EventHandler(this.SelFile1BtnClick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Изображение для шифрования:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(2, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Шифрование файла:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(333, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дешифрование файла:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxForDecode);
            this.panel2.Controls.Add(this.saveFileDecoded);
            this.panel2.Controls.Add(this.selFile2Btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(332, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 382);
            this.panel2.TabIndex = 2;
            // 
            // saveFileDecoded
            // 
            this.saveFileDecoded.Location = new System.Drawing.Point(49, 260);
            this.saveFileDecoded.Margin = new System.Windows.Forms.Padding(2);
            this.saveFileDecoded.Name = "saveFileDecoded";
            this.saveFileDecoded.Size = new System.Drawing.Size(225, 33);
            this.saveFileDecoded.TabIndex = 9;
            this.saveFileDecoded.Text = "Сохранить файл как";
            this.saveFileDecoded.UseVisualStyleBackColor = true;
            this.saveFileDecoded.Click += new System.EventHandler(this.SaveFileDecodedClick);
            // 
            // selFile2Btn
            // 
            this.selFile2Btn.Location = new System.Drawing.Point(235, 2);
            this.selFile2Btn.Margin = new System.Windows.Forms.Padding(2);
            this.selFile2Btn.Name = "selFile2Btn";
            this.selFile2Btn.Size = new System.Drawing.Size(80, 27);
            this.selFile2Btn.TabIndex = 8;
            this.selFile2Btn.Text = "Выбрать";
            this.selFile2Btn.UseVisualStyleBackColor = true;
            this.selFile2Btn.Click += new System.EventHandler(this.SelFile2BtnClick);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(2, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Изображение для расшифровки:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(2, 32);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 208);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxEncoded
            // 
            this.textBoxEncoded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxEncoded.Location = new System.Drawing.Point(38, 334);
            this.textBoxEncoded.Name = "textBoxEncoded";
            this.textBoxEncoded.ReadOnly = true;
            this.textBoxEncoded.Size = new System.Drawing.Size(225, 20);
            this.textBoxEncoded.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(88, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сгенерированный ключ";
            // 
            // textBoxForDecode
            // 
            this.textBoxForDecode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxForDecode.Location = new System.Drawing.Point(49, 334);
            this.textBoxForDecode.Name = "textBoxForDecode";
            this.textBoxForDecode.Size = new System.Drawing.Size(225, 20);
            this.textBoxForDecode.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(93, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ключ для дешифрования";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageInjector";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEncoded;
        private System.Windows.Forms.TextBox textBoxForDecode;
        private System.Windows.Forms.Label label6;
	}
}
