namespace Buoi03_Bai_8
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
            cbTen = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cbTen
            // 
            cbTen.FormattingEnabled = true;
            cbTen.Items.AddRange(new object[] { "Nguyen Van A", "Tran Van C", "Ly Thi D" });
            cbTen.Location = new Point(205, 61);
            cbTen.Margin = new Padding(4, 3, 4, 3);
            cbTen.Name = "cbTen";
            cbTen.Size = new Size(281, 35);
            cbTen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 27);
            label1.TabIndex = 1;
            label1.Text = "Họ tên:";
            // 
            // button1
            // 
            button1.Location = new Point(205, 129);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(281, 75);
            button1.TabIndex = 2;
            button1.Text = "Hien loi chao";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(643, 298);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cbTen);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Bai8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTen;
        private Label label1;
        private Button button1;
    }
}
