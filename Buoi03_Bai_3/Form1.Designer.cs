namespace Buoi03_Bai_3
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
            lstWeb = new ListBox();
            btnOk = new Button();
            btnReset = new Button();
            txtKQ = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 0;
            label1.Text = "Liên kết website";
            // 
            // lstWeb
            // 
            lstWeb.FormattingEnabled = true;
            lstWeb.ItemHeight = 27;
            lstWeb.Items.AddRange(new object[] { "Tuổi trẻ", "Thanh niên", "VNExpress", "Dân trí", "Công an" });
            lstWeb.Location = new Point(12, 64);
            lstWeb.Name = "lstWeb";
            lstWeb.Size = new Size(180, 85);
            lstWeb.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 155);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(88, 34);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(106, 155);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(88, 34);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(218, 64);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(150, 123);
            txtKQ.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(385, 206);
            Controls.Add(txtKQ);
            Controls.Add(btnReset);
            Controls.Add(btnOk);
            Controls.Add(lstWeb);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "FormWebLinks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstWeb;
        private Button btnOk;
        private Button btnReset;
        private TextBox txtKQ;
    }
}
