namespace Buoi02_Bai_2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tboxa.Text);
            double b = double.Parse(tboxb.Text);
            double tong = a + b;
            tboxKetQua.Text = tong.ToString();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tboxa.Text);
            double b = double.Parse(tboxb.Text);
            double tong = a - b;
            tboxKetQua.Text = tong.ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tboxa.Text);
            double b = double.Parse(tboxb.Text);
            double tong = a * b;
            tboxKetQua.Text = tong.ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tboxa.Text);
            double b = double.Parse(tboxb.Text);
            double tong = a / b;
            tboxKetQua.Text = tong.ToString();
        }
    }
}
