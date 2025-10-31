namespace Buoi09
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
            label1 = new Label();
            label2 = new Label();
            txtChan = new TextBox();
            btnDong = new Button();
            txtKQ = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 1;
            label1.Text = "Các phần tử của mảng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 83);
            label2.Name = "label2";
            label2.Size = new Size(206, 25);
            label2.TabIndex = 2;
            label2.Text = "Các số chẵn trong mảng";
            // 
            // txtChan
            // 
            txtChan.Location = new Point(12, 134);
            txtChan.Name = "txtChan";
            txtChan.Size = new Size(433, 31);
            txtChan.TabIndex = 3;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(143, 188);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(149, 70);
            btnDong.TabIndex = 4;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(12, 49);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(433, 31);
            txtKQ.TabIndex = 5;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 361);
            Controls.Add(txtKQ);
            Controls.Add(btnDong);
            Controls.Add(txtChan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Tạo mảng";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtChan;
        private Button btnDong;
        private TextBox txtKQ;
    }
}