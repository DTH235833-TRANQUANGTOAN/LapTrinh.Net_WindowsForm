namespace Buoi09
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
            mởFormToolStripMenuItem = new ToolStripMenuItem();
            menuKiemTra = new ToolStripMenuItem();
            menuTaoMang = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            txtN = new TextBox();
            btnKiemTra = new Button();
            btnTaoMang = new Button();
            btnThoat = new Button();
            btnLamLai = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mởFormToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(619, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mởFormToolStripMenuItem
            // 
            mởFormToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuKiemTra, menuTaoMang });
            mởFormToolStripMenuItem.Name = "mởFormToolStripMenuItem";
            mởFormToolStripMenuItem.Size = new Size(99, 29);
            mởFormToolStripMenuItem.Text = "Mở form";
            // 
            // menuKiemTra
            // 
            menuKiemTra.Name = "menuKiemTra";
            menuKiemTra.Size = new Size(283, 34);
            menuKiemTra.Text = "Kiểm tra số hoàn hảo";
            menuKiemTra.Click += menuKiemTra_Click;
            // 
            // menuTaoMang
            // 
            menuTaoMang.Name = "menuTaoMang";
            menuTaoMang.Size = new Size(283, 34);
            menuTaoMang.Text = "Tạo mảng";
            menuTaoMang.Click += menuTaoMang_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(73, 29);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 40);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "Nhập số N";
            // 
            // txtN
            // 
            txtN.Location = new Point(244, 40);
            txtN.Name = "txtN";
            txtN.Size = new Size(150, 31);
            txtN.TabIndex = 2;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(23, 99);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(198, 56);
            btnKiemTra.TabIndex = 3;
            btnKiemTra.Text = "Kiểm tra số hoàn hảo";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // btnTaoMang
            // 
            btnTaoMang.Location = new Point(402, 99);
            btnTaoMang.Name = "btnTaoMang";
            btnTaoMang.Size = new Size(198, 56);
            btnTaoMang.TabIndex = 4;
            btnTaoMang.Text = "Tạo mảng";
            btnTaoMang.UseVisualStyleBackColor = true;
            btnTaoMang.Click += btnTaoMang_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(402, 230);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(198, 56);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamLai
            // 
            btnLamLai.Location = new Point(23, 230);
            btnLamLai.Name = "btnLamLai";
            btnLamLai.Size = new Size(198, 56);
            btnLamLai.TabIndex = 6;
            btnLamLai.Text = "Làm Lại";
            btnLamLai.UseVisualStyleBackColor = true;
            btnLamLai.Click += btnLamLai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 307);
            Controls.Add(btnLamLai);
            Controls.Add(btnThoat);
            Controls.Add(btnTaoMang);
            Controls.Add(btnKiemTra);
            Controls.Add(txtN);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mởFormToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem menuKiemTra;
        private ToolStripMenuItem menuTaoMang;
        private Label label1;
        private TextBox txtN;
        private Button btnKiemTra;
        private Button btnTaoMang;
        private Button btnThoat;
        private Button btnLamLai;
    }
}
