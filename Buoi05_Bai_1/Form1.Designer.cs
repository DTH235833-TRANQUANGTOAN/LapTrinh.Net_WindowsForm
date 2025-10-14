namespace Buoi05_Bai_1
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
            label3 = new Label();
            label4 = new Label();
            txtN = new TextBox();
            txtKQKiemTra = new TextBox();
            txtNhoHon = new TextBox();
            btnLamLai = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(219, 36);
            label1.Name = "label1";
            label1.Size = new Size(381, 45);
            label1.TabIndex = 0;
            label1.Text = "Kiểm tra và tìm SNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 144);
            label2.Name = "label2";
            label2.Size = new Size(93, 27);
            label2.TabIndex = 1;
            label2.Text = "Nhập N:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 204);
            label3.Name = "label3";
            label3.Size = new Size(150, 27);
            label3.TabIndex = 2;
            label3.Text = "Kiểm tra SNT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 262);
            label4.Name = "label4";
            label4.Size = new Size(213, 27);
            label4.TabIndex = 3;
            label4.Text = "Tìm SNT nhỏ hơn N:";
            // 
            // txtN
            // 
            txtN.Location = new Point(260, 141);
            txtN.Name = "txtN";
            txtN.Size = new Size(411, 35);
            txtN.TabIndex = 4;
            // 
            // txtKQKiemTra
            // 
            txtKQKiemTra.Location = new Point(260, 201);
            txtKQKiemTra.Name = "txtKQKiemTra";
            txtKQKiemTra.Size = new Size(411, 35);
            txtKQKiemTra.TabIndex = 5;
            // 
            // txtNhoHon
            // 
            txtNhoHon.Location = new Point(260, 259);
            txtNhoHon.Name = "txtNhoHon";
            txtNhoHon.Size = new Size(411, 35);
            txtNhoHon.TabIndex = 6;
            // 
            // btnLamLai
            // 
            btnLamLai.Location = new Point(148, 332);
            btnLamLai.Name = "btnLamLai";
            btnLamLai.Size = new Size(153, 59);
            btnLamLai.TabIndex = 7;
            btnLamLai.Text = "Làm lại";
            btnLamLai.UseVisualStyleBackColor = true;
            btnLamLai.Click += btnLamLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(447, 332);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(153, 59);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 441);
            Controls.Add(btnThoat);
            Controls.Add(btnLamLai);
            Controls.Add(txtNhoHon);
            Controls.Add(txtKQKiemTra);
            Controls.Add(txtN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "KT SNT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtN;
        private TextBox txtKQKiemTra;
        private TextBox txtNhoHon;
        private Button btnLamLai;
        private Button btnThoat;
    }
}
