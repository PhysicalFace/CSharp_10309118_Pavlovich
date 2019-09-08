using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string res_summa, res_multiply, res_maxdivisor;

        #region Input_Button

        private void b_Input_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            res_summa = form2.Summa().ToString();
            res_multiply = form2.Multiply().ToString();
            res_maxdivisor = form2.MaxDivisor().ToString();

            b_Calc.Enabled = true;
        }

        #endregion Input_Button

        #region Calc_Button

        private void b_Calc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сумма : " + res_summa +
                "\nПроизведение : " + res_multiply +
                "\nНОД : " + res_maxdivisor
                );
        }

        #endregion Calc_Button

        #region Quit_Button

        private void b_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion Quit_Button

    }
}
