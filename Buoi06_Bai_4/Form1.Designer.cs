namespace Buoi06_Bai_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gr1 = new GroupBox();
            cbQueQuan = new ComboBox();
            dateNgaySinh = new DateTimePicker();
            txtDienThoai = new TextBox();
            txtHoTen = new TextBox();
            groupBox1 = new GroupBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtMaSV = new TextBox();
            label2 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            lsKQ = new ListView();
            clMASV = new ColumnHeader();
            clHOTEN = new ColumnHeader();
            clNGAYSINH = new ColumnHeader();
            clPHAI = new ColumnHeader();
            clDIENTHOAI = new ColumnHeader();
            clQUEQUAN = new ColumnHeader();
            gr1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(309, 29);
            label1.Name = "label1";
            label1.Size = new Size(345, 54);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sinh viên";
            // 
            // gr1
            // 
            gr1.Controls.Add(cbQueQuan);
            gr1.Controls.Add(dateNgaySinh);
            gr1.Controls.Add(txtDienThoai);
            gr1.Controls.Add(txtHoTen);
            gr1.Controls.Add(groupBox1);
            gr1.Controls.Add(label7);
            gr1.Controls.Add(label6);
            gr1.Controls.Add(label5);
            gr1.Controls.Add(label4);
            gr1.Controls.Add(label3);
            gr1.Controls.Add(txtMaSV);
            gr1.Controls.Add(label2);
            gr1.Location = new Point(55, 110);
            gr1.Name = "gr1";
            gr1.Size = new Size(920, 336);
            gr1.TabIndex = 1;
            gr1.TabStop = false;
            gr1.Text = "Thông tin chi tiết";
            // 
            // cbQueQuan
            // 
            cbQueQuan.FormattingEnabled = true;
            cbQueQuan.Items.AddRange(new object[] { "An Giang", "Kiên Giang", "Cần Thơ" });
            cbQueQuan.Location = new Point(609, 185);
            cbQueQuan.Name = "cbQueQuan";
            cbQueQuan.Size = new Size(277, 40);
            cbQueQuan.TabIndex = 18;
            // 
            // dateNgaySinh
            // 
            dateNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateNgaySinh.Format = DateTimePickerFormat.Custom;
            dateNgaySinh.Location = new Point(171, 181);
            dateNgaySinh.Name = "dateNgaySinh";
            dateNgaySinh.Size = new Size(277, 39);
            dateNgaySinh.TabIndex = 17;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(620, 119);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(277, 39);
            txtDienThoai.TabIndex = 16;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(171, 119);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(277, 39);
            txtHoTen.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoNu);
            groupBox1.Controls.Add(rdoNam);
            groupBox1.Location = new Point(602, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 77);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(173, 26);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(71, 36);
            rdoNu.TabIndex = 1;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nu";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(18, 26);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(90, 36);
            rdoNam.TabIndex = 0;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(483, 56);
            label7.Name = "label7";
            label7.Size = new Size(59, 32);
            label7.TabIndex = 10;
            label7.Text = "Phái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(483, 188);
            label6.Name = "label6";
            label6.Size = new Size(120, 32);
            label6.TabIndex = 8;
            label6.Text = "Quê quán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(483, 122);
            label5.Name = "label5";
            label5.Size = new Size(125, 32);
            label5.TabIndex = 6;
            label5.Text = "Điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 188);
            label4.Name = "label4";
            label4.Size = new Size(121, 32);
            label4.TabIndex = 4;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 122);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 2;
            label3.Text = "Họ tên";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(171, 53);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(277, 39);
            txtMaSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 56);
            label2.Name = "label2";
            label2.Size = new Size(151, 32);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(55, 467);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(145, 65);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(309, 467);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(145, 65);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(591, 467);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(145, 65);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(830, 467);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(145, 65);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lsKQ
            // 
            lsKQ.Columns.AddRange(new ColumnHeader[] { clMASV, clHOTEN, clNGAYSINH, clPHAI, clDIENTHOAI, clQUEQUAN });
            lsKQ.FullRowSelect = true;
            lsKQ.GridLines = true;
            lsKQ.Location = new Point(55, 589);
            lsKQ.Name = "lsKQ";
            lsKQ.Size = new Size(920, 304);
            lsKQ.TabIndex = 6;
            lsKQ.UseCompatibleStateImageBehavior = false;
            lsKQ.View = View.Details;
            // 
            // clMASV
            // 
            clMASV.Text = "Mã sv";
            clMASV.Width = 100;
            // 
            // clHOTEN
            // 
            clHOTEN.Text = "Họ tên";
            clHOTEN.TextAlign = HorizontalAlignment.Center;
            clHOTEN.Width = 250;
            // 
            // clNGAYSINH
            // 
            clNGAYSINH.Text = "Ngày sinh";
            clNGAYSINH.TextAlign = HorizontalAlignment.Center;
            clNGAYSINH.Width = 150;
            // 
            // clPHAI
            // 
            clPHAI.Text = "Phái";
            clPHAI.TextAlign = HorizontalAlignment.Center;
            clPHAI.Width = 100;
            // 
            // clDIENTHOAI
            // 
            clDIENTHOAI.Text = "Diện thoại";
            clDIENTHOAI.TextAlign = HorizontalAlignment.Center;
            clDIENTHOAI.Width = 200;
            // 
            // clQUEQUAN
            // 
            clQUEQUAN.Text = "Quê quán";
            clQUEQUAN.TextAlign = HorizontalAlignment.Center;
            clQUEQUAN.Width = 300;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1040, 1044);
            Controls.Add(lsKQ);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(gr1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            gr1.ResumeLayout(false);
            gr1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gr1;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtMaSV;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private ListView lsKQ;
        private ColumnHeader clMASV;
        private ColumnHeader clHOTEN;
        private ColumnHeader clNGAYSINH;
        private ColumnHeader clPHAI;
        private ColumnHeader clDIENTHOAI;
        private ColumnHeader clQUEQUAN;
        private DateTimePicker dateNgaySinh;
        private TextBox txtDienThoai;
        private TextBox txtHoTen;
        private ComboBox cbQueQuan;
    }
}
