namespace Buoi08
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
            groupBox1 = new GroupBox();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            rb1 = new RadioButton();
            groupBox2 = new GroupBox();
            txtRong = new TextBox();
            txtDai = new TextBox();
            txtBanKinh = new TextBox();
            txtCanh = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThucHien = new Button();
            btnThoat = new Button();
            menuStrip1 = new MenuStrip();
            menuThucHien = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(170, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(457, 48);
            label1.TabIndex = 0;
            label1.Text = "TÍNH DIỆN TÍCH VÀ CHU VI";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb2);
            groupBox1.Controls.Add(rb3);
            groupBox1.Controls.Add(rb1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(53, 114);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(224, 178);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn";
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(7, 81);
            rb2.Name = "rb2";
            rb2.Size = new Size(191, 36);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "Hình chữ nhật";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += rb3_CheckedChanged;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(7, 123);
            rb3.Name = "rb3";
            rb3.Size = new Size(141, 36);
            rb3.TabIndex = 1;
            rb3.TabStop = true;
            rb3.Text = "Hình tròn";
            rb3.UseVisualStyleBackColor = true;
            rb3.CheckedChanged += rb2_CheckedChanged;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(7, 39);
            rb1.Name = "rb1";
            rb1.Size = new Size(165, 36);
            rb1.TabIndex = 0;
            rb1.TabStop = true;
            rb1.Text = "Hình vuông";
            rb1.UseVisualStyleBackColor = true;
            rb1.CheckedChanged += rb1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtRong);
            groupBox2.Controls.Add(txtDai);
            groupBox2.Controls.Add(txtBanKinh);
            groupBox2.Controls.Add(txtCanh);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(352, 114);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(412, 189);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // txtRong
            // 
            txtRong.Location = new Point(260, 94);
            txtRong.Name = "txtRong";
            txtRong.Size = new Size(121, 39);
            txtRong.TabIndex = 7;
            // 
            // txtDai
            // 
            txtDai.Location = new Point(68, 94);
            txtDai.Name = "txtDai";
            txtDai.Size = new Size(121, 39);
            txtDai.TabIndex = 6;
            // 
            // txtBanKinh
            // 
            txtBanKinh.Location = new Point(146, 139);
            txtBanKinh.Name = "txtBanKinh";
            txtBanKinh.Size = new Size(176, 39);
            txtBanKinh.TabIndex = 5;
            // 
            // txtCanh
            // 
            txtCanh.Location = new Point(87, 38);
            txtCanh.Name = "txtCanh";
            txtCanh.Size = new Size(175, 39);
            txtCanh.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 97);
            label5.Name = "label5";
            label5.Size = new Size(75, 32);
            label5.TabIndex = 3;
            label5.Text = "Rộng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 144);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 2;
            label4.Text = "Bán kính R:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 95);
            label3.Name = "label3";
            label3.Size = new Size(54, 32);
            label3.TabIndex = 1;
            label3.Text = "Dài:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 41);
            label2.Name = "label2";
            label2.Size = new Size(74, 32);
            label2.TabIndex = 0;
            label2.Text = "Cạnh:";
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(147, 323);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(161, 60);
            btnThucHien.TabIndex = 4;
            btnThucHien.Text = "Thực hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(399, 323);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(161, 60);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuThucHien, menuThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(814, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuThucHien
            // 
            menuThucHien.Name = "menuThucHien";
            menuThucHien.Size = new Size(104, 29);
            menuThucHien.Text = "Thực hiện";
            menuThucHien.Click += menuThucHien_Click;
            // 
            // menuThoat
            // 
            menuThoat.Name = "menuThoat";
            menuThoat.Size = new Size(73, 29);
            menuThoat.Text = "Thoát";
            menuThoat.Click += menuThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(814, 428);
            Controls.Add(btnThoat);
            Controls.Add(btnThucHien);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rb2;
        private RadioButton rb3;
        private RadioButton rb1;
        private GroupBox groupBox2;
        private TextBox txtDai;
        private TextBox txtBanKinh;
        private TextBox txtCanh;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtRong;
        private Button btnThucHien;
        private Button btnThoat;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuThucHien;
        private ToolStripMenuItem menuThoat;
    }
}
