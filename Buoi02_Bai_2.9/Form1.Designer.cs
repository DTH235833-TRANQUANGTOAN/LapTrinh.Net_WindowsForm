namespace Buoi02_Bai_2._9
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
            btnDienTich = new Button();
            btnDuongCheo = new Button();
            btnThoat = new Button();
            btnChuVi = new Button();
            lbKetQua = new Label();
            tboxKetQua = new TextBox();
            grpThongTin = new GroupBox();
            tboxb = new TextBox();
            tboxa = new TextBox();
            lbb = new Label();
            lba = new Label();
            label1 = new Label();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // btnDienTich
            // 
            btnDienTich.Font = new Font("Segoe UI", 10F);
            btnDienTich.Location = new Point(281, 351);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(130, 69);
            btnDienTich.TabIndex = 22;
            btnDienTich.Text = "Dien Tich";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // btnDuongCheo
            // 
            btnDuongCheo.Font = new Font("Segoe UI", 10F);
            btnDuongCheo.Location = new Point(417, 351);
            btnDuongCheo.Name = "btnDuongCheo";
            btnDuongCheo.Size = new Size(130, 69);
            btnDuongCheo.TabIndex = 21;
            btnDuongCheo.Text = "Duong Cheo";
            btnDuongCheo.UseVisualStyleBackColor = true;
            btnDuongCheo.Click += btnDuongCheo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.Location = new Point(553, 351);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 69);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnChuVi
            // 
            btnChuVi.Font = new Font("Segoe UI", 10F);
            btnChuVi.Location = new Point(145, 351);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(130, 69);
            btnChuVi.TabIndex = 19;
            btnChuVi.Text = "Chu Vi";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
            // 
            // lbKetQua
            // 
            lbKetQua.AutoSize = true;
            lbKetQua.Font = new Font("Segoe UI", 9F);
            lbKetQua.Location = new Point(244, 303);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(76, 25);
            lbKetQua.TabIndex = 18;
            lbKetQua.Text = "Ket qua:";
            // 
            // tboxKetQua
            // 
            tboxKetQua.Location = new Point(328, 300);
            tboxKetQua.Name = "tboxKetQua";
            tboxKetQua.Size = new Size(190, 31);
            tboxKetQua.TabIndex = 16;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(tboxb);
            grpThongTin.Controls.Add(tboxa);
            grpThongTin.Controls.Add(lbb);
            grpThongTin.Controls.Add(lba);
            grpThongTin.Font = new Font("Segoe UI", 11F);
            grpThongTin.Location = new Point(258, 92);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(303, 199);
            grpThongTin.TabIndex = 17;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thong Tin";
            // 
            // tboxb
            // 
            tboxb.Location = new Point(70, 125);
            tboxb.Name = "tboxb";
            tboxb.Size = new Size(190, 37);
            tboxb.TabIndex = 3;
            // 
            // tboxa
            // 
            tboxa.Location = new Point(70, 55);
            tboxa.Name = "tboxa";
            tboxa.Size = new Size(190, 37);
            tboxa.TabIndex = 2;
            // 
            // lbb
            // 
            lbb.AutoSize = true;
            lbb.Font = new Font("Segoe UI", 9F);
            lbb.Location = new Point(32, 137);
            lbb.Name = "lbb";
            lbb.Size = new Size(32, 25);
            lbb.TabIndex = 1;
            lbb.Text = "b: ";
            // 
            // lba
            // 
            lba.AutoSize = true;
            lba.Font = new Font("Segoe UI", 9F);
            lba.Location = new Point(32, 62);
            lba.Name = "lba";
            lba.Size = new Size(30, 25);
            lba.TabIndex = 0;
            lba.Text = "a: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(290, 19);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 15;
            label1.Text = "HINH CHU NHAT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDienTich);
            Controls.Add(btnDuongCheo);
            Controls.Add(btnThoat);
            Controls.Add(btnChuVi);
            Controls.Add(lbKetQua);
            Controls.Add(tboxKetQua);
            Controls.Add(grpThongTin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Buoi02_Bai_2.9";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDienTich;
        private Button btnDuongCheo;
        private Button btnThoat;
        private Button btnChuVi;
        private Label lbKetQua;
        private TextBox tboxKetQua;
        private GroupBox grpThongTin;
        private TextBox tboxb;
        private TextBox tboxa;
        private Label lbb;
        private Label lba;
        private Label label1;
    }
}
