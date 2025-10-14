namespace Buoi05_Bai_4
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
            label2 = new Label();
            label3 = new Label();
            grChon = new GroupBox();
            rdoChuNhat = new RadioButton();
            rdoTamGiac = new RadioButton();
            rdoVuong = new RadioButton();
            rdoTron = new RadioButton();
            btnThucHien = new Button();
            btnReset = new Button();
            btnThoat = new Button();
            grVuong = new GroupBox();
            txt_Vuong_DienTich = new TextBox();
            label7 = new Label();
            txt_Vuong_ChuVi = new TextBox();
            txt_Vuong_A = new TextBox();
            label8 = new Label();
            label9 = new Label();
            grTamGiac = new GroupBox();
            txt_TamGiac_C = new TextBox();
            label4 = new Label();
            txt_TamGiac_B = new TextBox();
            label14 = new Label();
            txt_TamGiac_DienTich = new TextBox();
            label15 = new Label();
            txt_TamGiac_ChuVi = new TextBox();
            txt_TamGiac_A = new TextBox();
            label16 = new Label();
            label17 = new Label();
            grTron = new GroupBox();
            txt_Tron_DienTich = new TextBox();
            label18 = new Label();
            txt_Tron_ChuVi = new TextBox();
            txt_Tron_BanKinh = new TextBox();
            label19 = new Label();
            label20 = new Label();
            grChuNhat = new GroupBox();
            txt_ChuNhat_B = new TextBox();
            label13 = new Label();
            txt_ChuNhat_DienTich = new TextBox();
            label10 = new Label();
            txt_ChuNhat_ChuVi = new TextBox();
            txt_ChuNhat_A = new TextBox();
            label11 = new Label();
            label12 = new Label();
            grChon.SuspendLayout();
            grVuong.SuspendLayout();
            grTamGiac.SuspendLayout();
            grTron.SuspendLayout();
            grChuNhat.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(203, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(419, 51);
            label1.TabIndex = 1;
            label1.Text = "Tìm chu vi và diện tích";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(267, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(282, 32);
            label2.TabIndex = 2;
            label2.Text = "Hình tròn - Hình vuông";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(232, 146);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(358, 32);
            label3.TabIndex = 3;
            label3.Text = "Hình tam giác - Hình chữ nhật";
            // 
            // grChon
            // 
            grChon.Controls.Add(rdoChuNhat);
            grChon.Controls.Add(rdoTamGiac);
            grChon.Controls.Add(rdoVuong);
            grChon.Controls.Add(rdoTron);
            grChon.Location = new Point(203, 203);
            grChon.Name = "grChon";
            grChon.Size = new Size(366, 150);
            grChon.TabIndex = 4;
            grChon.TabStop = false;
            grChon.Text = "Chọn";
            // 
            // rdoChuNhat
            // 
            rdoChuNhat.AutoSize = true;
            rdoChuNhat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoChuNhat.Location = new Point(162, 92);
            rdoChuNhat.Name = "rdoChuNhat";
            rdoChuNhat.Size = new Size(159, 32);
            rdoChuNhat.TabIndex = 3;
            rdoChuNhat.TabStop = true;
            rdoChuNhat.Text = "Hình chữ nhật";
            rdoChuNhat.UseVisualStyleBackColor = true;
            rdoChuNhat.CheckedChanged += rdoChuNhat_CheckedChanged;
            // 
            // rdoTamGiac
            // 
            rdoTamGiac.AutoSize = true;
            rdoTamGiac.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoTamGiac.Location = new Point(162, 38);
            rdoTamGiac.Name = "rdoTamGiac";
            rdoTamGiac.Size = new Size(158, 32);
            rdoTamGiac.TabIndex = 2;
            rdoTamGiac.TabStop = true;
            rdoTamGiac.Text = "Hình tam giác";
            rdoTamGiac.UseVisualStyleBackColor = true;
            rdoTamGiac.CheckedChanged += rdoTamGiac_CheckedChanged;
            // 
            // rdoVuong
            // 
            rdoVuong.AutoSize = true;
            rdoVuong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoVuong.Location = new Point(6, 92);
            rdoVuong.Name = "rdoVuong";
            rdoVuong.Size = new Size(139, 32);
            rdoVuong.TabIndex = 1;
            rdoVuong.TabStop = true;
            rdoVuong.Text = "Hình vuông";
            rdoVuong.UseVisualStyleBackColor = true;
            rdoVuong.CheckedChanged += rdoVuong_CheckedChanged;
            // 
            // rdoTron
            // 
            rdoTron.AutoSize = true;
            rdoTron.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoTron.Location = new Point(6, 38);
            rdoTron.Name = "rdoTron";
            rdoTron.Size = new Size(120, 32);
            rdoTron.TabIndex = 0;
            rdoTron.TabStop = true;
            rdoTron.Text = "Hình tròn";
            rdoTron.UseVisualStyleBackColor = true;
            rdoTron.CheckedChanged += rdoTron_CheckedChanged;
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(122, 359);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(150, 48);
            btnThucHien.TabIndex = 5;
            btnThucHien.Text = "Thực hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(332, 359);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 48);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(561, 359);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 48);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // grVuong
            // 
            grVuong.Controls.Add(txt_Vuong_DienTich);
            grVuong.Controls.Add(label7);
            grVuong.Controls.Add(txt_Vuong_ChuVi);
            grVuong.Controls.Add(txt_Vuong_A);
            grVuong.Controls.Add(label8);
            grVuong.Controls.Add(label9);
            grVuong.Location = new Point(122, 437);
            grVuong.Name = "grVuong";
            grVuong.Size = new Size(374, 293);
            grVuong.TabIndex = 9;
            grVuong.TabStop = false;
            grVuong.Text = "Hình vuông";
            // 
            // txt_Vuong_DienTich
            // 
            txt_Vuong_DienTich.Location = new Point(199, 156);
            txt_Vuong_DienTich.Name = "txt_Vuong_DienTich";
            txt_Vuong_DienTich.Size = new Size(150, 39);
            txt_Vuong_DienTich.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 159);
            label7.Name = "label7";
            label7.Size = new Size(115, 32);
            label7.TabIndex = 6;
            label7.Text = "Diện tích:";
            // 
            // txt_Vuong_ChuVi
            // 
            txt_Vuong_ChuVi.Location = new Point(199, 92);
            txt_Vuong_ChuVi.Name = "txt_Vuong_ChuVi";
            txt_Vuong_ChuVi.Size = new Size(150, 39);
            txt_Vuong_ChuVi.TabIndex = 5;
            // 
            // txt_Vuong_A
            // 
            txt_Vuong_A.Location = new Point(199, 38);
            txt_Vuong_A.Name = "txt_Vuong_A";
            txt_Vuong_A.Size = new Size(150, 39);
            txt_Vuong_A.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 95);
            label8.Name = "label8";
            label8.Size = new Size(87, 32);
            label8.TabIndex = 3;
            label8.Text = "Chu vi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 40);
            label9.Name = "label9";
            label9.Size = new Size(157, 32);
            label9.TabIndex = 2;
            label9.Text = "Nhập cạnh A:";
            // 
            // grTamGiac
            // 
            grTamGiac.Controls.Add(txt_TamGiac_C);
            grTamGiac.Controls.Add(label4);
            grTamGiac.Controls.Add(txt_TamGiac_B);
            grTamGiac.Controls.Add(label14);
            grTamGiac.Controls.Add(txt_TamGiac_DienTich);
            grTamGiac.Controls.Add(label15);
            grTamGiac.Controls.Add(txt_TamGiac_ChuVi);
            grTamGiac.Controls.Add(txt_TamGiac_A);
            grTamGiac.Controls.Add(label16);
            grTamGiac.Controls.Add(label17);
            grTamGiac.Location = new Point(122, 437);
            grTamGiac.Name = "grTamGiac";
            grTamGiac.Size = new Size(374, 360);
            grTamGiac.TabIndex = 10;
            grTamGiac.TabStop = false;
            grTamGiac.Text = "Hình tam giác";
            // 
            // txt_TamGiac_C
            // 
            txt_TamGiac_C.Location = new Point(199, 147);
            txt_TamGiac_C.Name = "txt_TamGiac_C";
            txt_TamGiac_C.Size = new Size(150, 39);
            txt_TamGiac_C.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 149);
            label4.Name = "label4";
            label4.Size = new Size(157, 32);
            label4.TabIndex = 10;
            label4.Text = "Nhập cạnh C:";
            // 
            // txt_TamGiac_B
            // 
            txt_TamGiac_B.Location = new Point(199, 94);
            txt_TamGiac_B.Name = "txt_TamGiac_B";
            txt_TamGiac_B.Size = new Size(150, 39);
            txt_TamGiac_B.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 96);
            label14.Name = "label14";
            label14.Size = new Size(156, 32);
            label14.TabIndex = 8;
            label14.Text = "Nhập cạnh B:";
            // 
            // txt_TamGiac_DienTich
            // 
            txt_TamGiac_DienTich.Location = new Point(196, 273);
            txt_TamGiac_DienTich.Name = "txt_TamGiac_DienTich";
            txt_TamGiac_DienTich.Size = new Size(150, 39);
            txt_TamGiac_DienTich.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 276);
            label15.Name = "label15";
            label15.Size = new Size(115, 32);
            label15.TabIndex = 6;
            label15.Text = "Diện tích:";
            // 
            // txt_TamGiac_ChuVi
            // 
            txt_TamGiac_ChuVi.Location = new Point(196, 209);
            txt_TamGiac_ChuVi.Name = "txt_TamGiac_ChuVi";
            txt_TamGiac_ChuVi.Size = new Size(150, 39);
            txt_TamGiac_ChuVi.TabIndex = 5;
            // 
            // txt_TamGiac_A
            // 
            txt_TamGiac_A.Location = new Point(199, 38);
            txt_TamGiac_A.Name = "txt_TamGiac_A";
            txt_TamGiac_A.Size = new Size(150, 39);
            txt_TamGiac_A.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 212);
            label16.Name = "label16";
            label16.Size = new Size(87, 32);
            label16.TabIndex = 3;
            label16.Text = "Chu vi:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(21, 40);
            label17.Name = "label17";
            label17.Size = new Size(157, 32);
            label17.TabIndex = 2;
            label17.Text = "Nhập cạnh A:";
            // 
            // grTron
            // 
            grTron.Controls.Add(txt_Tron_DienTich);
            grTron.Controls.Add(label18);
            grTron.Controls.Add(txt_Tron_ChuVi);
            grTron.Controls.Add(txt_Tron_BanKinh);
            grTron.Controls.Add(label19);
            grTron.Controls.Add(label20);
            grTron.Location = new Point(122, 439);
            grTron.Name = "grTron";
            grTron.Size = new Size(374, 257);
            grTron.TabIndex = 12;
            grTron.TabStop = false;
            grTron.Text = "Hình tròn";
            // 
            // txt_Tron_DienTich
            // 
            txt_Tron_DienTich.Location = new Point(199, 166);
            txt_Tron_DienTich.Name = "txt_Tron_DienTich";
            txt_Tron_DienTich.Size = new Size(150, 39);
            txt_Tron_DienTich.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(21, 169);
            label18.Name = "label18";
            label18.Size = new Size(115, 32);
            label18.TabIndex = 6;
            label18.Text = "Diện tích:";
            // 
            // txt_Tron_ChuVi
            // 
            txt_Tron_ChuVi.Location = new Point(199, 102);
            txt_Tron_ChuVi.Name = "txt_Tron_ChuVi";
            txt_Tron_ChuVi.Size = new Size(150, 39);
            txt_Tron_ChuVi.TabIndex = 5;
            // 
            // txt_Tron_BanKinh
            // 
            txt_Tron_BanKinh.Location = new Point(199, 38);
            txt_Tron_BanKinh.Name = "txt_Tron_BanKinh";
            txt_Tron_BanKinh.Size = new Size(150, 39);
            txt_Tron_BanKinh.TabIndex = 4;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(21, 105);
            label19.Name = "label19";
            label19.Size = new Size(87, 32);
            label19.TabIndex = 3;
            label19.Text = "Chu vi:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(21, 40);
            label20.Name = "label20";
            label20.Size = new Size(177, 32);
            label20.TabIndex = 2;
            label20.Text = "Nhập bán kính:";
            // 
            // grChuNhat
            // 
            grChuNhat.Controls.Add(txt_ChuNhat_B);
            grChuNhat.Controls.Add(label13);
            grChuNhat.Controls.Add(txt_ChuNhat_DienTich);
            grChuNhat.Controls.Add(label10);
            grChuNhat.Controls.Add(txt_ChuNhat_ChuVi);
            grChuNhat.Controls.Add(txt_ChuNhat_A);
            grChuNhat.Controls.Add(label11);
            grChuNhat.Controls.Add(label12);
            grChuNhat.Location = new Point(122, 437);
            grChuNhat.Name = "grChuNhat";
            grChuNhat.Size = new Size(374, 293);
            grChuNhat.TabIndex = 9;
            grChuNhat.TabStop = false;
            grChuNhat.Text = "Hình chữ nhật";
            // 
            // txt_ChuNhat_B
            // 
            txt_ChuNhat_B.Location = new Point(199, 94);
            txt_ChuNhat_B.Name = "txt_ChuNhat_B";
            txt_ChuNhat_B.Size = new Size(150, 39);
            txt_ChuNhat_B.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 96);
            label13.Name = "label13";
            label13.Size = new Size(156, 32);
            label13.TabIndex = 8;
            label13.Text = "Nhập cạnh B:";
            // 
            // txt_ChuNhat_DienTich
            // 
            txt_ChuNhat_DienTich.Location = new Point(199, 220);
            txt_ChuNhat_DienTich.Name = "txt_ChuNhat_DienTich";
            txt_ChuNhat_DienTich.Size = new Size(150, 39);
            txt_ChuNhat_DienTich.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 223);
            label10.Name = "label10";
            label10.Size = new Size(115, 32);
            label10.TabIndex = 6;
            label10.Text = "Diện tích:";
            // 
            // txt_ChuNhat_ChuVi
            // 
            txt_ChuNhat_ChuVi.Location = new Point(199, 156);
            txt_ChuNhat_ChuVi.Name = "txt_ChuNhat_ChuVi";
            txt_ChuNhat_ChuVi.Size = new Size(150, 39);
            txt_ChuNhat_ChuVi.TabIndex = 5;
            // 
            // txt_ChuNhat_A
            // 
            txt_ChuNhat_A.Location = new Point(199, 38);
            txt_ChuNhat_A.Name = "txt_ChuNhat_A";
            txt_ChuNhat_A.Size = new Size(150, 39);
            txt_ChuNhat_A.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 159);
            label11.Name = "label11";
            label11.Size = new Size(87, 32);
            label11.TabIndex = 3;
            label11.Text = "Chu vi:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 40);
            label12.Name = "label12";
            label12.Size = new Size(157, 32);
            label12.TabIndex = 2;
            label12.Text = "Nhập cạnh A:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(865, 768);
            Controls.Add(grTamGiac);
            Controls.Add(grTron);
            Controls.Add(grChon);
            Controls.Add(grChuNhat);
            Controls.Add(grVuong);
            Controls.Add(btnThoat);
            Controls.Add(btnReset);
            Controls.Add(btnThucHien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Tìm chu vi và diện tích";
            Load += Form1_Load;
            grChon.ResumeLayout(false);
            grChon.PerformLayout();
            grVuong.ResumeLayout(false);
            grVuong.PerformLayout();
            grTamGiac.ResumeLayout(false);
            grTamGiac.PerformLayout();
            grTron.ResumeLayout(false);
            grTron.PerformLayout();
            grChuNhat.ResumeLayout(false);
            grChuNhat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox grChon;
        private RadioButton rdoChuNhat;
        private RadioButton rdoTamGiac;
        private RadioButton rdoVuong;
        private RadioButton rdoTron;
        private Button btnThucHien;
        private Button btnReset;
        private Button btnThoat;
        private GroupBox grVuong;
        private TextBox txtVuong__DienTich;
        private Label label6;
        private TextBox txtVuong_ChuVi;
        private TextBox txtVuong_Canh;
        private Label label5;
        private GroupBox grTron;
        private TextBox txt_Vuong_DienTich;
        private Label label7;
        private TextBox txt_Vuong_ChuVi;
        private TextBox txt_Vuong_A;
        private Label label8;
        private Label label9;
        private GroupBox grChuNhat;
        private TextBox txt_ChuNhat_B;
        private Label label13;
        private TextBox txt_ChuNhat_DienTich;
        private Label label10;
        private TextBox txt_ChuNhat_ChuVi;
        private TextBox txt_ChuNhat_A;
        private Label label11;
        private Label label12;
        private GroupBox grTamGiac;
        private TextBox txt_TamGiac_DienTich;
        private Label label15;
        private TextBox txt_TamGiac_ChuVi;
        private TextBox txt_TamGiac_A;
        private Label label16;
        private Label label17;
        private TextBox txt_TamGiac_C;
        private Label label4;
        private TextBox txt_TamGiac_B;
        private Label label14;
        private TextBox txt_Tron_DienTich;
        private Label label18;
        private TextBox txt_Tron_ChuVi;
        private TextBox txt_Tron_BanKinh;
        private Label label19;
        private Label label20;
    }
}
