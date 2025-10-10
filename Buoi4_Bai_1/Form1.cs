namespace Buoi4_Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string InMang(int[] a)
        {
            string kq = "";
            for (int i = 0; i < SoPT; i++)
            {
                kq += a[i] + " ";
            }
            return kq;
        }
        public int DemSoChan(int[] a, int SoPT)
        {
            int dem = 0;
            for (int i = 0; i < SoPT; i++)
            {
                if (a[i] % 2 == 0)
                    dem++;
            }
            return dem;
        }
        public int DemSoLe(int[] a, int SoPT)
        {
            int dem = 0;
            for (int i = 0; i < SoPT; i++)
            {
                if (a[i] % 2 != 0)
                    dem++;
            }
            return dem;
        }
        public int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b); // giá trị tuyệt đối
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        public double TrungBinh(int[] a, int SoPT)
        {
            double tb = 0;
            for (int i = 0; i < SoPT; i++)
            {
                tb += a[i];
            }
            tb = tb / SoPT;
            return tb;
        }
        public Boolean KiemTraNguyenTo(int a)
        {
            if (a < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
                if (a % i == 0) // tu a den sqrt(a) neu chia het cho i thi khong phai so nguyen to
                    return false;
            return true;
        }
        public int DemSoNguyenTo(int[] a, int SoPT)
        {
            int dem = 0;
            for (int i = 0; i < SoPT; i++)
                if (KiemTraNguyenTo(a[i]) == true)
                    dem++;
            return dem;
        }
        public Boolean KiemTraSoHoanHao(int a)
        {
            int tong = 0;
            for (int i = 1; i <= a / 2; i++)
                if (a % i == 0)
                    tong += i;
            if (tong == a)
                return true; // la so hoan hao
            else
                return false; // khong phai so hoan hao
        }
        public int DemSoHoanHao(int[] a, int SoPT)
        {
            int dem = 0;
            for (int i = 0; i < SoPT; i++)
                if (KiemTraSoHoanHao(a[i]) == true)
                    dem++;
            return dem;
        }
        public int TimMin(int[] a, int SoPT)
        {
            int min = a[0];
            for (int i = 1; i < SoPT; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        public int TimMax(int[] a, int SoPT)
        {
            int max = a[0];
            for (int i = 1; i < SoPT; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        public int TongMang(int[] a, int SoPT)
        {
            int tong = 0;
            for (int i = 0; i < SoPT; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        public void SapXepTang(int[] a, int SoPT)
        {
            Array.Sort(a, 0, SoPT); // Sắp xếp mảng tăng dần
        }
        public void SapXepGiam(int[] a, int SoPT)
        {
            Array.Sort(a, 0, SoPT); // Sắp xếp mảng tăng dần
            Array.Reverse(a, 0, SoPT); // Đảo ngược mảng để được mảng giảm dần
        }






        // LOAD VÀ BUTTON

        int SoPT = 0;
        int[] a = new int[10];
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (SoPT == 10)
            {
                MessageBox.Show("Mảng đã đầy, không thể nhập thêm");
                return;
            }
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập phần tử");
                return;
            }
            a[SoPT] = int.Parse(txtNhap.Text);
            txtNhap.Clear();
            SoPT++;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (SoPT == 0)
            {
                MessageBox.Show("Mảng rỗng, vui lòng nhập phần tử");
                return;
            }
            else
            {
                lbKQ.Items.Clear();
                lbKQ.Items.Add("Mảng hiện tại: " + InMang(a));
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SoPT; i++)
            {
                a[i] = 0;
            }
            SoPT = 0;
            lbKQ.Items.Clear();
            lbKQ.Items.Add("Đã xóa mảng");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            SapXepGiam(a, SoPT);
            lbKQ.Items.Clear();
            lbKQ.Items.Add("Mảng sau khi sắp xếp giảm dần: " + InMang(a));
        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            SapXepTang(a, SoPT);
            lbKQ.Items.Clear();
            lbKQ.Items.Add("Mảng sau khi sắp xếp tăng dần: " + InMang(a));
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            lbKQ.Items.Clear();
            lbKQ.Items.Add("Tổng các phần tử trong mảng: " + TongMang(a, SoPT));
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            lbKQ.Items.Clear();
            lbKQ.Items.Add("Phần tử lớn nhất trong mảng: " + TimMax(a, SoPT));
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            lbKQ.Items.Clear();
            lbKQ.Items.Add("Phần tử nhỏ nhất trong mảng: " + TimMin(a, SoPT));
        }

        private void btnSHH_Click(object sender, EventArgs e)
        {
            lbKQ.Items.Clear();
            lbKQ.Items.Add("Trong mảng có " + DemSoHoanHao(a, SoPT).ToString()+ " số hoàn hảo");
        }

        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            lbKQ.Items.Clear();
            lbKQ.Items.Add("Trong mảng có " + DemSoNguyenTo(a, SoPT).ToString() + " số nguyên tố");
        }

        private void btnTBMang_Click(object sender, EventArgs e)
        {
            lbKQ.Items.Clear();
            lbKQ.Items.Add("Trung bình cộng các phần tử trong mảng: " + TrungBinh(a, SoPT).ToString("0.00")); // co 2 chu so thap phan
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            lbKQ.Items.Clear();
            lbKQ.Items.Add("Trong mảng có " + DemSoLe(a, SoPT).ToString() + " số lẻ");
        }

        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            lbKQ.Items.Clear();
            lbKQ.Items.Add("Trong mảng có " + DemSoChan(a, SoPT).ToString() + " số chẵn");
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            lbKQ.Items.Clear();
            if (SoPT < 2)
            {
                MessageBox.Show("Mảng phải có ít nhất 2 phần tử để tìm UCLN");
                return;
            }
            else
            {
                lbKQ.Items.Clear();
                lbKQ.Items.Add("UCLN của 2 phần tử đầu tiên trong mảng là: " + TimUCLN(a[0], a[1]));
            }
        }
    }

}
