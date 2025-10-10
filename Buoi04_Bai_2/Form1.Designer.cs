namespace Buoi04_Bai_2
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
            txtNhap = new TextBox();
            btnTaomang = new Button();
            btnIn = new Button();
            btnThoat = new Button();
            rlbKQ = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 33);
            label1.Name = "label1";
            label1.Size = new Size(240, 27);
            label1.TabIndex = 18;
            label1.Text = "Nhập số phần tử mảng: ";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(352, 33);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(150, 35);
            txtNhap.TabIndex = 19;
            // 
            // btnTaomang
            // 
            btnTaomang.Location = new Point(512, 33);
            btnTaomang.Name = "btnTaomang";
            btnTaomang.Size = new Size(195, 35);
            btnTaomang.TabIndex = 20;
            btnTaomang.Text = "Tạo mảng random";
            btnTaomang.UseVisualStyleBackColor = true;
            btnTaomang.Click += btnTaomang_Click;
            // 
            // btnIn
            // 
            btnIn.Location = new Point(97, 192);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(161, 46);
            btnIn.TabIndex = 21;
            btnIn.Text = "In mảng";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(546, 192);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(161, 46);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // rlbKQ
            // 
            rlbKQ.BackColor = Color.FromArgb(255, 224, 192);
            rlbKQ.ForeColor = Color.Blue;
            rlbKQ.Location = new Point(97, 74);
            rlbKQ.Name = "rlbKQ";
            rlbKQ.Size = new Size(610, 112);
            rlbKQ.TabIndex = 23;
            rlbKQ.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(804, 288);
            Controls.Add(rlbKQ);
            Controls.Add(btnThoat);
            Controls.Add(btnIn);
            Controls.Add(btnTaomang);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Blue;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNhap;
        private Button btnTaomang;
        private Button btnIn;
        private Button btnThoat;
        private RichTextBox rlbKQ;
    }
}
