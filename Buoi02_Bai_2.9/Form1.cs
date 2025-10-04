namespace Buoi02_Bai_2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tboxa.Text);
            double b = double.Parse(tboxb.Text);
            double ChuVi = (a + b) * 2;
            tboxKetQua.Text = ChuVi.ToString();
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tboxa.Text);
            double b = double.Parse(tboxb.Text);
            double DienTich = a * b;
            tboxKetQua.Text = DienTich.ToString();
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tboxa.Text);
            double b = double.Parse(tboxb.Text);
            double DuongCheo = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2)); // Math.Sqrt(Math.Pow(a,2) là phép tính a mũ 2, Math.Sqrt là căn bậc 2
            tboxKetQua.Text = DuongCheo.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // thoat
        }
    }
}
