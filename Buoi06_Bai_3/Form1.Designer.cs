namespace Buoi06_Bai_3
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
            dateNgaySinh = new DateTimePicker();
            cbLop = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            txtHoTen = new TextBox();
            label3 = new Label();
            txtMaSV = new TextBox();
            label2 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lsKQ = new ListView();
            clMASV = new ColumnHeader();
            clHOTEN = new ColumnHeader();
            clDIACHI = new ColumnHeader();
            clNGAYSINH = new ColumnHeader();
            clLOP = new ColumnHeader();
            gr1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(351, 27);
            label1.Name = "label1";
            label1.Size = new Size(294, 41);
            label1.TabIndex = 0;
            label1.Text = "Danh sách sinh viên";
            // 
            // gr1
            // 
            gr1.Controls.Add(dateNgaySinh);
            gr1.Controls.Add(cbLop);
            gr1.Controls.Add(label6);
            gr1.Controls.Add(label5);
            gr1.Controls.Add(txtDiaChi);
            gr1.Controls.Add(label4);
            gr1.Controls.Add(txtHoTen);
            gr1.Controls.Add(label3);
            gr1.Controls.Add(txtMaSV);
            gr1.Controls.Add(label2);
            gr1.Location = new Point(43, 92);
            gr1.Name = "gr1";
            gr1.Size = new Size(602, 386);
            gr1.TabIndex = 1;
            gr1.TabStop = false;
            gr1.Text = "Nhập thông tin";
            // 
            // dateNgaySinh
            // 
            dateNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateNgaySinh.Format = DateTimePickerFormat.Custom;
            dateNgaySinh.Location = new Point(175, 246);
            dateNgaySinh.Name = "dateNgaySinh";
            dateNgaySinh.Size = new Size(411, 39);
            dateNgaySinh.TabIndex = 2;
            // 
            // cbLop
            // 
            cbLop.FormattingEnabled = true;
            cbLop.Items.AddRange(new object[] { "Lớp A", "Lớp B", "Lớp C", "Lớp D", "Lớp E", "Lớp F" });
            cbLop.Location = new Point(175, 310);
            cbLop.Name = "cbLop";
            cbLop.Size = new Size(411, 40);
            cbLop.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 310);
            label6.Name = "label6";
            label6.Size = new Size(58, 32);
            label6.TabIndex = 8;
            label6.Text = "Lớp:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 251);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 6;
            label5.Text = "Ngày sinh:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(175, 183);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(411, 39);
            txtDiaChi.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 186);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(175, 123);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(411, 39);
            txtHoTen.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 126);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 2;
            label3.Text = "Họ tên:";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(175, 63);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(411, 39);
            txtMaSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 66);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 0;
            label2.Text = "Mã SV:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(773, 155);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(186, 68);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(773, 260);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(186, 68);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa item";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(773, 374);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(186, 68);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lsKQ
            // 
            lsKQ.Columns.AddRange(new ColumnHeader[] { clMASV, clHOTEN, clDIACHI, clNGAYSINH, clLOP });
            lsKQ.FullRowSelect = true;
            lsKQ.GridLines = true;
            lsKQ.Location = new Point(71, 484);
            lsKQ.Name = "lsKQ";
            lsKQ.Size = new Size(904, 342);
            lsKQ.TabIndex = 5;
            lsKQ.UseCompatibleStateImageBehavior = false;
            lsKQ.View = View.Details;
            // 
            // clMASV
            // 
            clMASV.Text = "Mã SV";
            clMASV.Width = 100;
            // 
            // clHOTEN
            // 
            clHOTEN.Text = "Họ tên SV";
            clHOTEN.TextAlign = HorizontalAlignment.Center;
            clHOTEN.Width = 200;
            // 
            // clDIACHI
            // 
            clDIACHI.Text = "Địa chỉ";
            clDIACHI.TextAlign = HorizontalAlignment.Center;
            clDIACHI.Width = 330;
            // 
            // clNGAYSINH
            // 
            clNGAYSINH.Text = "Ngày Sinh";
            clNGAYSINH.TextAlign = HorizontalAlignment.Center;
            clNGAYSINH.Width = 150;
            // 
            // clLOP
            // 
            clLOP.Text = "Lớp";
            clLOP.TextAlign = HorizontalAlignment.Center;
            clLOP.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1040, 838);
            Controls.Add(lsKQ);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(gr1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Danh sách sinh viên";
            gr1.ResumeLayout(false);
            gr1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gr1;
        private TextBox txtMaSV;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox txtDiaChi;
        private Label label4;
        private TextBox txtHoTen;
        private Label label3;
        private ComboBox cbLop;
        private DateTimePicker dateNgaySinh;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private ListView lsKQ;
        private ColumnHeader clMASV;
        private ColumnHeader clHOTEN;
        private ColumnHeader clDIACHI;
        private ColumnHeader clNGAYSINH;
        private ColumnHeader clLOP;
    }
}
