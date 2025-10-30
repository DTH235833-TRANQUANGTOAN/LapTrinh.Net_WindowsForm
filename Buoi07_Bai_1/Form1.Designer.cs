namespace Buoi07_Bai_1
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
            treeKQ = new TreeView();
            gr1 = new GroupBox();
            btnThem = new Button();
            txtHo = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            label1 = new Label();
            btnThoat = new Button();
            gr1.SuspendLayout();
            SuspendLayout();
            // 
            // treeKQ
            // 
            treeKQ.Location = new Point(16, 15);
            treeKQ.Margin = new Padding(4);
            treeKQ.Name = "treeKQ";
            treeKQ.Size = new Size(257, 544);
            treeKQ.TabIndex = 0;
            // 
            // gr1
            // 
            gr1.Controls.Add(btnThem);
            gr1.Controls.Add(txtHo);
            gr1.Controls.Add(label2);
            gr1.Controls.Add(txtTen);
            gr1.Controls.Add(label1);
            gr1.Location = new Point(280, 15);
            gr1.Name = "gr1";
            gr1.Size = new Size(418, 251);
            gr1.TabIndex = 1;
            gr1.TabStop = false;
            gr1.Text = "Nhập";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(108, 182);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(202, 51);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(108, 120);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(284, 39);
            txtHo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 123);
            label2.Name = "label2";
            label2.Size = new Size(45, 32);
            label2.TabIndex = 2;
            label2.Text = "Họ";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(108, 51);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(284, 39);
            txtTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 54);
            label1.Name = "label1";
            label1.Size = new Size(52, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(388, 355);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(202, 51);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(730, 576);
            Controls.Add(btnThoat);
            Controls.Add(gr1);
            Controls.Add(treeKQ);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "TreeView";
            Load += Form1_Load;
            gr1.ResumeLayout(false);
            gr1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeKQ;
        private GroupBox gr1;
        private Button btnThem;
        private TextBox txtHo;
        private Label label2;
        private TextBox txtTen;
        private Label label1;
        private Button btnThoat;
    }
}
