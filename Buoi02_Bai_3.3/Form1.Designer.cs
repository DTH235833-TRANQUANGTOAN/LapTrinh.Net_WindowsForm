namespace Buoi02_Bai_3._3
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
            grpThongTin = new GroupBox();
            tboxThang = new TextBox();
            lbThang = new Label();
            tboxNam = new TextBox();
            tboxNgay = new TextBox();
            lbNam = new Label();
            lbNgay = new Label();
            label1 = new Label();
            btnKiemTra = new Button();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(tboxThang);
            grpThongTin.Controls.Add(lbThang);
            grpThongTin.Controls.Add(tboxNam);
            grpThongTin.Controls.Add(tboxNgay);
            grpThongTin.Controls.Add(lbNam);
            grpThongTin.Controls.Add(lbNgay);
            grpThongTin.Font = new Font("Segoe UI", 11F);
            grpThongTin.Location = new Point(174, 85);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(437, 276);
            grpThongTin.TabIndex = 21;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thong Tin";
            // 
            // tboxThang
            // 
            tboxThang.Location = new Point(153, 137);
            tboxThang.Name = "tboxThang";
            tboxThang.Size = new Size(190, 37);
            tboxThang.TabIndex = 5;
            // 
            // lbThang
            // 
            lbThang.AutoSize = true;
            lbThang.Font = new Font("Segoe UI", 9F);
            lbThang.Location = new Point(50, 149);
            lbThang.Name = "lbThang";
            lbThang.Size = new Size(61, 25);
            lbThang.TabIndex = 4;
            lbThang.Text = "Thang";
            // 
            // tboxNam
            // 
            tboxNam.Location = new Point(153, 216);
            tboxNam.Name = "tboxNam";
            tboxNam.Size = new Size(190, 37);
            tboxNam.TabIndex = 3;
            // 
            // tboxNgay
            // 
            tboxNgay.Location = new Point(153, 53);
            tboxNgay.Name = "tboxNgay";
            tboxNgay.Size = new Size(190, 37);
            tboxNgay.TabIndex = 2;
            // 
            // lbNam
            // 
            lbNam.AutoSize = true;
            lbNam.Font = new Font("Segoe UI", 9F);
            lbNam.Location = new Point(50, 223);
            lbNam.Name = "lbNam";
            lbNam.Size = new Size(50, 25);
            lbNam.TabIndex = 1;
            lbNam.Text = "Nam";
            // 
            // lbNgay
            // 
            lbNgay.AutoSize = true;
            lbNgay.Font = new Font("Segoe UI", 9F);
            lbNgay.Location = new Point(50, 65);
            lbNgay.Name = "lbNgay";
            lbNgay.Size = new Size(54, 25);
            lbNgay.TabIndex = 0;
            lbNgay.Text = "Ngay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 41);
            label1.TabIndex = 20;
            label1.Text = "KIEM TRA NGAY HOP LE";
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(283, 376);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(202, 62);
            btnKiemTra.TabIndex = 22;
            btnKiemTra.Text = "Kiem Tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKiemTra);
            Controls.Add(grpThongTin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Buoi02_Bai_3.3";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private TextBox tboxThang;
        private Label lbThang;
        private TextBox tboxNam;
        private TextBox tboxNgay;
        private Label lbNam;
        private Label lbNgay;
        private Label label1;
        private Button btnKiemTra;
    }
}
