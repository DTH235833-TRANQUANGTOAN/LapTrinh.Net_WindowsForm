namespace Buoi06_Bai_2
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
            txtHoTen = new TextBox();
            btnThem = new Button();
            rdoLopB = new RadioButton();
            rdoLopA = new RadioButton();
            gr1 = new GroupBox();
            grLopA = new GroupBox();
            lbLopA = new ListBox();
            grLopB = new GroupBox();
            lbLopB = new ListBox();
            btnAquaB = new Button();
            btnBquaA = new Button();
            btnallAQuaB = new Button();
            btnallBquaA = new Button();
            btnTong = new Button();
            btnThoat = new Button();
            gr1.SuspendLayout();
            grLopA.SuspendLayout();
            grLopB.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(128, 30);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(569, 39);
            txtHoTen.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(740, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 38);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // rdoLopB
            // 
            rdoLopB.AutoSize = true;
            rdoLopB.Location = new Point(171, 49);
            rdoLopB.Name = "rdoLopB";
            rdoLopB.Size = new Size(99, 36);
            rdoLopB.TabIndex = 3;
            rdoLopB.TabStop = true;
            rdoLopB.Text = "Lớp B";
            rdoLopB.UseVisualStyleBackColor = true;
            // 
            // rdoLopA
            // 
            rdoLopA.AutoSize = true;
            rdoLopA.Location = new Point(23, 49);
            rdoLopA.Name = "rdoLopA";
            rdoLopA.Size = new Size(100, 36);
            rdoLopA.TabIndex = 4;
            rdoLopA.TabStop = true;
            rdoLopA.Text = "Lớp A";
            rdoLopA.UseVisualStyleBackColor = true;
            // 
            // gr1
            // 
            gr1.Controls.Add(rdoLopA);
            gr1.Controls.Add(rdoLopB);
            gr1.Location = new Point(290, 101);
            gr1.Name = "gr1";
            gr1.Size = new Size(285, 112);
            gr1.TabIndex = 5;
            gr1.TabStop = false;
            gr1.Text = "Chọn lớp";
            // 
            // grLopA
            // 
            grLopA.Controls.Add(lbLopA);
            grLopA.Location = new Point(12, 222);
            grLopA.Name = "grLopA";
            grLopA.Size = new Size(300, 290);
            grLopA.TabIndex = 6;
            grLopA.TabStop = false;
            grLopA.Text = "Lớp A";
            // 
            // lbLopA
            // 
            lbLopA.FormattingEnabled = true;
            lbLopA.ItemHeight = 32;
            lbLopA.Location = new Point(6, 38);
            lbLopA.Name = "lbLopA";
            lbLopA.SelectionMode = SelectionMode.MultiSimple;
            lbLopA.Size = new Size(288, 228);
            lbLopA.TabIndex = 0;
            // 
            // grLopB
            // 
            grLopB.Controls.Add(lbLopB);
            grLopB.Location = new Point(583, 222);
            grLopB.Name = "grLopB";
            grLopB.Size = new Size(300, 290);
            grLopB.TabIndex = 7;
            grLopB.TabStop = false;
            grLopB.Text = "Lớp B";
            // 
            // lbLopB
            // 
            lbLopB.FormattingEnabled = true;
            lbLopB.ItemHeight = 32;
            lbLopB.Location = new Point(6, 38);
            lbLopB.Name = "lbLopB";
            lbLopB.SelectionMode = SelectionMode.MultiSimple;
            lbLopB.Size = new Size(288, 228);
            lbLopB.TabIndex = 0;
            // 
            // btnAquaB
            // 
            btnAquaB.Location = new Point(391, 235);
            btnAquaB.Name = "btnAquaB";
            btnAquaB.Size = new Size(112, 59);
            btnAquaB.TabIndex = 8;
            btnAquaB.Text = ">";
            btnAquaB.UseVisualStyleBackColor = true;
            btnAquaB.Click += btnAquaB_Click;
            // 
            // btnBquaA
            // 
            btnBquaA.Location = new Point(391, 300);
            btnBquaA.Name = "btnBquaA";
            btnBquaA.Size = new Size(112, 59);
            btnBquaA.TabIndex = 9;
            btnBquaA.Text = "<";
            btnBquaA.UseVisualStyleBackColor = true;
            btnBquaA.Click += btnBquaA_Click;
            // 
            // btnallAQuaB
            // 
            btnallAQuaB.Location = new Point(391, 365);
            btnallAQuaB.Name = "btnallAQuaB";
            btnallAQuaB.Size = new Size(112, 59);
            btnallAQuaB.TabIndex = 10;
            btnallAQuaB.Text = ">>";
            btnallAQuaB.UseVisualStyleBackColor = true;
            btnallAQuaB.Click += btnallAQuaB_Click;
            // 
            // btnallBquaA
            // 
            btnallBquaA.Location = new Point(391, 429);
            btnallBquaA.Name = "btnallBquaA";
            btnallBquaA.Size = new Size(112, 59);
            btnallBquaA.TabIndex = 11;
            btnallBquaA.Text = "<<";
            btnallBquaA.UseVisualStyleBackColor = true;
            btnallBquaA.Click += btnallBquaA_Click;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(128, 518);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(275, 61);
            btnTong.TabIndex = 12;
            btnTong.Text = "Tổng số sinh viên";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(546, 518);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(151, 61);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(895, 628);
            Controls.Add(btnThoat);
            Controls.Add(btnTong);
            Controls.Add(btnallBquaA);
            Controls.Add(btnallAQuaB);
            Controls.Add(btnBquaA);
            Controls.Add(btnAquaB);
            Controls.Add(grLopB);
            Controls.Add(grLopA);
            Controls.Add(gr1);
            Controls.Add(btnThem);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            gr1.ResumeLayout(false);
            gr1.PerformLayout();
            grLopA.ResumeLayout(false);
            grLopB.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private Button btnThem;
        private RadioButton rdoLopB;
        private RadioButton rdoLopA;
        private GroupBox gr1;
        private GroupBox grLopA;
        private ListBox lbLopA;
        private GroupBox grLopB;
        private ListBox lbLopB;
        private Button btnAquaB;
        private Button btnBquaA;
        private Button btnallAQuaB;
        private Button btnallBquaA;
        private Button btnTong;
        private Button btnThoat;
    }
}
