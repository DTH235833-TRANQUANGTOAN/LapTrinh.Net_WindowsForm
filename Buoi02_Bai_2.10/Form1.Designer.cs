namespace Buoi02_Bai_2._10
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
            tboxb = new TextBox();
            tboxa = new TextBox();
            lbb = new Label();
            lba = new Label();
            label1 = new Label();
            btnDienTich = new Button();
            btnDuongCheo = new Button();
            btnThoat = new Button();
            btnChuVi = new Button();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(tboxb);
            grpThongTin.Controls.Add(tboxa);
            grpThongTin.Controls.Add(lbb);
            grpThongTin.Controls.Add(lba);
            grpThongTin.Font = new Font("Segoe UI", 11F);
            grpThongTin.Location = new Point(236, 96);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(303, 199);
            grpThongTin.TabIndex = 19;
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
            label1.Location = new Point(268, 23);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 18;
            label1.Text = "HINH CHU NHAT";
            // 
            // btnDienTich
            // 
            btnDienTich.Font = new Font("Segoe UI", 10F);
            btnDienTich.Location = new Point(273, 335);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(130, 69);
            btnDienTich.TabIndex = 26;
            btnDienTich.Text = "Dien Tich";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // btnDuongCheo
            // 
            btnDuongCheo.Font = new Font("Segoe UI", 10F);
            btnDuongCheo.Location = new Point(409, 335);
            btnDuongCheo.Name = "btnDuongCheo";
            btnDuongCheo.Size = new Size(130, 69);
            btnDuongCheo.TabIndex = 25;
            btnDuongCheo.Text = "Duong Cheo";
            btnDuongCheo.UseVisualStyleBackColor = true;
            btnDuongCheo.Click += btnDuongCheo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.Location = new Point(545, 335);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 69);
            btnThoat.TabIndex = 24;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnChuVi
            // 
            btnChuVi.Font = new Font("Segoe UI", 10F);
            btnChuVi.Location = new Point(137, 335);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(130, 69);
            btnChuVi.TabIndex = 23;
            btnChuVi.Text = "Chu Vi";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
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
            Controls.Add(grpThongTin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private TextBox tboxb;
        private TextBox tboxa;
        private Label lbb;
        private Label lba;
        private Label label1;
        private Button btnDienTich;
        private Button btnDuongCheo;
        private Button btnThoat;
        private Button btnChuVi;
    }
}
