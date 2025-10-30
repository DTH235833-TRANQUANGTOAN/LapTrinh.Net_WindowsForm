namespace Buoi08
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDong = new Button();
            txtChuVi = new TextBox();
            txtDienTich = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDong
            // 
            btnDong.Location = new Point(131, 174);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(150, 51);
            btnDong.TabIndex = 11;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // txtChuVi
            // 
            txtChuVi.Location = new Point(153, 129);
            txtChuVi.Name = "txtChuVi";
            txtChuVi.Size = new Size(226, 39);
            txtChuVi.TabIndex = 10;
            // 
            // txtDienTich
            // 
            txtDienTich.Location = new Point(153, 75);
            txtDienTich.Name = "txtDienTich";
            txtDienTich.Size = new Size(226, 39);
            txtDienTich.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(37, 132);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 8;
            label3.Text = "Chu vi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(37, 75);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 7;
            label2.Text = "Diện tích";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(37, 17);
            label1.Name = "label1";
            label1.Size = new Size(368, 32);
            label1.TabIndex = 6;
            label1.Text = "Diện tích và chu vi hình chữ nhật";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 242);
            Controls.Add(btnDong);
            Controls.Add(txtChuVi);
            Controls.Add(txtDienTich);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDong;
        private TextBox txtChuVi;
        private TextBox txtDienTich;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}