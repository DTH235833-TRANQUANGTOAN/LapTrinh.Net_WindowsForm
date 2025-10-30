namespace Buoi07_Bai_4
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
            label2 = new Label();
            btnChon = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 365);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 0;
            label1.Text = "Thành Tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 365);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 1;
            label2.Text = "      ";
            // 
            // btnChon
            // 
            btnChon.Location = new Point(55, 418);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(154, 51);
            btnChon.TabIndex = 2;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(411, 418);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(154, 51);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(784, 418);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(154, 51);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1040, 576);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnChon);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnChon;
        private Button btnHuy;
        private Button btnThoat;
    }
}
