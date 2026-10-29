namespace HotelManagement
{
    partial class formMain
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.cboFilterLoai = new System.Windows.Forms.ComboBox();
            this.cboFilterTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCheckIn = new System.Windows.Forms.GroupBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnSearchCCCD = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.btnOrderDV = new System.Windows.Forms.Button();
            this.nudSoLuongDV = new System.Windows.Forms.NumericUpDown();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblSelectedRoom = new System.Windows.Forms.Label();
            this.btnDonDepXong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.grpCheckIn.SuspendLayout();
            this.grpDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(12, 50);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(420, 500);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // cboFilterLoai
            // 
            this.cboFilterLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterLoai.FormattingEnabled = true;
            this.cboFilterLoai.Location = new System.Drawing.Point(80, 15);
            this.cboFilterLoai.Name = "cboFilterLoai";
            this.cboFilterLoai.Size = new System.Drawing.Size(120, 21);
            this.cboFilterLoai.TabIndex = 1;
            this.cboFilterLoai.SelectedIndexChanged += new System.EventHandler(this.FilterRooms);
            // 
            // cboFilterTrangThai
            // 
            this.cboFilterTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterTrangThai.FormattingEnabled = true;
            this.cboFilterTrangThai.Location = new System.Drawing.Point(290, 15);
            this.cboFilterTrangThai.Name = "cboFilterTrangThai";
            this.cboFilterTrangThai.Size = new System.Drawing.Size(140, 21);
            this.cboFilterTrangThai.TabIndex = 2;
            this.cboFilterTrangThai.SelectedIndexChanged += new System.EventHandler(this.FilterRooms);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại Phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trạng Thái:";
            // 
            // grpCheckIn
            // 
            this.grpCheckIn.Controls.Add(this.btnCheckIn);
            this.grpCheckIn.Controls.Add(this.btnSearchCCCD);
            this.grpCheckIn.Controls.Add(this.txtSDT);
            this.grpCheckIn.Controls.Add(this.txtHoTen);
            this.grpCheckIn.Controls.Add(this.txtCCCD);
            this.grpCheckIn.Controls.Add(this.label5);
            this.grpCheckIn.Controls.Add(this.label4);
            this.grpCheckIn.Controls.Add(this.label3);
            this.grpCheckIn.Location = new System.Drawing.Point(450, 50);
            this.grpCheckIn.Name = "grpCheckIn";
            this.grpCheckIn.Size = new System.Drawing.Size(420, 150);
            this.grpCheckIn.TabIndex = 5;
            this.grpCheckIn.TabStop = false;
            this.grpCheckIn.Text = "Chức Năng Check-in (Nhận Phòng)";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.LightGreen;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.Location = new System.Drawing.Point(290, 85);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(115, 50);
            this.btnCheckIn.TabIndex = 7;
            this.btnCheckIn.Text = "Nhận Phòng";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnSearchCCCD
            // 
            this.btnSearchCCCD.Location = new System.Drawing.Point(290, 23);
            this.btnSearchCCCD.Name = "btnSearchCCCD";
            this.btnSearchCCCD.Size = new System.Drawing.Size(115, 23);
            this.btnSearchCCCD.TabIndex = 6;
            this.btnSearchCCCD.Text = "Tra Cứu CCCD";
            this.btnSearchCCCD.UseVisualStyleBackColor = true;
            this.btnSearchCCCD.Click += new System.EventHandler(this.btnSearchCCCD_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(90, 85);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(180, 20);
            this.txtSDT.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(90, 55);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 20);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(90, 25);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(180, 20);
            this.txtCCCD.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số CCCD:";
            // 
            // grpDichVu
            // 
            this.grpDichVu.Controls.Add(this.btnOrderDV);
            this.grpDichVu.Controls.Add(this.nudSoLuongDV);
            this.grpDichVu.Controls.Add(this.cboDichVu);
            this.grpDichVu.Controls.Add(this.dgvDichVu);
            this.grpDichVu.Controls.Add(this.label7);
            this.grpDichVu.Controls.Add(this.label6);
            this.grpDichVu.Location = new System.Drawing.Point(450, 210);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new System.Drawing.Size(420, 270);
            this.grpDichVu.TabIndex = 6;
            this.grpDichVu.TabStop = false;
            this.grpDichVu.Text = "Chức Năng Gọi Dịch Vụ";
            // 
            // btnOrderDV
            // 
            this.btnOrderDV.Location = new System.Drawing.Point(290, 52);
            this.btnOrderDV.Name = "btnOrderDV";
            this.btnOrderDV.Size = new System.Drawing.Size(115, 23);
            this.btnOrderDV.TabIndex = 5;
            this.btnOrderDV.Text = "Thêm Dịch Vụ";
            this.btnOrderDV.UseVisualStyleBackColor = true;
            this.btnOrderDV.Click += new System.EventHandler(this.btnOrderDV_Click);
            // 
            // nudSoLuongDV
            // 
            this.nudSoLuongDV.Location = new System.Drawing.Point(90, 55);
            this.nudSoLuongDV.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuongDV.Name = "nudSoLuongDV";
            this.nudSoLuongDV.Size = new System.Drawing.Size(180, 20);
            this.nudSoLuongDV.TabIndex = 4;
            this.nudSoLuongDV.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboDichVu
            // 
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(90, 22);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Size = new System.Drawing.Size(180, 21);
            this.cboDichVu.TabIndex = 3;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(15, 90);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.Size = new System.Drawing.Size(390, 165);
            this.dgvDichVu.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chọn dịch vụ:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Coral;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(690, 495);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(180, 55);
            this.btnCheckOut.TabIndex = 7;
            this.btnCheckOut.Text = "CHECK-OUT && HÓA ĐƠN";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblSelectedRoom
            // 
            this.lblSelectedRoom.AutoSize = true;
            this.lblSelectedRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectedRoom.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSelectedRoom.Location = new System.Drawing.Point(450, 15);
            this.lblSelectedRoom.Name = "lblSelectedRoom";
            this.lblSelectedRoom.Size = new System.Drawing.Size(161, 20);
            this.lblSelectedRoom.TabIndex = 8;
            this.lblSelectedRoom.Text = "Phòng đang chọn: --";
            // 
            // btnDonDepXong
            // 
            this.btnDonDepXong.Location = new System.Drawing.Point(450, 495);
            this.btnDonDepXong.Name = "btnDonDepXong";
            this.btnDonDepXong.Size = new System.Drawing.Size(150, 55);
            this.btnDonDepXong.TabIndex = 9;
            this.btnDonDepXong.Text = "Xác Nhận Đã Dọn Dẹp";
            this.btnDonDepXong.UseVisualStyleBackColor = true;
            this.btnDonDepXong.Click += new System.EventHandler(this.btnDonDepXong_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnDonDepXong);
            this.Controls.Add(this.lblSelectedRoom);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.grpCheckIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFilterTrangThai);
            this.Controls.Add(this.cboFilterLoai);
            this.Controls.Add(this.dgvPhong);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Tiện Ích Dịch Vụ & Khách Sạn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.grpCheckIn.ResumeLayout(false);
            this.grpCheckIn.PerformLayout();
            this.grpDichVu.ResumeLayout(false);
            this.grpDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.ComboBox cboFilterLoai;
        private System.Windows.Forms.ComboBox cboFilterTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCheckIn;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnSearchCCCD;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.Button btnOrderDV;
        private System.Windows.Forms.NumericUpDown nudSoLuongDV;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblSelectedRoom;
        private System.Windows.Forms.Button btnDonDepXong;
    }
}