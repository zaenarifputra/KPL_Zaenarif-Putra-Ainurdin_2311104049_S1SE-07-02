using System;
using System.Collections.Generic;
using System.IO; 
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;
using tjmodul15_2311104049.Helpers;
using tjmodul15_2311104049.Models;

namespace tjmodul15_2311104049
{
    public partial class FormRegister : Form
    {
        private readonly string userFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (!IsValidUsername(username))
            {
                MessageBox.Show("Username hanya boleh huruf (3-20 karakter).", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPassword(password, username))
            {
                MessageBox.Show("Password harus 8-20 karakter, mengandung angka & simbol, dan tidak mengandung username.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashedPassword = SecurityHelper.HashPassword(password);

            List<User> users = new List<User>();

            try
            {
                if (File.Exists(userFile))
                {
                    string json = File.ReadAllText(userFile);
                    if (json.Trim().StartsWith("["))
                    {
                        users = JsonConvert.DeserializeObject<List<User>>(json);
                    }
                    else
                    {
                        MessageBox.Show("Format users.json salah. Harus berupa array JSON.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membaca users.json: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (users.Exists(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Username sudah terdaftar.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            users.Add(new User { Username = username, Password = hashedPassword });
            File.WriteAllText(userFile, JsonConvert.SerializeObject(users, Formatting.Indented));

            MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Menutup form setelah registrasi sukses (opsional)
        }

        private bool IsValidUsername(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z]{3,20}$");
        }

        private bool IsValidPassword(string password, string username)
        {
            return password.Length >= 8 &&
                   password.Length <= 20 &&
                   Regex.IsMatch(password, @"[0-9]") &&
                   Regex.IsMatch(password, @"[!@#$%^&*]") &&
                   !password.ToLower().Contains(username.ToLower());
        }
    }
}
