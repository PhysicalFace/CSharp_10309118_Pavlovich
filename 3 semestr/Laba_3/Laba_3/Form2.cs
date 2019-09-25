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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int lowRange, highRange;
        public string vectorName;
        public bool isClose = false;

        private void b_AddVector_Click(object sender, EventArgs e)
        {
            if (num_lowRange.Value <= num_highRange.Value && tB_vectorName.Text != "" && tB_vectorName.Text != "None")
            {
                vectorName = tB_vectorName.Text;
                lowRange = (int)num_lowRange.Value;
                highRange = (int)num_highRange.Value;

                Close();
            }
            else
                MessageBox.Show("Убедитесь, что вы дали имя массиву (кроме \"None\")\nи что: Левый индекс < Правый индекс !",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            isClose = true;
            Close();
        }

        public bool IsClose() { return isClose; }
        public int LowRange() { return lowRange; }
        public int HighRange() { return highRange; }
        public string VectorName() { return vectorName; }
    }
}
