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
    public partial class Reports : Form
    {
        private P111Entities db;

        public Reports()
        {
            InitializeComponent();
            db = new P111Entities();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            dgvReport.DataSource = db.Orders.Select(o => new
            {
                o.Id,
                FulnameUser=o.User.Name+" "+o.User.Surname,
                Amount=o.Total,
                o.OrderTime
            }).ToList();
        }

        private void dgvReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id =(int) dgvReport.Rows[e.RowIndex].Cells[0].Value;

            var books = db.OrderBooks.Where(ob => ob.OrdersId == Id).Select(ob => ob.Book);

            string str="";
            foreach (Book book in books)
            {
                int count =(int)db.OrderBooks.Where(ob => ob.BookId == book.Id && ob.OrdersId == Id).First().Count;
                
                if (books.First().Id == book.Id)
                {
                    str += book.Name+" - "+ count;
                }
                else
                {
                    str +=" , "+ book.Name + " - " + count;
                }
            }
            txtBookList.Text = str;
        }
    }
}
