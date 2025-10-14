namespace Buoi05_Bai_5
{
    public partial class Form1 : Form
    {
        int[] a = new int[10];
        int n = 10;
        public Form1()
        {
            InitializeComponent();
        }
        public void Xuat()
        {
            txtKQ.Clear();
            for (int i = 0; i < n; i++)
            {
                txtKQ.AppendText(a[i] + " "); // appendText la tiep tuc in ma khong xoa cai cu
            }
        }

        private void btnMangNgauNhien_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                Random rd = new Random();
                a[i] = rd.Next(1, 100);
            }
            for (int i = 0; i < n; i++)
            {
                txtMangGoc.AppendText(a[i] + " "); // appendText la tiep tuc in ma khong xoa cai cu
            }
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            txtKQ.Clear();
            txtKQ.Text = "Tổng mảng= "+tong.ToString();

        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                    dem++;
            }
            txtKQ.Clear();
            txtKQ.Text = "Số lẻ= " + dem.ToString();
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                    tong += a[i];
            }
            txtKQ.Clear();
            txtKQ.Text = "Tổng số lẻ= " + tong.ToString();
        }

        private void btnTimMin_Click(object sender, EventArgs e)
        {
            int min = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            txtKQ.Clear();
            txtKQ.Text = "Số nhỏ nhất= " + min.ToString();
        }

        private void btnCong2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] += 2;
            }
            txtKQ.Clear();
            txtKQ.Text="Đã cộng 2 cho tất cả phần tử, xuất ở mảng gốc.";
            txtMangGoc.Clear();
            for (int i = 0; i < n; i++)
                txtMangGoc.AppendText(a[i] + " ");
        }

        private void btnsapXepTang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Xuat();
        }

        private void btnSapXepGiam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Xuat();
        }
    }
}
