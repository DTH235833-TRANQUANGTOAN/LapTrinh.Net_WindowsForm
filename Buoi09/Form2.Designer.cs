namespace Buoi09
{
    partial class Form2
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
            label1 = new Label();
            btnDong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(496, 38);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // btnDong
            // 
            btnDong.Location = new Point(189, 112);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(144, 48);
            btnDong.TabIndex = 1;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 190);
            Controls.Add(btnDong);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Kiểm tra số hoàn hảo";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnDong;
    }
}