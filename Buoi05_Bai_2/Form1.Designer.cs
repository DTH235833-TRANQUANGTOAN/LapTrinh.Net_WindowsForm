namespace Buoi05_Bai_2
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
            txtN = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnThoat = new Button();
            btnKiemTra = new Button();
            SuspendLayout();
            // 
            // txtN
            // 
            txtN.Location = new Point(202, 127);
            txtN.Margin = new Padding(4, 3, 4, 3);
            txtN.Name = "txtN";
            txtN.Size = new Size(533, 35);
            txtN.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 27);
            label2.TabIndex = 5;
            label2.Text = "Nhập N:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(225, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(381, 45);
            label1.TabIndex = 7;
            label1.Text = "Kiểm tra số hoàn hảo";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(443, 200);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(199, 64);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(153, 200);
            btnKiemTra.Margin = new Padding(4, 3, 4, 3);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(199, 64);
            btnKiemTra.TabIndex = 9;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(802, 347);
            Controls.Add(btnThoat);
            Controls.Add(btnKiemTra);
            Controls.Add(label1);
            Controls.Add(txtN);
            Controls.Add(label2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "KT SHH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN;
        private Label label2;
        private Label label1;
        private Button btnThoat;
        private Button btnKiemTra;
    }
}
