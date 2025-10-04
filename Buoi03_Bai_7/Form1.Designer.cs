namespace Buoi03_Bai_7
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
            menuStrip1 = new MenuStrip();
            tinhToanToolStripMenuItem = new ToolStripMenuItem();
            stripTong = new ToolStripMenuItem();
            stripHieu = new ToolStripMenuItem();
            stripTich = new ToolStripMenuItem();
            stripThuong = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtb = new TextBox();
            label2 = new Label();
            txta = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtKQ = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tinhToanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(617, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tinhToanToolStripMenuItem
            // 
            tinhToanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripTong, stripHieu, stripTich, stripThuong });
            tinhToanToolStripMenuItem.Name = "tinhToanToolStripMenuItem";
            tinhToanToolStripMenuItem.Size = new Size(103, 29);
            tinhToanToolStripMenuItem.Text = "Tinh Toan";
            // 
            // stripTong
            // 
            stripTong.Name = "stripTong";
            stripTong.Size = new Size(270, 34);
            stripTong.Text = "Tong";
            stripTong.Click += stripTong_Click;
            // 
            // stripHieu
            // 
            stripHieu.Name = "stripHieu";
            stripHieu.Size = new Size(270, 34);
            stripHieu.Text = "Hieu";
            stripHieu.Click += stripHieu_Click;
            // 
            // stripTich
            // 
            stripTich.Name = "stripTich";
            stripTich.Size = new Size(270, 34);
            stripTich.Text = "Tich";
            stripTich.Click += stripTich_Click;
            // 
            // stripThuong
            // 
            stripThuong.Name = "stripThuong";
            stripThuong.Size = new Size(270, 34);
            stripThuong.Text = "Thuong";
            stripThuong.Click += stripThuong_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txta);
            groupBox1.Location = new Point(102, 133);
            groupBox1.Margin = new Padding(5, 3, 5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 3, 5, 3);
            groupBox1.Size = new Size(404, 197);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 114);
            label3.Name = "label3";
            label3.Size = new Size(30, 27);
            label3.TabIndex = 14;
            label3.Text = "b:";
            // 
            // txtb
            // 
            txtb.Location = new Point(117, 106);
            txtb.Margin = new Padding(5, 3, 5, 3);
            txtb.Name = "txtb";
            txtb.Size = new Size(259, 35);
            txtb.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 53);
            label2.Name = "label2";
            label2.Size = new Size(29, 27);
            label2.TabIndex = 12;
            label2.Text = "a:";
            // 
            // txta
            // 
            txta.Location = new Point(117, 45);
            txta.Margin = new Padding(5, 3, 5, 3);
            txta.Name = "txta";
            txta.Size = new Size(259, 35);
            txta.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F);
            label1.Location = new Point(122, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(334, 34);
            label1.TabIndex = 6;
            label1.Text = "PHEP TOAN DON GIAN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 354);
            label4.Name = "label4";
            label4.Size = new Size(93, 27);
            label4.TabIndex = 16;
            label4.Text = "KetQua:";
            // 
            // txtKQ
            // 
            txtKQ.BackColor = SystemColors.Control;
            txtKQ.Location = new Point(219, 346);
            txtKQ.Margin = new Padding(5, 3, 5, 3);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(259, 35);
            txtKQ.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(617, 462);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtKQ);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Bai";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tinhToanToolStripMenuItem;
        private ToolStripMenuItem stripTong;
        private ToolStripMenuItem stripHieu;
        private ToolStripMenuItem stripTich;
        private ToolStripMenuItem stripThuong;
        private GroupBox groupBox1;
        private TextBox txta;
        private Label label1;
        private Label label3;
        private TextBox txtb;
        private Label label2;
        private Label label4;
        private TextBox txtKQ;
    }
}
