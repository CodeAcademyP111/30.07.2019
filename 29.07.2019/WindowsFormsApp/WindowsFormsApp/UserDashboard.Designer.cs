namespace WindowsFormsApp
{
    partial class UserDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.nBookNumber = new System.Windows.Forms.NumericUpDown();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbCellBooks = new System.Windows.Forms.ListBox();
            this.txtCurrentBookCount = new System.Windows.Forms.TextBox();
            this.btnRemoveList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBookNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBooks.Location = new System.Drawing.Point(0, 247);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(773, 189);
            this.dgvBooks.TabIndex = 0;
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(33, 34);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(160, 21);
            this.cmbBooks.TabIndex = 1;
            this.cmbBooks.SelectedValueChanged += new System.EventHandler(this.cmbBooks_SelectedValueChanged);
            // 
            // nBookNumber
            // 
            this.nBookNumber.Location = new System.Drawing.Point(33, 80);
            this.nBookNumber.Name = "nBookNumber";
            this.nBookNumber.Size = new System.Drawing.Size(120, 20);
            this.nBookNumber.TabIndex = 3;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(33, 132);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(160, 26);
            this.btnAddSale.TabIndex = 4;
            this.btnAddSale.Text = "Add List";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(566, 91);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(105, 26);
            this.btnSell.TabIndex = 5;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(609, 34);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "0";
            // 
            // lbCellBooks
            // 
            this.lbCellBooks.FormattingEnabled = true;
            this.lbCellBooks.Location = new System.Drawing.Point(351, 34);
            this.lbCellBooks.Name = "lbCellBooks";
            this.lbCellBooks.Size = new System.Drawing.Size(165, 160);
            this.lbCellBooks.TabIndex = 8;
            // 
            // txtCurrentBookCount
            // 
            this.txtCurrentBookCount.Location = new System.Drawing.Point(219, 34);
            this.txtCurrentBookCount.Name = "txtCurrentBookCount";
            this.txtCurrentBookCount.ReadOnly = true;
            this.txtCurrentBookCount.Size = new System.Drawing.Size(55, 20);
            this.txtCurrentBookCount.TabIndex = 9;
            // 
            // btnRemoveList
            // 
            this.btnRemoveList.Location = new System.Drawing.Point(378, 200);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(105, 26);
            this.btnRemoveList.TabIndex = 10;
            this.btnRemoveList.Text = "Remove List";
            this.btnRemoveList.UseVisualStyleBackColor = true;
            this.btnRemoveList.Click += new System.EventHandler(this.btnRemoveList_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 436);
            this.Controls.Add(this.btnRemoveList);
            this.Controls.Add(this.txtCurrentBookCount);
            this.Controls.Add(this.lbCellBooks);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.nBookNumber);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.dgvBooks);
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDashboard_FormClosing);
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBookNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.NumericUpDown nBookNumber;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lbCellBooks;
        private System.Windows.Forms.TextBox txtCurrentBookCount;
        private System.Windows.Forms.Button btnRemoveList;
    }
}