using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void b_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(tB_speed.Text) > 0)
                {
                    MessageBox.Show("Настройка завершена!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка! Убедитесь, что набранная скорость неотрицательная.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Ошибка! Убедитесь, что набранная скорость неотрицательная.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
