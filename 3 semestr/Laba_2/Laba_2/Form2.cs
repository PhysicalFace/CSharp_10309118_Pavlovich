using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class Form2 : Form
    {
        string surname, initials, post;
        int date;

        public Form2()
        {
            InitializeComponent();
        }

        #region Кнопка_добавления_сотрудника

        private void b_Add_Click(object sender, EventArgs e)
        {
            if(tB_Surname.Text != "" && tB_Initials.Text != "" && tB_Post.Text != "" && tB_Date.Text != "")
            {
                try
                {
                    surname = tB_Surname.Text;
                    initials = tB_Initials.Text;
                    post = tB_Post.Text;
                    date = Int32.Parse(tB_Date.Text);

                    Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Возникла ошибка при вводе данных!");
                }
            }
            else
                MessageBox.Show("Ошибка! Вы ввели не все данные.");
        }

        #endregion

        #region Кнопка_отмены

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Методы

        public string Surname()
        {
            return surname;
        }
        public string Initials()
        {
            return initials;
        }
        public string Post()
        {
            return post;
        }
        public int Date()
        {
            return date;
        }

        #endregion
       
    }
}
