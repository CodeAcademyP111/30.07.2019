using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class Register : Form
    {
        private Form _login;
        private P111Entities db;

        public Register(Form login)
        {
            InitializeComponent();
            _login = login;
            db = new P111Entities();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            _login.Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Show();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtRgsName.Text.Trim();
            string surname = txtRgsSurname.Text.Trim();
            string password = txtRgsPass.Text.Trim();
            string password_repeat = txtRgsRepeatPass.Text.Trim();
            string email = txtRgsEmail.Text.Trim();

            if(CheckRegisteration(name,surname,password,password_repeat, email))
            {
                string hashPassword = Helpers.HashPassword(password);

                User usr = new User()
                {
                    Name=name,
                    Surname=surname,
                    Password= hashPassword,
                    Email=email
                };

                db.Users.Add(usr);

                await db.SaveChangesAsync();

                MessageBox.Show("Registration is successfully, please wait confirmation","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private bool CheckRegisteration(string name, string surname, string password, string password_repeat, string email)
        {
            if(name=="" || surname=="" || password=="" || password_repeat=="" || email == "")
            {
                MessageBox.Show("Please fill all input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(password!= password_repeat)
            {
                MessageBox.Show("Please repeat password correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                MailAddress mail = new MailAddress(email);
            }
            catch (Exception)
            {
                MessageBox.Show("Please add exist emil", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(db.Users.Any(u=>u.Email== email))
            {
                MessageBox.Show("This emial already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
