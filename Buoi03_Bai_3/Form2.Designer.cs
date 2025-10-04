namespace Buoi03_Bai_3
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
            txtKQ = new TextBox();
            btnReset = new Button();
            btnOk = new Button();
            lstWeb = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(289, 64);
            txtKQ.Margin = new Padding(4, 3, 4, 3);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(194, 133);
            txtKQ.TabIndex = 9;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(143, 162);
            btnReset.Margin = new Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(114, 37);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(21, 162);
            btnOk.Margin = new Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(114, 37);
            btnOk.TabIndex = 7;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lstWeb
            // 
            lstWeb.FormattingEnabled = true;
            lstWeb.ItemHeight = 27;
            lstWeb.Location = new Point(21, 64);
            lstWeb.Margin = new Padding(4, 3, 4, 3);
            lstWeb.Name = "lstWeb";
            lstWeb.Size = new Size(233, 85);
            lstWeb.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 5;
            label1.Text = "Liên kết website";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(514, 224);
            Controls.Add(txtKQ);
            Controls.Add(btnReset);
            Controls.Add(btnOk);
            Controls.Add(lstWeb);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "FormWebLinks";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKQ;
        private Button btnReset;
        private Button btnOk;
        private ListBox lstWeb;
        private Label label1;
    }
}