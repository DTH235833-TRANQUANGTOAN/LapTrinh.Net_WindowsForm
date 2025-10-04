namespace Buoi02_Bai_3._1
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
            lb1 = new Label();
            lbx = new Label();
            lbf = new Label();
            tboxx = new TextBox();
            tboxf = new TextBox();
            btnTinh = new Button();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 15F);
            lb1.Location = new Point(233, 36);
            lb1.Name = "lb1";
            lb1.Size = new Size(313, 41);
            lb1.TabIndex = 0;
            lb1.Text = "TINH GIA TRI HAM SO";
            // 
            // lbx
            // 
            lbx.AutoSize = true;
            lbx.Location = new Point(275, 120);
            lbx.Name = "lbx";
            lbx.Size = new Size(37, 25);
            lbx.TabIndex = 1;
            lbx.Text = "x= ";
            // 
            // lbf
            // 
            lbf.AutoSize = true;
            lbf.Location = new Point(275, 214);
            lbf.Name = "lbf";
            lbf.Size = new Size(35, 25);
            lbf.TabIndex = 2;
            lbf.Text = "f= ";
            // 
            // tboxx
            // 
            tboxx.Location = new Point(318, 120);
            tboxx.Name = "tboxx";
            tboxx.Size = new Size(150, 31);
            tboxx.TabIndex = 3;
            // 
            // tboxf
            // 
            tboxf.Location = new Point(316, 208);
            tboxf.Name = "tboxf";
            tboxf.Size = new Size(150, 31);
            tboxf.TabIndex = 4;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(275, 273);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(212, 64);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTinh);
            Controls.Add(tboxf);
            Controls.Add(tboxx);
            Controls.Add(lbf);
            Controls.Add(lbx);
            Controls.Add(lb1);
            Name = "Form1";
            Text = "Buoi02_Bai_3.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private Label lbx;
        private Label lbf;
        private TextBox tboxx;
        private TextBox tboxf;
        private Button btnTinh;
    }
}
