using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tjmodul12_2311104049
{
    public static class HitungHelper
    {
        public static int CariNilaiPangkat(int a, int b)
        {
            if (b == 0)
                return 1;
            if (b < 0)
                return -1;
            try
            {
                checked
                {
                    int hasil = 1;
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                    }
                    if (b > 10 || a > 100)
                        return -2;
                    return hasil;
                }
            }
            catch (OverflowException)
            {
                return -3;
            }
        }
    }
    public partial class Form1 : Form
    {
        // Import Win32 API untuk membuat placeholder (cue banner)
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        public Form1()
        {
            InitializeComponent();
            SetPlaceholder(txtBase, "Masukkan basis (a)");
            SetPlaceholder(txtExponent, "Masukkan eksponen (b)");
        }

        private void SetPlaceholder(TextBox textBox, string text)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, text);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtBase.Text);
                int b = int.Parse(txtExponent.Text);
                int hasil = HitungHelper.CariNilaiPangkat(a, b); // Sudah benar dipanggil dari static class
                lblOutput.Text = $"Hasil: {hasil}";
            }
            catch (FormatException)
            {
                lblOutput.Text = "Input harus berupa angka bulat.";
            }
            catch (OverflowException)
            {
                lblOutput.Text = "Input angka terlalu besar.";
            }
        }

        private void txtBase_TextChanged(object sender, EventArgs e) { }
        private void txtExponent_TextChanged(object sender, EventArgs e) { }
        private void lblOutput_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
