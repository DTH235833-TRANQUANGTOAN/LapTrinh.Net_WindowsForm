namespace Buoi05_Bai_6
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
            gr2 = new GroupBox();
            txtKQ = new TextBox();
            gr1 = new GroupBox();
            txtMangGoc = new TextBox();
            rdoXuatMang = new RadioButton();
            rdoLKeChan = new RadioButton();
            rdoTimMin = new RadioButton();
            rdoChanCuoi = new RadioButton();
            rdoDemLe = new RadioButton();
            rdoTongChan = new RadioButton();
            rdoDemChan = new RadioButton();
            rdoTongLe = new RadioButton();
            btnThucHien = new Button();
            gr2.SuspendLayout();
            gr1.SuspendLayout();
            SuspendLayout();
            // 
            // gr2
            // 
            gr2.Controls.Add(txtKQ);
            gr2.Location = new Point(16, 169);
            gr2.Margin = new Padding(4);
            gr2.Name = "gr2";
            gr2.Padding = new Padding(4);
            gr2.Size = new Size(774, 133);
            gr2.TabIndex = 3;
            gr2.TabStop = false;
            gr2.Text = "kết quả";
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(46, 49);
            txtKQ.Margin = new Padding(4);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(696, 39);
            txtKQ.TabIndex = 0;
            // 
            // gr1
            // 
            gr1.Controls.Add(txtMangGoc);
            gr1.Location = new Point(16, 15);
            gr1.Margin = new Padding(4);
            gr1.Name = "gr1";
            gr1.Padding = new Padding(4);
            gr1.Size = new Size(774, 133);
            gr1.TabIndex = 2;
            gr1.TabStop = false;
            gr1.Text = "Mảng gốc";
            // 
            // txtMangGoc
            // 
            txtMangGoc.Location = new Point(46, 49);
            txtMangGoc.Margin = new Padding(4);
            txtMangGoc.Name = "txtMangGoc";
            txtMangGoc.Size = new Size(696, 39);
            txtMangGoc.TabIndex = 0;
            // 
            // rdoXuatMang
            // 
            rdoXuatMang.AutoSize = true;
            rdoXuatMang.Location = new Point(62, 309);
            rdoXuatMang.Name = "rdoXuatMang";
            rdoXuatMang.Size = new Size(155, 36);
            rdoXuatMang.TabIndex = 4;
            rdoXuatMang.TabStop = true;
            rdoXuatMang.Text = "Xuất mảng";
            rdoXuatMang.UseVisualStyleBackColor = true;
            // 
            // rdoLKeChan
            // 
            rdoLKeChan.AutoSize = true;
            rdoLKeChan.Location = new Point(62, 430);
            rdoLKeChan.Name = "rdoLKeChan";
            rdoLKeChan.Size = new Size(276, 36);
            rdoLKeChan.TabIndex = 5;
            rdoLKeChan.TabStop = true;
            rdoLKeChan.Text = "Liệt kê các giá trị chẵn";
            rdoLKeChan.UseVisualStyleBackColor = true;
            // 
            // rdoTimMin
            // 
            rdoTimMin.AutoSize = true;
            rdoTimMin.Location = new Point(62, 369);
            rdoTimMin.Name = "rdoTimMin";
            rdoTimMin.Size = new Size(204, 36);
            rdoTimMin.TabIndex = 6;
            rdoTimMin.TabStop = true;
            rdoTimMin.Text = "giá trị nhỏ nhất";
            rdoTimMin.UseVisualStyleBackColor = true;
            // 
            // rdoChanCuoi
            // 
            rdoChanCuoi.AutoSize = true;
            rdoChanCuoi.Location = new Point(62, 488);
            rdoChanCuoi.Name = "rdoChanCuoi";
            rdoChanCuoi.Size = new Size(233, 36);
            rdoChanCuoi.TabIndex = 7;
            rdoChanCuoi.TabStop = true;
            rdoChanCuoi.Text = "số chẵn cuối cùng";
            rdoChanCuoi.UseVisualStyleBackColor = true;
            // 
            // rdoDemLe
            // 
            rdoDemLe.AutoSize = true;
            rdoDemLe.Location = new Point(480, 488);
            rdoDemLe.Name = "rdoDemLe";
            rdoDemLe.Size = new Size(332, 36);
            rdoDemLe.TabIndex = 11;
            rdoDemLe.TabStop = true;
            rdoDemLe.Text = "Đếm số lượng các giá trị lẻ ";
            rdoDemLe.UseVisualStyleBackColor = true;
            // 
            // rdoTongChan
            // 
            rdoTongChan.AutoSize = true;
            rdoTongChan.Location = new Point(480, 369);
            rdoTongChan.Name = "rdoTongChan";
            rdoTongChan.Size = new Size(256, 36);
            rdoTongChan.TabIndex = 10;
            rdoTongChan.TabStop = true;
            rdoTongChan.Text = "tổng các giá trị chẵn";
            rdoTongChan.UseVisualStyleBackColor = true;
            // 
            // rdoDemChan
            // 
            rdoDemChan.AutoSize = true;
            rdoDemChan.Location = new Point(480, 430);
            rdoDemChan.Name = "rdoDemChan";
            rdoDemChan.Size = new Size(357, 36);
            rdoDemChan.TabIndex = 9;
            rdoDemChan.TabStop = true;
            rdoDemChan.Text = "Đếm số lượng các giá trị chẵn";
            rdoDemChan.UseVisualStyleBackColor = true;
            // 
            // rdoTongLe
            // 
            rdoTongLe.AutoSize = true;
            rdoTongLe.Location = new Point(480, 309);
            rdoTongLe.Name = "rdoTongLe";
            rdoTongLe.Size = new Size(224, 36);
            rdoTongLe.TabIndex = 8;
            rdoTongLe.TabStop = true;
            rdoTongLe.Text = "tổng các giá trị lẻ";
            rdoTongLe.UseVisualStyleBackColor = true;
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(273, 537);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(200, 61);
            btnThucHien.TabIndex = 12;
            btnThucHien.Text = "Thực hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(826, 639);
            Controls.Add(btnThucHien);
            Controls.Add(rdoDemLe);
            Controls.Add(rdoTongChan);
            Controls.Add(rdoDemChan);
            Controls.Add(rdoTongLe);
            Controls.Add(rdoChanCuoi);
            Controls.Add(rdoTimMin);
            Controls.Add(rdoLKeChan);
            Controls.Add(rdoXuatMang);
            Controls.Add(gr2);
            Controls.Add(gr1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            gr2.ResumeLayout(false);
            gr2.PerformLayout();
            gr1.ResumeLayout(false);
            gr1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gr2;
        private TextBox txtKQ;
        private GroupBox gr1;
        private TextBox txtMangGoc;
        private RadioButton rdoXuatMang;
        private RadioButton rdoLKeChan;
        private RadioButton rdoTimMin;
        private RadioButton rdoChanCuoi;
        private RadioButton rdoDemLe;
        private RadioButton rdoTongChan;
        private RadioButton rdoDemChan;
        private RadioButton rdoTongLe;
        private Button btnThucHien;
    }
}
