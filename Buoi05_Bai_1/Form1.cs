namespace Buoi05_Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean KiemTraSoNguyenTo(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public String TimSoNTNhoHonN(int n)
        {
            String kq = "";
            for (int i = 2; i < n; i++)
            {
                if (KiemTraSoNguyenTo(i))
                    kq += i + " ";
            }
            return kq;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            if (KiemTraSoNguyenTo(n))
                txtKQKiemTra.Text = n + " là số nguyên tố";
            else
                txtKQKiemTra.Text = n + " không phải là số nguyên tố";
            txtNhoHon.Text = "Các số nguyên tố nhỏ hơn " + n + " là: " + TimSoNTNhoHonN(n);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
