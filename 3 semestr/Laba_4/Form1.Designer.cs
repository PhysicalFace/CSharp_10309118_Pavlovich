namespace Laba_4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Field = new System.Windows.Forms.DataGridView();
            this.b_Generate = new System.Windows.Forms.Button();
            this.l_aims = new System.Windows.Forms.Label();
            this.b_StartScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Field)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Field
            // 
            this.dgv_Field.AllowUserToAddRows = false;
            this.dgv_Field.AllowUserToDeleteRows = false;
            this.dgv_Field.AllowUserToResizeColumns = false;
            this.dgv_Field.AllowUserToResizeRows = false;
            this.dgv_Field.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Field.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Field.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgv_Field.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_Field.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Field.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Field.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Field.ColumnHeadersVisible = false;
            this.dgv_Field.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dgv_Field.Enabled = false;
            this.dgv_Field.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Field.Location = new System.Drawing.Point(12, 12);
            this.dgv_Field.Name = "dgv_Field";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Field.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Field.RowHeadersVisible = false;
            this.dgv_Field.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Field.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Field.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SandyBrown;
            this.dgv_Field.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_Field.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Field.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.dgv_Field.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.OliveDrab;
            this.dgv_Field.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Field.RowTemplate.Height = 100;
            this.dgv_Field.RowTemplate.ReadOnly = true;
            this.dgv_Field.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Field.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_Field.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Field.Size = new System.Drawing.Size(300, 300);
            this.dgv_Field.TabIndex = 0;
            this.dgv_Field.TabStop = false;
            // 
            // b_Generate
            // 
            this.b_Generate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Generate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.b_Generate.Location = new System.Drawing.Point(318, 12);
            this.b_Generate.Name = "b_Generate";
            this.b_Generate.Size = new System.Drawing.Size(144, 43);
            this.b_Generate.TabIndex = 1;
            this.b_Generate.Text = "Сгенерировать\r\nкарту";
            this.b_Generate.UseVisualStyleBackColor = true;
            this.b_Generate.Click += new System.EventHandler(this.b_Generate_Click);
            // 
            // l_aims
            // 
            this.l_aims.AutoSize = true;
            this.l_aims.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_aims.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_aims.ForeColor = System.Drawing.Color.Green;
            this.l_aims.Location = new System.Drawing.Point(318, 272);
            this.l_aims.Name = "l_aims";
            this.l_aims.Size = new System.Drawing.Size(144, 40);
            this.l_aims.TabIndex = 2;
            this.l_aims.Text = "Обнаружено целей:\r\n0";
            this.l_aims.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_StartScan
            // 
            this.b_StartScan.Enabled = false;
            this.b_StartScan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_StartScan.ForeColor = System.Drawing.Color.Maroon;
            this.b_StartScan.Location = new System.Drawing.Point(318, 61);
            this.b_StartScan.Name = "b_StartScan";
            this.b_StartScan.Size = new System.Drawing.Size(144, 43);
            this.b_StartScan.TabIndex = 3;
            this.b_StartScan.Text = "Начать разведку";
            this.b_StartScan.UseVisualStyleBackColor = true;
            this.b_StartScan.Click += new System.EventHandler(this.b_StartScan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Laba_4.Properties.Resources.desert;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(469, 327);
            this.Controls.Add(this.b_StartScan);
            this.Controls.Add(this.l_aims);
            this.Controls.Add(this.b_Generate);
            this.Controls.Add(this.dgv_Field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авиаразведка";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Generate;
        public System.Windows.Forms.DataGridView dgv_Field;
        private System.Windows.Forms.Label l_aims;
        private System.Windows.Forms.Button b_StartScan;
    }
}

