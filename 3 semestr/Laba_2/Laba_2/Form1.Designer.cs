namespace Laba_2
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
            this.lB_workers = new System.Windows.Forms.ListBox();
            this.b_Load = new System.Windows.Forms.Button();
            this.tB_workers = new System.Windows.Forms.TextBox();
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Add = new System.Windows.Forms.Button();
            this.b_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rB_Surname = new System.Windows.Forms.RadioButton();
            this.rB_Initials = new System.Windows.Forms.RadioButton();
            this.rB_Post = new System.Windows.Forms.RadioButton();
            this.rB_Date = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_Search = new System.Windows.Forms.Button();
            this.tB_search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rB_sortNone = new System.Windows.Forms.RadioButton();
            this.b_Revers = new System.Windows.Forms.Button();
            this.b_Sort = new System.Windows.Forms.Button();
            this.rB_sortDate = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lB_workers
            // 
            this.lB_workers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lB_workers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lB_workers.FormattingEnabled = true;
            this.lB_workers.Location = new System.Drawing.Point(12, 30);
            this.lB_workers.Name = "lB_workers";
            this.lB_workers.Size = new System.Drawing.Size(195, 264);
            this.lB_workers.TabIndex = 0;
            this.lB_workers.SelectedIndexChanged += new System.EventHandler(this.lB_workers_SelectedIndexChanged);
            // 
            // b_Load
            // 
            this.b_Load.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Load.Location = new System.Drawing.Point(408, 240);
            this.b_Load.Name = "b_Load";
            this.b_Load.Size = new System.Drawing.Size(91, 54);
            this.b_Load.TabIndex = 1;
            this.b_Load.Text = "Загрузить список";
            this.b_Load.UseVisualStyleBackColor = true;
            this.b_Load.Click += new System.EventHandler(this.b_Load_Click);
            // 
            // tB_workers
            // 
            this.tB_workers.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tB_workers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_workers.Location = new System.Drawing.Point(213, 30);
            this.tB_workers.Multiline = true;
            this.tB_workers.Name = "tB_workers";
            this.tB_workers.ReadOnly = true;
            this.tB_workers.Size = new System.Drawing.Size(383, 84);
            this.tB_workers.TabIndex = 2;
            // 
            // b_Save
            // 
            this.b_Save.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Save.Location = new System.Drawing.Point(505, 240);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(91, 54);
            this.b_Save.TabIndex = 3;
            this.b_Save.Text = "Сохранить список";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // b_Add
            // 
            this.b_Add.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.b_Add.Location = new System.Drawing.Point(213, 240);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(91, 54);
            this.b_Add.TabIndex = 4;
            this.b_Add.Text = "Добавить сотрудника";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // b_Delete
            // 
            this.b_Delete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.b_Delete.Location = new System.Drawing.Point(310, 240);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(91, 54);
            this.b_Delete.TabIndex = 5;
            this.b_Delete.Text = "Удалить сотрудника";
            this.b_Delete.UseVisualStyleBackColor = true;
            this.b_Delete.Click += new System.EventHandler(this.b_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Информация о сотруднике:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Всего сотрудников: ";
            // 
            // rB_Surname
            // 
            this.rB_Surname.AutoSize = true;
            this.rB_Surname.Checked = true;
            this.rB_Surname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_Surname.Location = new System.Drawing.Point(3, 58);
            this.rB_Surname.Name = "rB_Surname";
            this.rB_Surname.Size = new System.Drawing.Size(69, 17);
            this.rB_Surname.TabIndex = 8;
            this.rB_Surname.TabStop = true;
            this.rB_Surname.Text = "Фамилия";
            this.rB_Surname.UseVisualStyleBackColor = true;
            // 
            // rB_Initials
            // 
            this.rB_Initials.AutoSize = true;
            this.rB_Initials.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_Initials.Location = new System.Drawing.Point(3, 81);
            this.rB_Initials.Name = "rB_Initials";
            this.rB_Initials.Size = new System.Drawing.Size(76, 17);
            this.rB_Initials.TabIndex = 9;
            this.rB_Initials.TabStop = true;
            this.rB_Initials.Text = "Инициалы";
            this.rB_Initials.UseVisualStyleBackColor = true;
            // 
            // rB_Post
            // 
            this.rB_Post.AutoSize = true;
            this.rB_Post.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_Post.Location = new System.Drawing.Point(85, 59);
            this.rB_Post.Name = "rB_Post";
            this.rB_Post.Size = new System.Drawing.Size(82, 17);
            this.rB_Post.TabIndex = 10;
            this.rB_Post.TabStop = true;
            this.rB_Post.Text = "Должность";
            this.rB_Post.UseVisualStyleBackColor = true;
            // 
            // rB_Date
            // 
            this.rB_Date.AutoSize = true;
            this.rB_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_Date.Location = new System.Drawing.Point(85, 77);
            this.rB_Date.Name = "rB_Date";
            this.rB_Date.Size = new System.Drawing.Size(139, 30);
            this.rB_Date.TabIndex = 11;
            this.rB_Date.Text = "Год поступления\r\nсотрудника на работу";
            this.rB_Date.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.b_Search);
            this.panel1.Controls.Add(this.tB_search);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rB_Surname);
            this.panel1.Controls.Add(this.rB_Date);
            this.panel1.Controls.Add(this.rB_Initials);
            this.panel1.Controls.Add(this.rB_Post);
            this.panel1.Location = new System.Drawing.Point(213, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 114);
            this.panel1.TabIndex = 12;
            // 
            // b_Search
            // 
            this.b_Search.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Search.Location = new System.Drawing.Point(178, 31);
            this.b_Search.Name = "b_Search";
            this.b_Search.Size = new System.Drawing.Size(75, 23);
            this.b_Search.TabIndex = 15;
            this.b_Search.Text = "Поиск";
            this.b_Search.UseVisualStyleBackColor = true;
            this.b_Search.Click += new System.EventHandler(this.b_Search_Click);
            // 
            // tB_search
            // 
            this.tB_search.Location = new System.Drawing.Point(3, 31);
            this.tB_search.Name = "tB_search";
            this.tB_search.Size = new System.Drawing.Size(169, 20);
            this.tB_search.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-1, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Искать по критерию:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rB_sortNone);
            this.panel2.Controls.Add(this.b_Revers);
            this.panel2.Controls.Add(this.b_Sort);
            this.panel2.Controls.Add(this.rB_sortDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(481, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 114);
            this.panel2.TabIndex = 13;
            // 
            // rB_sortNone
            // 
            this.rB_sortNone.AutoSize = true;
            this.rB_sortNone.Checked = true;
            this.rB_sortNone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_sortNone.Location = new System.Drawing.Point(7, 30);
            this.rB_sortNone.Name = "rB_sortNone";
            this.rB_sortNone.Size = new System.Drawing.Size(50, 17);
            this.rB_sortNone.TabIndex = 18;
            this.rB_sortNone.TabStop = true;
            this.rB_sortNone.Text = "None";
            this.rB_sortNone.UseVisualStyleBackColor = true;
            // 
            // b_Revers
            // 
            this.b_Revers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Revers.ForeColor = System.Drawing.Color.DarkRed;
            this.b_Revers.Location = new System.Drawing.Point(7, 81);
            this.b_Revers.Name = "b_Revers";
            this.b_Revers.Size = new System.Drawing.Size(94, 23);
            this.b_Revers.TabIndex = 17;
            this.b_Revers.Text = "Revers";
            this.b_Revers.UseVisualStyleBackColor = true;
            this.b_Revers.Click += new System.EventHandler(this.b_Revers_Click);
            // 
            // b_Sort
            // 
            this.b_Sort.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Sort.Location = new System.Drawing.Point(7, 53);
            this.b_Sort.Name = "b_Sort";
            this.b_Sort.Size = new System.Drawing.Size(94, 23);
            this.b_Sort.TabIndex = 16;
            this.b_Sort.Text = "Sort";
            this.b_Sort.UseVisualStyleBackColor = true;
            this.b_Sort.Click += new System.EventHandler(this.b_Sort_Click);
            // 
            // rB_sortDate
            // 
            this.rB_sortDate.AutoSize = true;
            this.rB_sortDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB_sortDate.Location = new System.Drawing.Point(57, 30);
            this.rB_sortDate.Name = "rB_sortDate";
            this.rB_sortDate.Size = new System.Drawing.Size(44, 17);
            this.rB_sortDate.TabIndex = 16;
            this.rB_sortDate.Text = "Год";
            this.rB_sortDate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Сортировка:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 301);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.tB_workers);
            this.Controls.Add(this.b_Load);
            this.Controls.Add(this.lB_workers);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список рабочих";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lB_workers;
        private System.Windows.Forms.Button b_Load;
        private System.Windows.Forms.TextBox tB_workers;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Button b_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rB_Surname;
        private System.Windows.Forms.RadioButton rB_Initials;
        private System.Windows.Forms.RadioButton rB_Post;
        private System.Windows.Forms.RadioButton rB_Date;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_search;
        private System.Windows.Forms.Button b_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_Revers;
        private System.Windows.Forms.Button b_Sort;
        private System.Windows.Forms.RadioButton rB_sortNone;
        private System.Windows.Forms.RadioButton rB_sortDate;
    }
}

