namespace Buoi03_Bai_1
{
    partial class From
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
            lbuser = new Label();
            lbpass = new Label();
            chkNho = new CheckBox();
            btnDangnhap = new Button();
            btnXoa = new Button();
            btnDung = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // lbuser
            // 
            lbuser.AutoSize = true;
            lbuser.Location = new Point(181, 143);
            lbuser.Margin = new Padding(4, 0, 4, 0);
            lbuser.Name = "lbuser";
            lbuser.Size = new Size(154, 27);
            lbuser.TabIndex = 0;
            lbuser.Text = "Tên đăng nhập";
            // 
            // lbpass
            // 
            lbpass.AutoSize = true;
            lbpass.Location = new Point(181, 195);
            lbpass.Margin = new Padding(4, 0, 4, 0);
            lbpass.Name = "lbpass";
            lbpass.Size = new Size(104, 27);
            lbpass.TabIndex = 1;
            lbpass.Text = "Mật khẩu";
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Location = new Point(181, 242);
            chkNho.Margin = new Padding(4, 3, 4, 3);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(116, 31);
            chkNho.TabIndex = 2;
            chkNho.Text = "Ghi nhớ";
            chkNho.UseVisualStyleBackColor = true;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(181, 301);
            btnDangnhap.Margin = new Padding(4, 3, 4, 3);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(146, 37);
            btnDangnhap.TabIndex = 3;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(572, 301);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(146, 37);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDung
            // 
            btnDung.Location = new Point(376, 301);
            btnDung.Margin = new Padding(4, 3, 4, 3);
            btnDung.Name = "btnDung";
            btnDung.Size = new Size(146, 37);
            btnDung.TabIndex = 5;
            btnDung.Text = "Dừng";
            btnDung.UseVisualStyleBackColor = true;
            btnDung.Click += btnDung_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(350, 143);
            txtUser.Margin = new Padding(4, 3, 4, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(341, 35);
            txtUser.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(350, 189);
            txtPass.Margin = new Padding(4, 3, 4, 3);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(341, 35);
            txtPass.TabIndex = 7;
            // 
            // From
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1040, 486);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnDung);
            Controls.Add(btnXoa);
            Controls.Add(btnDangnhap);
            Controls.Add(chkNho);
            Controls.Add(lbpass);
            Controls.Add(lbuser);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "From";
            Text = "From đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbuser;
        private Label lbpass;
        private CheckBox chkNho;
        private Button btnDangnhap;
        private Button btnXoa;
        private Button btnDung;
        private TextBox txtUser;
        private TextBox txtPass;
    }
}
