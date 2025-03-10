using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tjmodul3_2311104049
{
    public partial class Form1: Form
    {
        private string inputAngka = "";
        private int angka1 = 0;
        private int angka2 = 0;
        private bool operasiPenjumlahan = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                inputAngka += btn.Text;
                lblOutput.Text = inputAngka;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                inputAngka += btn.Text;
                lblOutput.Text = inputAngka;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                inputAngka += btn.Text;
                lblOutput.Text = inputAngka;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                inputAngka += btn.Text;
                lblOutput.Text = inputAngka;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                inputAngka += btn.Text;
                lblOutput.Text = inputAngka;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                inputAngka += btn.Text;
                lblOutput.Text = inputAngka;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                inputAngka += btn.Text;
                lblOutput.Text = inputAngka;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                inputAngka += btn.Text;
                lblOutput.Text = inputAngka;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                inputAngka += btn.Text;
                lblOutput.Text = inputAngka;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                inputAngka += btn.Text;
                lblOutput.Text = inputAngka;
            }
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputAngka))
            {
                angka1 = int.Parse(inputAngka);
                inputAngka = "";
                operasiPenjumlahan = true;
            }
        }

        private void btnsamadengan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputAngka) && operasiPenjumlahan)
            {
                angka2 = int.Parse(inputAngka);
                int hasil = angka1 + angka2;
                lblOutput.Text = hasil.ToString();

                // Reset variabel
                inputAngka = "";
                angka1 = 0;
                angka2 = 0;
                operasiPenjumlahan = false;
            }
        }
    }
}
