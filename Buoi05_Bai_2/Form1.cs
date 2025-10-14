namespace Buoi05_Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int KiemTraSoHoanHao(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum;
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            if (KiemTraSoHoanHao(n) == n)
                MessageBox.Show(n + " là số hoàn hảo");
            else
                MessageBox.Show(n + " không phải là số hoàn hảo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
