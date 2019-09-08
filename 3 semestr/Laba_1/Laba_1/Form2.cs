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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double summa, multiply;
        int maxdivisor;

        #region Button

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cB_summa.Checked)
                {
                    summa = double.Parse(tB_number1.Text) + double.Parse(tB_number2.Text);
                }

                if (cB_multiply.Checked)
                {
                    multiply = double.Parse(tB_number1.Text) * double.Parse(tB_number2.Text);
                }

                if (cB_maxdivisor.Checked)
                {
                    int n = double.Parse(tB_number1.Text) >= double.Parse(tB_number2.Text) ? (int)double.Parse(tB_number1.Text) : (int)double.Parse(tB_number2.Text);

                    for(int i = 1; i < n; i++)
                    {
                        double a = double.Parse(tB_number1.Text);
                        double b = double.Parse(tB_number2.Text);

                        if (a % i == 0 && b % i == 0)
                            maxdivisor = i;
                    }
                }

                if(!cB_summa.Checked && !cB_multiply.Enabled && !cB_maxdivisor.Enabled)
                    Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Произошла ошибка!");
            }
        }

        #endregion Button

        #region Methods

        public double Summa()
        {
            return summa;
        }

        public double Multiply()
        {
            return multiply;
        }

        public int MaxDivisor()
        {
            return maxdivisor;
        }

        #endregion Methods

    }
}
