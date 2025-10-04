namespace Buoi02_Bai_2._5
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
            grpThongTin = new GroupBox();
            tboxb = new TextBox();
            lbb = new Label();
            lba = new Label();
            btnTong = new Button();
            tboxa = new TextBox();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(303, 19);
            label1.Name = "label1";
            label1.Size = new Size(174, 41);
            label1.TabIndex = 0;
            label1.Text = "PHEP TOAN";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(tboxb);
            grpThongTin.Controls.Add(tboxa);
            grpThongTin.Controls.Add(lbb);
            grpThongTin.Controls.Add(lba);
            grpThongTin.Font = new Font("Segoe UI", 11F);
            grpThongTin.Location = new Point(235, 90);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(327, 199);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thong Tin";
            // 
            // tboxb
            // 
            tboxb.Location = new Point(70, 125);
            tboxb.Name = "tboxb";
            tboxb.Size = new Size(233, 37);
            tboxb.TabIndex = 3;
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
            // btnTong
            // 
            btnTong.Font = new Font("Segoe UI", 12F);
            btnTong.Location = new Point(267, 313);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(271, 69);
            btnTong.TabIndex = 2;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // tboxa
            // 
            tboxa.Location = new Point(70, 55);
            tboxa.Name = "tboxa";
            tboxa.Size = new Size(233, 37);
            tboxa.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTong);
            Controls.Add(grpThongTin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Buoi02_Bai_2.5";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpThongTin;
        private TextBox tboxb;
        private Label lbb;
        private Label lba;
        private Button btnTong;
        private TextBox tboxa;
    }
}
