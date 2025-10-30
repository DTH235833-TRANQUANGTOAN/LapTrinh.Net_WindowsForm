namespace Buoi07_Bai_5
{
    public partial class Form1 : Form
    {
        int x1, y1, x2, y2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X; // Lưu tọa độ x khi nhấn chuột
            y1 = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X; // Lưu tọa độ x khi thả chuột
            y2 = e.Y;
            pictureBox1.Invalidate(); // Yêu cầu vẽ lại PictureBox
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (cboHinh.SelectedItem == null) return;
            if (cboHinh.SelectedItem.ToString() == "Filled Ellipse")
            {
                Brush brush = new SolidBrush(lbFillColor.BackColor);
                e.Graphics.FillEllipse(brush, Math.Min(x1, x2), Math.Min(y1, y2), // Vẽ hình ellipse tô màu
                    Math.Abs(x2 - x1), Math.Abs(y2 - y1)); // Chiều rộng và chiều cao
            }
            else if (cboHinh.SelectedItem.ToString() == "Square")
            {
                Pen pen = new Pen(lbBorderColor.BackColor, Convert.ToInt32(cboSize.SelectedItem.ToString())); // Tạo bút vẽ với màu và kích thước
                int side = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1)); // Tính độ dài cạnh hình vuông
                e.Graphics.DrawRectangle(pen, Math.Min(x1, x2), Math.Min(y1, y2), side, side); // Vẽ hình vuông
            }
            else if (cboHinh.SelectedItem.ToString() == "Circle")
            {
                Pen pen = new Pen(lbBorderColor.BackColor, Convert.ToInt32(cboSize.SelectedItem.ToString()));// Tạo bút vẽ với màu và kích thước
                int diameter = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1)); // Tính đường kính hình tròn
                e.Graphics.DrawEllipse(pen, Math.Min(x1, x2), Math.Min(y1, y2), diameter, diameter); // Vẽ hình tròn
            }
        }

        private void lbBorderColor_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            if (cl.ShowDialog() == DialogResult.OK)
            {
                lbBorderColor.BackColor = cl.Color;
            }
        }

        private void lbFillColor_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            if (cl.ShowDialog() == DialogResult.OK)
            {
                lbFillColor.BackColor = cl.Color;
            }
        }
    }
}
