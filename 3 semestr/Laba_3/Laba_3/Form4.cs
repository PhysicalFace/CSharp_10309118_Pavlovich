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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string vector1, vector2;
        public bool isClose = false;

        private void b_OK_Click(object sender, EventArgs e)
        {
            if (tB_vector1.Text != null && tB_vector2.Text != null)
            {
                vector1 = tB_vector1.Text;
                vector2 = tB_vector2.Text;
                Close();
            }
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            isClose = true;
            Close();
        }

        public bool IsClose() { return isClose; }
        public string Vector1() { return vector1; }
        public string Vector2() { return vector2; }
    }
}
