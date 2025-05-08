using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tpmodul12_2311104049
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cekButton_Click(object sender, EventArgs e)
        {
            int angka;
            if (int.TryParse(inputTextBox.Text, out angka))
            {
                string hasil = CariTandaBilangan(angka);
                outputLabel.Text = hasil;
            }
            else
            {
                outputLabel.Text = "Input tidak valid";
            }
        }
        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }
        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
