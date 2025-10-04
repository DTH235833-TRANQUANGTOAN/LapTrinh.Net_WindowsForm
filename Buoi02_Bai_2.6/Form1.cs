namespace Buoi02_Bai_2._6
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
            MessageBox.Show(tong.ToString());

        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tboxa.Text);
            double b = double.Parse(tboxb.Text);
            double tich = a - b;
            MessageBox.Show(tich.ToString());

        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tboxa.Text);
            double b = double.Parse(tboxb.Text);
            double thuong = a * b;
            MessageBox.Show(thuong.ToString());
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tboxa.Text);
            double b = double.Parse(tboxb.Text);
            double tong = a / b;
            MessageBox.Show(tong.ToString());

        }
    }
}
