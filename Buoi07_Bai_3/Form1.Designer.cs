namespace Buoi07_Bai_3
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
            pictureBox1 = new PictureBox();
            btnTruoc = new Button();
            btmMo = new Button();
            btnSau = new Button();
            btnThoat = new Button();
            btnBatDau = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(718, 372);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnTruoc
            // 
            btnTruoc.Location = new Point(32, 390);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(185, 62);
            btnTruoc.TabIndex = 1;
            btnTruoc.Text = "<<Trước";
            btnTruoc.UseVisualStyleBackColor = true;
            btnTruoc.Click += btnTruoc_Click;
            // 
            // btmMo
            // 
            btmMo.Location = new Point(291, 390);
            btmMo.Name = "btmMo";
            btmMo.Size = new Size(185, 77);
            btmMo.TabIndex = 2;
            btmMo.Text = "Mở danh sách hình";
            btmMo.UseVisualStyleBackColor = true;
            btmMo.Click += btmMo_Click;
            // 
            // btnSau
            // 
            btnSau.Location = new Point(565, 390);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(185, 62);
            btnSau.TabIndex = 3;
            btnSau.Text = "Sau>>";
            btnSau.UseVisualStyleBackColor = true;
            btnSau.Click += btnSau_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(565, 478);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(185, 62);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnBatDau
            // 
            btnBatDau.Location = new Point(32, 478);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(185, 62);
            btnBatDau.TabIndex = 6;
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(790, 576);
            Controls.Add(btnBatDau);
            Controls.Add(btnThoat);
            Controls.Add(btnSau);
            Controls.Add(btmMo);
            Controls.Add(btnTruoc);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnTruoc;
        private Button btmMo;
        private Button btnSau;
        private Button btnThoat;
        private Button btnBatDau;
    }
}
