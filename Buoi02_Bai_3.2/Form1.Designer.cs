namespace Buoi02_Bai_3._2
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
            btnThongBao = new Button();
            txtThang = new TextBox();
            lbThang = new Label();
            lb1 = new Label();
            SuspendLayout();
            // 
            // btnThongBao
            // 
            btnThongBao.Location = new Point(273, 165);
            btnThongBao.Name = "btnThongBao";
            btnThongBao.Size = new Size(212, 64);
            btnThongBao.TabIndex = 8;
            btnThongBao.Text = "Tính";
            btnThongBao.UseVisualStyleBackColor = true;
            btnThongBao.Click += btnThongBao_Click;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(314, 100);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(150, 31);
            txtThang.TabIndex = 7;
            // 
            // lbThang
            // 
            lbThang.AutoSize = true;
            lbThang.Location = new Point(273, 106);
            lbThang.Name = "lbThang";
            lbThang.Size = new Size(35, 25);
            lbThang.TabIndex = 6;
            lbThang.Text = "f= ";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 15F);
            lb1.Location = new Point(255, 24);
            lb1.Name = "lb1";
            lb1.Size = new Size(268, 41);
            lb1.TabIndex = 9;
            lb1.Text = "MUA TRONG NAM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb1);
            Controls.Add(btnThongBao);
            Controls.Add(txtThang);
            Controls.Add(lbThang);
            Name = "Form1";
            Text = "Buoi02_Bai_3.2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThongBao;
        private TextBox txtThang;
        private Label lbThang;
        private Label lb1;
    }
}
