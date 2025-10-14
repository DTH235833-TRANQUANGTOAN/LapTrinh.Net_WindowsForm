namespace Buoi05_Bai_5
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
            gr1 = new GroupBox();
            txtMangGoc = new TextBox();
            gr2 = new GroupBox();
            txtKQ = new TextBox();
            btnMangNgauNhien = new Button();
            btnTongMang = new Button();
            btnDemLe = new Button();
            btnTongLe = new Button();
            btnSapXepGiam = new Button();
            btnsapXepTang = new Button();
            btnCong2 = new Button();
            btnTimMin = new Button();
            gr1.SuspendLayout();
            gr2.SuspendLayout();
            SuspendLayout();
            // 
            // gr1
            // 
            gr1.Controls.Add(txtMangGoc);
            gr1.Location = new Point(33, 25);
            gr1.Name = "gr1";
            gr1.Size = new Size(595, 104);
            gr1.TabIndex = 0;
            gr1.TabStop = false;
            gr1.Text = "Mảng gốc";
            // 
            // txtMangGoc
            // 
            txtMangGoc.Location = new Point(35, 38);
            txtMangGoc.Name = "txtMangGoc";
            txtMangGoc.Size = new Size(536, 39);
            txtMangGoc.TabIndex = 0;
            // 
            // gr2
            // 
            gr2.Controls.Add(txtKQ);
            gr2.Location = new Point(33, 145);
            gr2.Name = "gr2";
            gr2.Size = new Size(595, 104);
            gr2.TabIndex = 1;
            gr2.TabStop = false;
            gr2.Text = "kết quả";
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(35, 38);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(536, 39);
            txtKQ.TabIndex = 0;
            // 
            // btnMangNgauNhien
            // 
            btnMangNgauNhien.Location = new Point(33, 264);
            btnMangNgauNhien.Name = "btnMangNgauNhien";
            btnMangNgauNhien.Size = new Size(271, 41);
            btnMangNgauNhien.TabIndex = 2;
            btnMangNgauNhien.Text = "Xuất mảng ngẫu nhiên";
            btnMangNgauNhien.UseVisualStyleBackColor = true;
            btnMangNgauNhien.Click += btnMangNgauNhien_Click;
            // 
            // btnTongMang
            // 
            btnTongMang.Location = new Point(33, 311);
            btnTongMang.Name = "btnTongMang";
            btnTongMang.Size = new Size(271, 41);
            btnTongMang.TabIndex = 3;
            btnTongMang.Text = "Tính tổng giá trị mảng";
            btnTongMang.UseVisualStyleBackColor = true;
            btnTongMang.Click += btnTongMang_Click;
            // 
            // btnDemLe
            // 
            btnDemLe.Location = new Point(33, 358);
            btnDemLe.Name = "btnDemLe";
            btnDemLe.Size = new Size(271, 41);
            btnDemLe.TabIndex = 4;
            btnDemLe.Text = "Đếm số phần tử lẻ";
            btnDemLe.UseVisualStyleBackColor = true;
            btnDemLe.Click += btnDemLe_Click;
            // 
            // btnTongLe
            // 
            btnTongLe.Location = new Point(33, 405);
            btnTongLe.Name = "btnTongLe";
            btnTongLe.Size = new Size(271, 41);
            btnTongLe.TabIndex = 5;
            btnTongLe.Text = "Tổng giá trị phần tử lẻ";
            btnTongLe.UseVisualStyleBackColor = true;
            btnTongLe.Click += btnTongLe_Click;
            // 
            // btnSapXepGiam
            // 
            btnSapXepGiam.Location = new Point(357, 405);
            btnSapXepGiam.Name = "btnSapXepGiam";
            btnSapXepGiam.Size = new Size(271, 41);
            btnSapXepGiam.TabIndex = 9;
            btnSapXepGiam.Text = "Sắp mảng giảm";
            btnSapXepGiam.UseVisualStyleBackColor = true;
            btnSapXepGiam.Click += btnSapXepGiam_Click;
            // 
            // btnsapXepTang
            // 
            btnsapXepTang.Location = new Point(357, 358);
            btnsapXepTang.Name = "btnsapXepTang";
            btnsapXepTang.Size = new Size(271, 41);
            btnsapXepTang.TabIndex = 8;
            btnsapXepTang.Text = "Sắp mảng tăng";
            btnsapXepTang.UseVisualStyleBackColor = true;
            btnsapXepTang.Click += btnsapXepTang_Click;
            // 
            // btnCong2
            // 
            btnCong2.Location = new Point(357, 311);
            btnCong2.Name = "btnCong2";
            btnCong2.Size = new Size(271, 41);
            btnCong2.TabIndex = 7;
            btnCong2.Text = "Tăng mỗi ptu lên 2";
            btnCong2.UseVisualStyleBackColor = true;
            btnCong2.Click += btnCong2_Click;
            // 
            // btnTimMin
            // 
            btnTimMin.Location = new Point(357, 264);
            btnTimMin.Name = "btnTimMin";
            btnTimMin.Size = new Size(271, 41);
            btnTimMin.TabIndex = 6;
            btnTimMin.Text = "Tìm phần tử nhỏ nhất";
            btnTimMin.UseVisualStyleBackColor = true;
            btnTimMin.Click += btnTimMin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(661, 490);
            Controls.Add(btnSapXepGiam);
            Controls.Add(btnsapXepTang);
            Controls.Add(btnCong2);
            Controls.Add(btnTimMin);
            Controls.Add(btnTongLe);
            Controls.Add(btnDemLe);
            Controls.Add(btnTongMang);
            Controls.Add(btnMangNgauNhien);
            Controls.Add(gr2);
            Controls.Add(gr1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Working with array";
            gr1.ResumeLayout(false);
            gr1.PerformLayout();
            gr2.ResumeLayout(false);
            gr2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gr1;
        private TextBox txtMangGoc;
        private GroupBox gr2;
        private TextBox txtKQ;
        private Button btnMangNgauNhien;
        private Button btnTongMang;
        private Button btnDemLe;
        private Button btnTongLe;
        private Button btnSapXepGiam;
        private Button btnsapXepTang;
        private Button btnCong2;
        private Button btnTimMin;
    }
}
