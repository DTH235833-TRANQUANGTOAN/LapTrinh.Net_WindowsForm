namespace Buoi11_BaiTap  // <--- Đã sửa thành Buoi11_BaiTap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaSo = new TextBox();
            txtHoLot = new TextBox();
            txtTen = new TextBox();
            radNam = new RadioButton();
            rdoNu = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            cboQueQuan = new ComboBox();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvHocSinh = new DataGridView();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 26);
            label1.Name = "label1";
            label1.Size = new Size(233, 27);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ HỌC SINH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 99);
            label2.Name = "label2";
            label2.Size = new Size(74, 27);
            label2.TabIndex = 1;
            label2.Text = "Mã Số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 99);
            label3.Name = "label3";
            label3.Size = new Size(81, 27);
            label3.TabIndex = 2;
            label3.Text = "Họ Lót";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(705, 99);
            label4.Name = "label4";
            label4.Size = new Size(49, 27);
            label4.TabIndex = 3;
            label4.Text = "Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 166);
            label5.Name = "label5";
            label5.Size = new Size(55, 27);
            label5.TabIndex = 4;
            label5.Text = "Phái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 171);
            label6.Name = "label6";
            label6.Size = new Size(111, 27);
            label6.TabIndex = 5;
            label6.Text = "Ngày Sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(714, 166);
            label7.Name = "label7";
            label7.Size = new Size(110, 27);
            label7.TabIndex = 6;
            label7.Text = "Quê Quán";
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(115, 96);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(161, 35);
            txtMaSo.TabIndex = 7;
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(404, 96);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(272, 35);
            txtHoLot.TabIndex = 8;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(761, 96);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(161, 35);
            txtTen.TabIndex = 9;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(115, 149);
            radNam.Name = "radNam";
            radNam.Size = new Size(83, 31);
            radNam.TabIndex = 10;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(115, 181);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(67, 31);
            rdoNu.TabIndex = 11;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(415, 165);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(261, 35);
            dtpNgaySinh.TabIndex = 12;
            // 
            // cboQueQuan
            // 
            cboQueQuan.FormattingEnabled = true;
            cboQueQuan.Location = new Point(826, 163);
            cboQueQuan.Name = "cboQueQuan";
            cboQueQuan.Size = new Size(162, 35);
            cboQueQuan.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(13, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1075, 102);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(944, 40);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(124, 43);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(759, 40);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(124, 43);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(574, 40);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(124, 43);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(389, 40);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(124, 43);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(204, 40);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(124, 43);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(19, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(124, 43);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Location = new Point(13, 378);
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.RowHeadersWidth = 51;
            dgvHocSinh.RowTemplate.Height = 24;
            dgvHocSinh.Size = new Size(1075, 229);
            dgvHocSinh.TabIndex = 15;
            dgvHocSinh.CellClick += dgvHocSinh_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 353);
            label8.Name = "label8";
            label8.Size = new Size(210, 27);
            label8.TabIndex = 16;
            label8.Text = "Danh Sách Học Sinh";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(label8);
            Controls.Add(dgvHocSinh);
            Controls.Add(groupBox1);
            Controls.Add(cboQueQuan);
            Controls.Add(dtpNgaySinh);
            Controls.Add(rdoNu);
            Controls.Add(radNam);
            Controls.Add(txtTen);
            Controls.Add(txtHoLot);
            Controls.Add(txtMaSo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboQueQuan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Label label8;
    }
}