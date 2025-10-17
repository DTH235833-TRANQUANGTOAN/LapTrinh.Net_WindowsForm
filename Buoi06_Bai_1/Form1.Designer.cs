namespace Buoi06_Bai_1
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
            btnFont = new Button();
            btnMau = new Button();
            btnOpen = new Button();
            btnSave = new Button();
            btnThoat = new Button();
            txtNhap = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 1;
            label1.Text = "Nhập đoạn văn bản";
            // 
            // btnFont
            // 
            btnFont.Location = new Point(12, 249);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(111, 55);
            btnFont.TabIndex = 2;
            btnFont.Text = "Đổi font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnMau
            // 
            btnMau.Location = new Point(129, 249);
            btnMau.Name = "btnMau";
            btnMau.Size = new Size(111, 55);
            btnMau.TabIndex = 3;
            btnMau.Text = "Chọn màu";
            btnMau.UseVisualStyleBackColor = true;
            btnMau.Click += btnMau_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(253, 249);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(111, 55);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(370, 249);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 55);
            btnSave.TabIndex = 5;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(184, 310);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(136, 61);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(12, 39);
            txtNhap.Multiline = true;
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(469, 204);
            txtNhap.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 413);
            Controls.Add(txtNhap);
            Controls.Add(btnThoat);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(btnMau);
            Controls.Add(btnFont);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CommonDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnFont;
        private Button btnMau;
        private Button btnOpen;
        private Button btnSave;
        private Button btnThoat;
        private TextBox txtNhap;
    }
}
