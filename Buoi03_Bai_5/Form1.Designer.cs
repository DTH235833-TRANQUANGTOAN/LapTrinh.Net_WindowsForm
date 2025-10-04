namespace Buoi03_Bai_5
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
            rdo2 = new RadioButton();
            rdo1 = new RadioButton();
            groupBox1 = new GroupBox();
            txtKQ = new TextBox();
            txtN = new TextBox();
            txtM = new TextBox();
            lb1 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnTinh = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rdo2
            // 
            rdo2.AutoSize = true;
            rdo2.Location = new Point(16, 85);
            rdo2.Name = "rdo2";
            rdo2.Size = new Size(367, 31);
            rdo2.TabIndex = 1;
            rdo2.TabStop = true;
            rdo2.Text = "Ước số chung lớn nhất của n và m";
            rdo2.UseVisualStyleBackColor = true;
            // 
            // rdo1
            // 
            rdo1.AutoSize = true;
            rdo1.Location = new Point(16, 34);
            rdo1.Name = "rdo1";
            rdo1.Size = new Size(320, 31);
            rdo1.TabIndex = 2;
            rdo1.TabStop = true;
            rdo1.Text = "Các ước số chung của n và m";
            rdo1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo2);
            groupBox1.Controls.Add(rdo1);
            groupBox1.Location = new Point(390, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 132);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn";
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(77, 223);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(765, 35);
            txtKQ.TabIndex = 7;
            // 
            // txtN
            // 
            txtN.Location = new Point(201, 61);
            txtN.Name = "txtN";
            txtN.Size = new Size(148, 35);
            txtN.TabIndex = 9;
            // 
            // txtM
            // 
            txtM.Location = new Point(201, 119);
            txtM.Name = "txtM";
            txtM.Size = new Size(148, 35);
            txtM.TabIndex = 10;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1.ForeColor = SystemColors.ControlText;
            lb1.Location = new Point(77, 188);
            lb1.Name = "lb1";
            lb1.Size = new Size(117, 27);
            lb1.TabIndex = 11;
            lb1.Text = "Kết quả là:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(77, 64);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 12;
            label1.Text = "Nhập m= ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(77, 122);
            label2.Name = "label2";
            label2.Size = new Size(102, 27);
            label2.TabIndex = 13;
            label2.Text = "Nhập n= ";
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(77, 280);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(126, 49);
            btnTinh.TabIndex = 14;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(390, 280);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(126, 49);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(716, 280);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(126, 49);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(865, 348);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb1);
            Controls.Add(txtM);
            Controls.Add(txtN);
            Controls.Add(txtKQ);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Lệnh lặp";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdo2;
        private RadioButton rdo1;
        private GroupBox groupBox1;
        private TextBox txtKQ;
        private TextBox txtN;
        private TextBox txtM;
        private Label lb1;
        private Label label1;
        private Label label2;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
    }
}
