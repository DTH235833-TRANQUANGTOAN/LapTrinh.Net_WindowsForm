namespace Buoi03_Bai_6
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
            txtChuoi = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            txtKQ = new TextBox();
            btnChu = new Button();
            btnNen = new Button();
            BtnFont = new Button();
            btnDong = new Button();
            listbox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChuoi);
            groupBox1.Location = new Point(39, 42);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(311, 96);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập chuỗi";
            // 
            // txtChuoi
            // 
            txtChuoi.Location = new Point(8, 43);
            txtChuoi.Margin = new Padding(4, 3, 4, 3);
            txtChuoi.Name = "txtChuoi";
            txtChuoi.Size = new Size(287, 35);
            txtChuoi.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(39, 145);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 43);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(214, 145);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(135, 43);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(374, 53);
            txtKQ.Margin = new Padding(4, 3, 4, 3);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(546, 123);
            txtKQ.TabIndex = 12;
            // 
            // btnChu
            // 
            btnChu.Location = new Point(374, 191);
            btnChu.Margin = new Padding(4, 3, 4, 3);
            btnChu.Name = "btnChu";
            btnChu.Size = new Size(169, 52);
            btnChu.TabIndex = 17;
            btnChu.Text = "Chọn màu chữ";
            btnChu.UseVisualStyleBackColor = true;
            btnChu.Click += btnChu_Click;
            // 
            // btnNen
            // 
            btnNen.Location = new Point(562, 191);
            btnNen.Margin = new Padding(4, 3, 4, 3);
            btnNen.Name = "btnNen";
            btnNen.Size = new Size(169, 52);
            btnNen.TabIndex = 18;
            btnNen.Text = "Chọn màu nền";
            btnNen.UseVisualStyleBackColor = true;
            btnNen.Click += btnNen_Click;
            // 
            // BtnFont
            // 
            BtnFont.Location = new Point(751, 191);
            BtnFont.Margin = new Padding(4, 3, 4, 3);
            BtnFont.Name = "BtnFont";
            BtnFont.Size = new Size(169, 52);
            BtnFont.TabIndex = 19;
            BtnFont.Text = "Chọn Font";
            BtnFont.UseVisualStyleBackColor = true;
            BtnFont.Click += BtnFont_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(562, 277);
            btnDong.Margin = new Padding(4, 3, 4, 3);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(169, 52);
            btnDong.TabIndex = 20;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // listbox
            // 
            listbox.FormattingEnabled = true;
            listbox.ItemHeight = 27;
            listbox.Location = new Point(39, 194);
            listbox.Name = "listbox";
            listbox.Size = new Size(310, 139);
            listbox.TabIndex = 21;
            listbox.SelectedIndexChanged += listbox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(988, 378);
            Controls.Add(listbox);
            Controls.Add(btnDong);
            Controls.Add(BtnFont);
            Controls.Add(btnNen);
            Controls.Add(btnChu);
            Controls.Add(txtKQ);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Controls";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtChuoi;
        private Button btnThem;
        private Button btnXoa;
        private TextBox txtKQ;
        private Button btnChu;
        private Button btnNen;
        private Button BtnFont;
        private Button btnDong;
        private ListBox listbox;
    }
}
