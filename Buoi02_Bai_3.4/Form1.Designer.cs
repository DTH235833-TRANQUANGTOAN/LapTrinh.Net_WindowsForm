namespace Buoi02_Bai_3._4
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
            btnGiai = new Button();
            grpThongTin = new GroupBox();
            tboxb = new TextBox();
            lbb = new Label();
            tboxc = new TextBox();
            tboxa = new TextBox();
            lbc = new Label();
            lba = new Label();
            label1 = new Label();
            tboxkq = new TextBox();
            lbKetQua = new Label();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // btnGiai
            // 
            btnGiai.Location = new Point(291, 378);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(202, 62);
            btnGiai.TabIndex = 25;
            btnGiai.Text = "Giai";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(tboxb);
            grpThongTin.Controls.Add(lbb);
            grpThongTin.Controls.Add(tboxc);
            grpThongTin.Controls.Add(tboxa);
            grpThongTin.Controls.Add(lbc);
            grpThongTin.Controls.Add(lba);
            grpThongTin.Font = new Font("Segoe UI", 11F);
            grpThongTin.Location = new Point(182, 87);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(437, 194);
            grpThongTin.TabIndex = 24;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thong Tin";
            // 
            // tboxb
            // 
            tboxb.Location = new Point(153, 95);
            tboxb.Name = "tboxb";
            tboxb.Size = new Size(190, 37);
            tboxb.TabIndex = 5;
            // 
            // lbb
            // 
            lbb.AutoSize = true;
            lbb.Font = new Font("Segoe UI", 9F);
            lbb.Location = new Point(50, 107);
            lbb.Name = "lbb";
            lbb.Size = new Size(27, 25);
            lbb.TabIndex = 4;
            lbb.Text = "b:";
            // 
            // tboxc
            // 
            tboxc.Location = new Point(153, 138);
            tboxc.Name = "tboxc";
            tboxc.Size = new Size(190, 37);
            tboxc.TabIndex = 3;
            // 
            // tboxa
            // 
            tboxa.Location = new Point(153, 53);
            tboxa.Name = "tboxa";
            tboxa.Size = new Size(190, 37);
            tboxa.TabIndex = 2;
            // 
            // lbc
            // 
            lbc.AutoSize = true;
            lbc.Font = new Font("Segoe UI", 9F);
            lbc.Location = new Point(50, 145);
            lbc.Name = "lbc";
            lbc.Size = new Size(24, 25);
            lbc.TabIndex = 1;
            lbc.Text = "c:";
            // 
            // lba
            // 
            lba.AutoSize = true;
            lba.Font = new Font("Segoe UI", 9F);
            lba.Location = new Point(50, 65);
            lba.Name = "lba";
            lba.Size = new Size(25, 25);
            lba.TabIndex = 0;
            lba.Text = "a:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(232, 11);
            label1.Name = "label1";
            label1.Size = new Size(386, 41);
            label1.TabIndex = 23;
            label1.Text = "GIAI PHUONG TRINH BAC 2";
            // 
            // tboxkq
            // 
            tboxkq.Location = new Point(335, 287);
            tboxkq.Name = "tboxkq";
            tboxkq.Size = new Size(190, 31);
            tboxkq.TabIndex = 7;
            // 
            // lbKetQua
            // 
            lbKetQua.AutoSize = true;
            lbKetQua.Font = new Font("Segoe UI", 9F);
            lbKetQua.Location = new Point(232, 294);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(81, 25);
            lbKetQua.TabIndex = 6;
            lbKetQua.Text = "Ket qua: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(tboxkq);
            Controls.Add(lbKetQua);
            Controls.Add(btnGiai);
            Controls.Add(grpThongTin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Buoi02_Bai_3.4";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiai;
        private GroupBox grpThongTin;
        private TextBox tboxb;
        private Label lbb;
        private TextBox tboxc;
        private TextBox tboxa;
        private Label lbc;
        private Label lba;
        private Label label1;
        private TextBox tboxkq;
        private Label lbKetQua;
    }
}
