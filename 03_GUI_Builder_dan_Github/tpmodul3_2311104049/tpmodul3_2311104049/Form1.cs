using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul3_2311104049
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string btnKirim = input.Text;
            if (btnKirim.Equals("NAMA_PRAKTIKAN", StringComparison.OrdinalIgnoreCase))
            {
                lblOutput.Text = $"Halo {btnKirim}";
            }
            else
            {
                lblOutput.Text = "Nama tidak dikenali.";
            }
        }
    }
}
