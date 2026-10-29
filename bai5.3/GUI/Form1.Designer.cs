namespace CafePOS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.flpTables = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.cboMonAn = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnAddMon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnQuanLyMenu = new System.Windows.Forms.Button();
            this.lblSelectedTable = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // flpTables
            // 
            this.flpTables.AutoScroll = true;
            this.flpTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTables.Location = new System.Drawing.Point(12, 12);
            this.flpTables.Name = "flpTables";
            this.flpTables.Size = new System.Drawing.Size(430, 530);
            this.flpTables.TabIndex = 0;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(458, 120);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(480, 360);
            this.dgvBill.TabIndex = 1;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(525, 12);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(180, 21);
            this.cboDanhMuc.TabIndex = 2;
            this.cboDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboDanhMuc_SelectedIndexChanged);
            // 
            // cboMonAn
            // 
            this.cboMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonAn.FormattingEnabled = true;
            this.cboMonAn.Location = new System.Drawing.Point(525, 42);
            this.cboMonAn.Name = "cboMonAn";
            this.cboMonAn.Size = new System.Drawing.Size(180, 21);
            this.cboMonAn.TabIndex = 3;
            this.cboMonAn.SelectedIndexChanged += new System.EventHandler(this.cboMonAn_SelectedIndexChanged);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(525, 72);
            this.nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(80, 20);
            this.nudSoLuong.TabIndex = 4;
            this.nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddMon
            // 
            this.btnAddMon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddMon.ForeColor = System.Drawing.Color.White;
            this.btnAddMon.Location = new System.Drawing.Point(720, 12);
            this.btnAddMon.Name = "btnAddMon";
            this.btnAddMon.Size = new System.Drawing.Size(90, 80);
            this.btnAddMon.TabIndex = 5;
            this.btnAddMon.Text = "Thêm Món";
            this.btnAddMon.UseVisualStyleBackColor = false;
            this.btnAddMon.Click += new System.EventHandler(this.btnAddMon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(828, 490);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(110, 50);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnQuanLyMenu
            // 
            this.btnQuanLyMenu.Location = new System.Drawing.Point(825, 12);
            this.btnQuanLyMenu.Name = "btnQuanLyMenu";
            this.btnQuanLyMenu.Size = new System.Drawing.Size(113, 80);
            this.btnQuanLyMenu.TabIndex = 7;
            this.btnQuanLyMenu.Text = "Quản Lý Thực Đơn";
            this.btnQuanLyMenu.UseVisualStyleBackColor = true;
            this.btnQuanLyMenu.Click += new System.EventHandler(this.btnQuanLyMenu_Click);
            // 
            // lblSelectedTable
            // 
            this.lblSelectedTable.AutoSize = true;
            this.lblSelectedTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectedTable.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSelectedTable.Location = new System.Drawing.Point(455, 97);
            this.lblSelectedTable.Name = "lblSelectedTable";
            this.lblSelectedTable.Size = new System.Drawing.Size(130, 20);
            this.lblSelectedTable.TabIndex = 8;
            this.lblSelectedTable.Text = "Chưa chọn bàn";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(454, 503);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(144, 20);
            this.lblTongTien.TabIndex = 9;
            this.lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(615, 75);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(38, 13);
            this.lblDonGia.TabIndex = 10;
            this.lblDonGia.Text = "0 VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Món ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số lượng:";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(950, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblSelectedTable);
            this.Controls.Add(this.btnQuanLyMenu);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnAddMon);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.cboMonAn);
            this.Controls.Add(this.cboDanhMuc);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.flpTables);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Bán Hàng - POS Cafe";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTables;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.ComboBox cboMonAn;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnAddMon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnQuanLyMenu;
        private System.Windows.Forms.Label lblSelectedTable;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}