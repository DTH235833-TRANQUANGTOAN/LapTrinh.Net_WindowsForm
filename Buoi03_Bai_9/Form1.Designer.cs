namespace Buoi03_Bai_9
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
            groupBox1 = new GroupBox();
            cboxLam = new CheckBox();
            cboxHoc = new CheckBox();
            label8 = new Label();
            pickNgaySinh = new DateTimePicker();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtDienThoai = new TextBox();
            label5 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            label1 = new Label();
            btnHien = new Button();
            btnThoat = new Button();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboxLam);
            groupBox1.Controls.Add(cboxHoc);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(pickNgaySinh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Location = new Point(100, 112);
            groupBox1.Margin = new Padding(5, 3, 5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 3, 5, 3);
            groupBox1.Size = new Size(616, 526);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin";
            // 
            // cboxLam
            // 
            cboxLam.AutoSize = true;
            cboxLam.Location = new Point(372, 444);
            cboxLam.Name = "cboxLam";
            cboxLam.Size = new Size(154, 31);
            cboxLam.TabIndex = 26;
            cboxLam.Text = "Dang di lam";
            cboxLam.UseVisualStyleBackColor = true;
            // 
            // cboxHoc
            // 
            cboxHoc.AutoSize = true;
            cboxHoc.Location = new Point(183, 444);
            cboxHoc.Name = "cboxHoc";
            cboxHoc.Size = new Size(154, 31);
            cboxHoc.TabIndex = 25;
            cboxHoc.Text = "Dang di hoc";
            cboxHoc.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 444);
            label8.Name = "label8";
            label8.Size = new Size(122, 27);
            label8.TabIndex = 24;
            label8.Text = "Tinh Trang:";
            // 
            // pickNgaySinh
            // 
            pickNgaySinh.CustomFormat = "dd/MM/yyyy";
            pickNgaySinh.Format = DateTimePickerFormat.Custom;
            pickNgaySinh.Location = new Point(169, 165);
            pickNgaySinh.Name = "pickNgaySinh";
            pickNgaySinh.ShowUpDown = true;
            pickNgaySinh.Size = new Size(372, 35);
            pickNgaySinh.TabIndex = 23;
            pickNgaySinh.Value = new DateTime(2025, 10, 3, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 367);
            label7.Name = "label7";
            label7.Size = new Size(80, 27);
            label7.TabIndex = 22;
            label7.Text = "Email: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(169, 364);
            txtEmail.Margin = new Padding(5, 3, 5, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(372, 35);
            txtEmail.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 301);
            label6.Name = "label6";
            label6.Size = new Size(118, 27);
            label6.TabIndex = 20;
            label6.Text = "Dien thoai:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(169, 298);
            txtDienThoai.Margin = new Padding(5, 3, 5, 3);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(372, 35);
            txtDienThoai.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 232);
            label5.Name = "label5";
            label5.Size = new Size(87, 27);
            label5.TabIndex = 18;
            label5.Text = "Dia chi:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(169, 229);
            txtDiaChi.Margin = new Padding(5, 3, 5, 3);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(372, 35);
            txtDiaChi.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 171);
            label4.Name = "label4";
            label4.Size = new Size(114, 27);
            label4.TabIndex = 16;
            label4.Text = "Ngay sinh:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoNu);
            groupBox2.Controls.Add(rdoNam);
            groupBox2.Location = new Point(169, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 54);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(203, 19);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(66, 31);
            rdoNu.TabIndex = 15;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nu";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(45, 19);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(83, 31);
            rdoNam.TabIndex = 0;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 113);
            label3.Name = "label3";
            label3.Size = new Size(108, 27);
            label3.TabIndex = 13;
            label3.Text = "Gioi Tinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 54);
            label2.Name = "label2";
            label2.Size = new Size(83, 27);
            label2.TabIndex = 12;
            label2.Text = "Ho ten:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(169, 51);
            txtTen.Margin = new Padding(5, 3, 5, 3);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(372, 35);
            txtTen.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(364, 39);
            label1.TabIndex = 6;
            label1.Text = "THONG TIN CA NHAN";
            // 
            // btnHien
            // 
            btnHien.Location = new Point(100, 666);
            btnHien.Name = "btnHien";
            btnHien.Size = new Size(246, 63);
            btnHien.TabIndex = 7;
            btnHien.Text = "Hien thong tin";
            btnHien.UseVisualStyleBackColor = true;
            btnHien.Click += btnHien_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(432, 666);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(246, 63);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Location = new Point(780, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 308);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hinh anh";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_02_04_141522;
            pictureBox1.Location = new Point(36, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 265);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1106, 801);
            Controls.Add(groupBox3);
            Controls.Add(btnThoat);
            Controls.Add(btnHien);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Bai9";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTen;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private Label label7;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtDienThoai;
        private Label label5;
        private TextBox txtDiaChi;
        private Label label4;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private DateTimePicker pickNgaySinh;
        private CheckBox cboxLam;
        private CheckBox cboxHoc;
        private Label label8;
        private Button btnHien;
        private Button btnThoat;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
    }
}
