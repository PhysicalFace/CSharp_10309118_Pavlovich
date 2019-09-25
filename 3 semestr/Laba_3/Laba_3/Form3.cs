using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public int skalyar;
        public bool isClose = false;

        private void b_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (tB_skalyar.Text != null)
                {
                    skalyar = Int32.Parse(tB_skalyar.Text);
                    Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Скаляр неверного формата!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            isClose = true;
            Close();
        }

        public bool IsClose() { return isClose; }
        public int Skalyar() { return skalyar; }
    }
}
