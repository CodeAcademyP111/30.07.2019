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
    public partial class UserDashboard : Form
    {
        private Form _login;
        private User _user;
        private P111Entities db;

        public UserDashboard(Form login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            db = new P111Entities();
        }

        private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            _login.Hide();

            dgvBooks.DataSource = db.Books.Select(b => new
            {
                b.Id,
                BookName=b.Name,
                Price=b.Price+" Azn",
                b.Count
            }).ToList();

            cmbBooks.Items.AddRange(db.Books.Select(b=>new CMBClass {
                Id=b.Id,
                Name=b.Name,
                Price=b.Price,
                Count=b.Count
            }).ToArray());
        }

        private void CmbAndDgvRefresh()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = db.Books.Select(b => new
            {
                b.Id,
                BookName = b.Name,
                Price = b.Price + " Azn",
                b.Count
            }).ToList();

            cmbBooks.Items.Clear();
            cmbBooks.Items.AddRange(db.Books.Select(b => new CMBClass
            {
                Id = b.Id,
                Name = b.Name,
                Price = b.Price,
                Count = b.Count
            }).ToArray());
        }

        private void cmbBooks_SelectedValueChanged(object sender, EventArgs e)
        {
            int Id = (cmbBooks.SelectedItem as CMBClass).Id;
            txtCurrentBookCount.Text = (cmbBooks.SelectedItem as CMBClass).Count.ToString();
            DgvRefreshOneData(Id);
        }

        private void DgvRefreshOneData(int Id)
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = db.Books.Where(b => b.Id == Id).Select(b => new
            {
                b.Id,
                BookName = b.Name,
                Price = b.Price + " Azn",
                b.Count
            }).ToList();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            CMBClass selectedBook = (cmbBooks.SelectedItem as CMBClass);
            
            int count=(int)nBookNumber.Value;

            if (selectedBook.Count < count)
            {
                MessageBox.Show("Books count not enough", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListClass lc = new ListClass()
            {
                Id = selectedBook.Id,
                Name = selectedBook.Name,
                Price = selectedBook.Price,
                Count = count
            };

            lbCellBooks.Items.Add(lc);

            decimal total = decimal.Parse(lblTotal.Text);
            lblTotal.Text = (total + (selectedBook.Price*count)).ToString();
            
            //alinma listine daxil edilmish kitablarin sayini chixmali
            selectedBook.Count -= count;

            //alinma listine daxil olunduqdan sonra inputlari temizlemeli
            txtCurrentBookCount.Text = "";
            cmbBooks.Text = "";
            nBookNumber.Value = 0;
        }
            

        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            ListClass lc = lbCellBooks.SelectedItem as ListClass;

            lbCellBooks.Items.Remove(lc);

            foreach (CMBClass CmbBook in cmbBooks.Items)
            {
                if (CmbBook.Id== lc.Id)
                {
                    CmbBook.Count += lc.Count;
                }
            }


            decimal total = decimal.Parse(lblTotal.Text);
            total -= (decimal)lc.Price * (decimal)lc.Count;
            lblTotal.Text = total.ToString();
        }

        private async void btnSell_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(DateTime.Today.Year, DateTime.Today.Month,DateTime.Today.Day);
            decimal total = decimal.Parse(lblTotal.Text);

            Order order = new Order() {Total=total,OrderTime= date,UserId= _user.Id };

            foreach (ListClass book in lbCellBooks.Items)
            {
                order.OrderBooks.Add(new OrderBook {BookId=book.Id,OrdersId= order.Id,Count= book.Count });
            }

            db.Orders.Add(order);
            await db.SaveChangesAsync();

            foreach (ListClass book in lbCellBooks.Items)
            {
                DecrimentBookCount(book);
            }

            MessageBox.Show("Order succesfully generated !");

            lbCellBooks.Items.Clear();
            lblTotal.Text = "0";
            CmbAndDgvRefresh();
        }

        private void DecrimentBookCount(ListClass book)
        {
            Book DecrimentBook=db.Books.Where(b => b.Id == book.Id).First();
            DecrimentBook.Count = DecrimentBook.Count - book.Count;
            db.SaveChanges();
        }
    }
}
