namespace Buoi03_Bai_2
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
            txtPass = new TextBox();
            txtUser = new TextBox();
            lbpass = new Label();
            lbuser = new Label();
            btnThoat = new Button();
            btnDangnhap = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Location = new Point(478, 227);
            txtPass.Margin = new Padding(5, 3, 5, 3);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(247, 35);
            txtPass.TabIndex = 11;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(478, 177);
            txtUser.Margin = new Padding(5, 3, 5, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(247, 35);
            txtUser.TabIndex = 10;
            // 
            // lbpass
            // 
            lbpass.AutoSize = true;
            lbpass.Location = new Point(259, 233);
            lbpass.Margin = new Padding(5, 0, 5, 0);
            lbpass.Name = "lbpass";
            lbpass.Size = new Size(104, 27);
            lbpass.TabIndex = 9;
            lbpass.Text = "Mật khẩu";
            // 
            // lbuser
            // 
            lbuser.AutoSize = true;
            lbuser.Location = new Point(259, 177);
            lbuser.Margin = new Padding(5, 0, 5, 0);
            lbuser.Name = "lbuser";
            lbuser.Size = new Size(154, 27);
            lbuser.TabIndex = 8;
            lbuser.Text = "Tên đăng nhập";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(500, 300);
            btnThoat.Margin = new Padding(5, 3, 5, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(190, 40);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(247, 300);
            btnDangnhap.Margin = new Padding(5, 3, 5, 3);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(190, 40);
            btnDangnhap.TabIndex = 12;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(247, 124);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(493, 158);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng nhập";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1040, 486);
            Controls.Add(btnThoat);
            Controls.Add(btnDangnhap);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lbpass);
            Controls.Add(lbuser);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Đăng nhập hệ thống";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private TextBox txtUser;
        private Label lbpass;
        private Label lbuser;
        private Button btnThoat;
        private Button btnDangnhap;
        private GroupBox groupBox1;
    }
}