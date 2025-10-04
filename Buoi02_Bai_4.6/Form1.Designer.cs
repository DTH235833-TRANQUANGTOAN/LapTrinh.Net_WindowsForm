namespace Buoi02_Bai_4._6
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
            btnTinh = new Button();
            lbs = new Label();
            lbn = new Label();
            tboxs = new TextBox();
            tboxn = new TextBox();
            SuspendLayout();
            // 
            // btnTinh
            // 
            btnTinh.Font = new Font("Segoe UI", 12F);
            btnTinh.Location = new Point(290, 242);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(220, 80);
            btnTinh.TabIndex = 29;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // lbs
            // 
            lbs.AutoSize = true;
            lbs.Location = new Point(290, 188);
            lbs.Name = "lbs";
            lbs.Size = new Size(24, 25);
            lbs.TabIndex = 28;
            lbs.Text = "s:";
            // 
            // lbn
            // 
            lbn.AutoSize = true;
            lbn.Location = new Point(290, 132);
            lbn.Name = "lbn";
            lbn.Size = new Size(26, 25);
            lbn.TabIndex = 27;
            lbn.Text = "n:";
            // 
            // tboxs
            // 
            tboxs.Location = new Point(360, 188);
            tboxs.Name = "tboxs";
            tboxs.Size = new Size(150, 31);
            tboxs.TabIndex = 26;
            // 
            // tboxn
            // 
            tboxn.Location = new Point(360, 129);
            tboxn.Name = "tboxn";
            tboxn.Size = new Size(150, 31);
            tboxn.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTinh);
            Controls.Add(lbs);
            Controls.Add(lbn);
            Controls.Add(tboxs);
            Controls.Add(tboxn);
            Name = "Form1";
            Text = "Buoi02_Bai_4.6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTinh;
        private Label lbs;
        private Label lbn;
        private TextBox tboxs;
        private TextBox tboxn;
    }
}
