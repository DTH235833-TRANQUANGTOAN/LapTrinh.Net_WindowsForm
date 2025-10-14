namespace Buoi05_Bai_7
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
            txtNhap = new TextBox();
            txtKQ = new TextBox();
            btnXuat = new Button();
            btnLamLai = new Button();
            gr1 = new GroupBox();
            btnTong = new Button();
            label5 = new Label();
            txtTongLe = new TextBox();
            label4 = new Label();
            txtTongChan = new TextBox();
            label3 = new Label();
            txtTongMang = new TextBox();
            gr2 = new GroupBox();
            btnTim = new Button();
            label7 = new Label();
            txtMin = new TextBox();
            label8 = new Label();
            txtMax = new TextBox();
            gr3 = new GroupBox();
            btnThayThe = new Button();
            label6 = new Label();
            txtSoThay = new TextBox();
            label9 = new Label();
            txtViTri = new TextBox();
            gr4 = new GroupBox();
            rdoGiam = new RadioButton();
            rdoTang = new RadioButton();
            btnSapXep = new Button();
            btnThoat = new Button();
            gr1.SuspendLayout();
            gr2.SuspendLayout();
            gr3.SuspendLayout();
            gr4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 37);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 0;
            label1.Text = "Nhập mảng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 88);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 1;
            label2.Text = "Kết quả:";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(187, 37);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(500, 39);
            txtNhap.TabIndex = 2;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(187, 88);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(500, 39);
            txtKQ.TabIndex = 3;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(771, 17);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(156, 59);
            btnXuat.TabIndex = 4;
            btnXuat.Text = "Xuất mảng";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnLamLai
            // 
            btnLamLai.Location = new Point(771, 88);
            btnLamLai.Name = "btnLamLai";
            btnLamLai.Size = new Size(156, 59);
            btnLamLai.TabIndex = 5;
            btnLamLai.Text = "Làm lại";
            btnLamLai.UseVisualStyleBackColor = true;
            btnLamLai.Click += btnLamLai_Click;
            // 
            // gr1
            // 
            gr1.Controls.Add(btnTong);
            gr1.Controls.Add(label5);
            gr1.Controls.Add(txtTongLe);
            gr1.Controls.Add(label4);
            gr1.Controls.Add(txtTongChan);
            gr1.Controls.Add(label3);
            gr1.Controls.Add(txtTongMang);
            gr1.Location = new Point(36, 148);
            gr1.Name = "gr1";
            gr1.Size = new Size(424, 243);
            gr1.TabIndex = 6;
            gr1.TabStop = false;
            gr1.Text = "Tổng";
            // 
            // btnTong
            // 
            btnTong.Location = new Point(338, 52);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(80, 155);
            btnTong.TabIndex = 7;
            btnTong.Text = "Tổng";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 171);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 11;
            label5.Text = "Tổng lẻ:";
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(174, 168);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(150, 39);
            txtTongLe.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 116);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
            label4.TabIndex = 9;
            label4.Text = "Tổng chẵn:";
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(174, 113);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(150, 39);
            txtTongChan.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 55);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 7;
            label3.Text = "Tổng mảng:";
            // 
            // txtTongMang
            // 
            txtTongMang.Location = new Point(174, 52);
            txtTongMang.Name = "txtTongMang";
            txtTongMang.Size = new Size(150, 39);
            txtTongMang.TabIndex = 0;
            // 
            // gr2
            // 
            gr2.Controls.Add(btnTim);
            gr2.Controls.Add(label7);
            gr2.Controls.Add(txtMin);
            gr2.Controls.Add(label8);
            gr2.Controls.Add(txtMax);
            gr2.Location = new Point(543, 153);
            gr2.Name = "gr2";
            gr2.Size = new Size(424, 243);
            gr2.TabIndex = 12;
            gr2.TabStop = false;
            gr2.Text = "Tìm max min";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(338, 52);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 155);
            btnTim.TabIndex = 7;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 116);
            label7.Name = "label7";
            label7.Size = new Size(61, 32);
            label7.TabIndex = 9;
            label7.Text = "Min:";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(174, 113);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(150, 39);
            txtMin.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 55);
            label8.Name = "label8";
            label8.Size = new Size(64, 32);
            label8.TabIndex = 7;
            label8.Text = "Max:";
            // 
            // txtMax
            // 
            txtMax.Location = new Point(174, 52);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(150, 39);
            txtMax.TabIndex = 0;
            // 
            // gr3
            // 
            gr3.Controls.Add(btnThayThe);
            gr3.Controls.Add(label6);
            gr3.Controls.Add(txtSoThay);
            gr3.Controls.Add(label9);
            gr3.Controls.Add(txtViTri);
            gr3.Location = new Point(543, 402);
            gr3.Name = "gr3";
            gr3.Size = new Size(424, 189);
            gr3.TabIndex = 13;
            gr3.TabStop = false;
            gr3.Text = "Thay thế";
            // 
            // btnThayThe
            // 
            btnThayThe.Location = new Point(338, 52);
            btnThayThe.Name = "btnThayThe";
            btnThayThe.Size = new Size(80, 100);
            btnThayThe.TabIndex = 7;
            btnThayThe.Text = "Thay thế";
            btnThayThe.UseVisualStyleBackColor = true;
            btnThayThe.Click += btnThayThe_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 116);
            label6.Name = "label6";
            label6.Size = new Size(136, 32);
            label6.TabIndex = 9;
            label6.Text = "Số thay thế";
            // 
            // txtSoThay
            // 
            txtSoThay.Location = new Point(174, 113);
            txtSoThay.Name = "txtSoThay";
            txtSoThay.Size = new Size(150, 39);
            txtSoThay.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 55);
            label9.Name = "label9";
            label9.Size = new Size(159, 32);
            label9.TabIndex = 7;
            label9.Text = "Vị trí thay thế";
            // 
            // txtViTri
            // 
            txtViTri.Location = new Point(174, 52);
            txtViTri.Name = "txtViTri";
            txtViTri.Size = new Size(150, 39);
            txtViTri.TabIndex = 0;
            // 
            // gr4
            // 
            gr4.Controls.Add(rdoGiam);
            gr4.Controls.Add(rdoTang);
            gr4.Controls.Add(btnSapXep);
            gr4.Location = new Point(36, 402);
            gr4.Name = "gr4";
            gr4.Size = new Size(424, 189);
            gr4.TabIndex = 14;
            gr4.TabStop = false;
            gr4.Text = "Sắp Xếp";
            // 
            // rdoGiam
            // 
            rdoGiam.AutoSize = true;
            rdoGiam.Location = new Point(26, 112);
            rdoGiam.Name = "rdoGiam";
            rdoGiam.Size = new Size(183, 36);
            rdoGiam.TabIndex = 9;
            rdoGiam.TabStop = true;
            rdoGiam.Text = "Sắp xếp giảm";
            rdoGiam.UseVisualStyleBackColor = true;
            // 
            // rdoTang
            // 
            rdoTang.AutoSize = true;
            rdoTang.Location = new Point(26, 55);
            rdoTang.Name = "rdoTang";
            rdoTang.Size = new Size(178, 36);
            rdoTang.TabIndex = 8;
            rdoTang.TabStop = true;
            rdoTang.Text = "Sắp xếp tăng";
            rdoTang.UseVisualStyleBackColor = true;
            // 
            // btnSapXep
            // 
            btnSapXep.Location = new Point(338, 52);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(80, 100);
            btnSapXep.TabIndex = 7;
            btnSapXep.Text = "Sắp xếp";
            btnSapXep.UseVisualStyleBackColor = true;
            btnSapXep.Click += btnSapXep_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(434, 597);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(161, 65);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1040, 681);
            Controls.Add(btnThoat);
            Controls.Add(gr4);
            Controls.Add(gr3);
            Controls.Add(gr2);
            Controls.Add(gr1);
            Controls.Add(btnLamLai);
            Controls.Add(btnXuat);
            Controls.Add(txtKQ);
            Controls.Add(txtNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Mảng Số Nguyên";
            gr1.ResumeLayout(false);
            gr1.PerformLayout();
            gr2.ResumeLayout(false);
            gr2.PerformLayout();
            gr3.ResumeLayout(false);
            gr3.PerformLayout();
            gr4.ResumeLayout(false);
            gr4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNhap;
        private TextBox txtKQ;
        private Button btnXuat;
        private Button btnLamLai;
        private GroupBox gr1;
        private Label label3;
        private TextBox txtTongMang;
        private Button btnTong;
        private Label label5;
        private TextBox txtTongLe;
        private Label label4;
        private TextBox txtTongChan;
        private GroupBox gr2;
        private Button btnTim;
        private Label label7;
        private TextBox txtMin;
        private Label label8;
        private TextBox txtMax;
        private GroupBox gr3;
        private Button btnThayThe;
        private Label label6;
        private TextBox txtSoThay;
        private Label label9;
        private TextBox txtViTri;
        private GroupBox gr4;
        private RadioButton rdoGiam;
        private RadioButton rdoTang;
        private Button btnSapXep;
        private Button btnThoat;
    }
}
