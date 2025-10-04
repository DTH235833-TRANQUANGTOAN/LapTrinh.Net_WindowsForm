namespace Buoi02_Bai_2._7
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
            btnTong = new Button();
            grpThongTin = new GroupBox();
            tboxb = new TextBox();
            tboxa = new TextBox();
            lbb = new Label();
            lba = new Label();
            label1 = new Label();
            tboxKetQua = new TextBox();
            lbKetQua = new Label();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // btnTong
            // 
            btnTong.Font = new Font("Segoe UI", 12F);
            btnTong.Location = new Point(286, 345);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(219, 46);
            btnTong.TabIndex = 5;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(tboxb);
            grpThongTin.Controls.Add(tboxa);
            grpThongTin.Controls.Add(lbb);
            grpThongTin.Controls.Add(lba);
            grpThongTin.Font = new Font("Segoe UI", 11F);
            grpThongTin.Location = new Point(245, 80);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(303, 199);
            grpThongTin.TabIndex = 4;
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
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 41);
            label1.TabIndex = 3;
            label1.Text = "PHEP TOAN";
            // 
            // tboxKetQua
            // 
            tboxKetQua.Location = new Point(315, 288);
            tboxKetQua.Name = "tboxKetQua";
            tboxKetQua.Size = new Size(190, 31);
            tboxKetQua.TabIndex = 4;
            // 
            // lbKetQua
            // 
            lbKetQua.AutoSize = true;
            lbKetQua.Font = new Font("Segoe UI", 9F);
            lbKetQua.Location = new Point(245, 291);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(76, 25);
            lbKetQua.TabIndex = 6;
            lbKetQua.Text = "Ket qua:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbKetQua);
            Controls.Add(tboxKetQua);
            Controls.Add(btnTong);
            Controls.Add(grpThongTin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Buoi02_Bai_2.7";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTong;
        private GroupBox grpThongTin;
        private TextBox tboxb;
        private TextBox tboxa;
        private Label lbb;
        private Label lba;
        private Label label1;
        private TextBox tboxKetQua;
        private Label lbKetQua;
    }
}
