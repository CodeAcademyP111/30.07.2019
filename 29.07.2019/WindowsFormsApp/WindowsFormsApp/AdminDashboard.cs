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
    public partial class AdminDashboard : Form
    {
        private Form _login;
        private User _user;
        private P111Entities db;

        public AdminDashboard(Form login,User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            db = new P111Entities();
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            _login.Hide();

            dgvUsers.DataSource = db.Users.Where(u=>u.Deleted==false).Select(u => new
            {
                u.Id,
                Fullname=u.Name+" "+u.Surname,
                u.Levels,
                u.Status
            }).OrderByDescending(u=>u.Id).ToList();

            //new users count
            NewUserButtonText();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            DgvNewUser();
        }

        private async void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvUsers.Rows[e.RowIndex].Cells[0].Value;

            User usr = db.Users.Find(id);

            DialogResult result=MessageBox.Show($"Are you sure confirm {usr.Name} {usr.Surname} ?","Information"
                ,MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                usr.Status = true;
            }
            else
            {
                usr.Deleted = true;
            }
            await db.SaveChangesAsync();
            NewUserButtonText();
            DgvNewUser();
        }

        private void NewUserButtonText()
        {
            //new users count
            int count = db.Users.Where(u => u.Deleted == false)
                .Where(u => u.Status == false).Count();

            btnNewUser.Text = "New User: " + count;
        }

        private void DgvNewUser()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = db.Users.Where(u => u.Deleted == false)
                .Where(u => u.Status == false).Select(u => new
                {
                    u.Id,
                    Fullname = u.Name + " " + u.Surname,
                    u.Levels,
                    u.Status
                }).OrderByDescending(u => u.Id).ToList();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Reports().ShowDialog();
        }
    }
}
