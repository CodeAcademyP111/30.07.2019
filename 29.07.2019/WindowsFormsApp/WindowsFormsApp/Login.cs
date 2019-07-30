using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {

        private P111Entities db;
        private User usr;

        public Login()
        {
            InitializeComponent();
            db = new P111Entities();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register rgs = new Register(this);
            rgs.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text.Trim();
            string password = txtLoginPass.Text.Trim();

            if(CheckLogin(email, password))
            {
                if (usr.Levels)
                {
                    new AdminDashboard(this,usr).Show();
                }
                else
                {
                    new UserDashboard(this,usr).Show();
                }
            }
        }

        private bool CheckLogin(string email,string pass)
        {
            if(email=="" || pass == "")
            {
                MessageBox.Show("Please fill all input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string hashPass = Helpers.HashPassword(pass);

            usr = db.Users.Where(u => u.Email == email)
                .Where(u => u.Password == hashPass).
                Where(u=>u.Deleted==false).FirstOrDefault();
            if (usr == null)
            {
                MessageBox.Show("This user not exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (usr.Status == false)
            {
                MessageBox.Show("User not confirm !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
