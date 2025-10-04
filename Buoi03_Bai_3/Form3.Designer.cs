namespace Buoi03_Bai_3
{
    partial class Form3
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
            btnReset = new Button();
            btnOk = new Button();
            label1 = new Label();
            cboWeb = new ComboBox();
            txtKQ = new TextBox();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new Point(355, 56);
            btnReset.Margin = new Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(114, 37);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(224, 56);
            btnOk.Margin = new Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(114, 37);
            btnOk.TabIndex = 12;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 10;
            label1.Text = "Liên kết website";
            // 
            // cboWeb
            // 
            cboWeb.FormattingEnabled = true;
            cboWeb.Location = new Point(18, 56);
            cboWeb.Name = "cboWeb";
            cboWeb.Size = new Size(186, 35);
            cboWeb.TabIndex = 14;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(18, 97);
            txtKQ.Margin = new Padding(4, 3, 4, 3);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(451, 148);
            txtKQ.TabIndex = 15;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(501, 272);
            Controls.Add(txtKQ);
            Controls.Add(cboWeb);
            Controls.Add(btnReset);
            Controls.Add(btnOk);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form3";
            Text = "FormWebLinks";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private Button btnOk;
        private Label label1;
        private ComboBox cboWeb;
        private TextBox txtKQ;
    }
}