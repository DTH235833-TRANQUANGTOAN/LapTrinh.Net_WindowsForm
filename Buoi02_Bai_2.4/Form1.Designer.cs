namespace Buoi02_Bai_2._4
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
            lbHoTen = new Label();
            tboxTen = new TextBox();
            btnHienThi = new Button();
            SuspendLayout();
            // 
            // lbHoTen
            // 
            lbHoTen.AutoSize = true;
            lbHoTen.Location = new Point(218, 184);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(71, 25);
            lbHoTen.TabIndex = 0;
            lbHoTen.Text = "Ho Ten:";
            // 
            // tboxTen
            // 
            tboxTen.Location = new Point(342, 178);
            tboxTen.Name = "tboxTen";
            tboxTen.Size = new Size(189, 31);
            tboxTen.TabIndex = 1;
            tboxTen.TextChanged += tboxTen_TextChanged;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(218, 232);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(313, 59);
            btnHienThi.TabIndex = 2;
            btnHienThi.Text = "Hien Thi";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHienThi);
            Controls.Add(tboxTen);
            Controls.Add(lbHoTen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHoTen;
        private TextBox tboxTen;
        private Button btnHienThi;
    }
}
