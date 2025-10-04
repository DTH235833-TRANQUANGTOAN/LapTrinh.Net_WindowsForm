namespace Buoi02_Bai_4._1
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
            tboxn = new TextBox();
            tboxs = new TextBox();
            lbn = new Label();
            lbs = new Label();
            btnTinh = new Button();
            SuspendLayout();
            // 
            // tboxn
            // 
            tboxn.Location = new Point(337, 148);
            tboxn.Name = "tboxn";
            tboxn.Size = new Size(150, 31);
            tboxn.TabIndex = 0;
            // 
            // tboxs
            // 
            tboxs.Location = new Point(337, 207);
            tboxs.Name = "tboxs";
            tboxs.Size = new Size(150, 31);
            tboxs.TabIndex = 1;
            // 
            // lbn
            // 
            lbn.AutoSize = true;
            lbn.Location = new Point(267, 151);
            lbn.Name = "lbn";
            lbn.Size = new Size(26, 25);
            lbn.TabIndex = 2;
            lbn.Text = "n:";
            // 
            // lbs
            // 
            lbs.AutoSize = true;
            lbs.Location = new Point(267, 207);
            lbs.Name = "lbs";
            lbs.Size = new Size(24, 25);
            lbs.TabIndex = 3;
            lbs.Text = "s:";
            // 
            // btnTinh
            // 
            btnTinh.Font = new Font("Segoe UI", 12F);
            btnTinh.Location = new Point(267, 261);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(220, 80);
            btnTinh.TabIndex = 4;
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
            Controls.Add(lbs);
            Controls.Add(lbn);
            Controls.Add(tboxs);
            Controls.Add(tboxn);
            Name = "Form1";
            Text = "Buoi02_Bai_4.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxn;
        private TextBox tboxs;
        private Label lbn;
        private Label lbs;
        private Button btnTinh;
    }
}
