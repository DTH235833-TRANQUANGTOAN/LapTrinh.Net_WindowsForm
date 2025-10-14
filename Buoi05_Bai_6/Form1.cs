namespace Buoi05_Bai_6
{
    public partial class Form1 : Form
    {
        int[] a = new int[100];
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void Nhap()
        {
            string str = txtMangGoc.Text.Trim(); // xoa khoang trang dau va cuoi
            string[] ptu = str.Split(' '); // tach thanh cac phan tu
            n = ptu.Length; // lay so luong phan tu
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(ptu[i]); // chuyen chuoi thanh so nguyen
        }public void Xuat()
        {
            for (int i=0; i < n; i++)
                txtKQ.AppendText(a[i] + " "); // appendText la tiep tuc in ma khong xoa cai cu
        }
        public int Min()
        {
            int min = a[0];
            for (int i = 1; i < n; i++)
                if (a[i] < min)
                    min = a[i];
            return min;
        }
        public void XuatChan()
        {
            txtKQ.Clear();
            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 0)
                    txtKQ.AppendText(a[i] + " "); // appendText la tiep tuc in ma khong xoa cai cu
        }
        public int ChanCuoi()
        {
            for (int i = n - 1; i >= 0; i--)
                if (a[i] % 2 == 0)
                    return a[i];
            return -1;
        }
        public int TongLe()
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                    tong += a[i];
            }
            return tong;
        }
        public int TongChan()
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                    tong += a[i];
            }
            return tong;
        }
        public int DemLe()
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                    dem++;
            }
            return dem;
        }
        public int DemChan()
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                    dem++;
            }
            return dem;
        }



        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdoXuatMang.Checked == true)
            {
                Nhap();
                Xuat();
            }
            if (rdoTimMin.Checked == true)
            {
                Nhap();
                int min = Min();
                txtKQ.Clear();
                txtKQ.Text = "Giá trị nhỏ nhất trong mảng= " + min.ToString();
            }
            if (rdoLKeChan.Checked == true)
            {
                Nhap();
                XuatChan();
            }
            if (rdoChanCuoi.Checked == true)
            {
                Nhap();
                int chanCuoi = ChanCuoi();
                txtKQ.Clear();
                if (chanCuoi != -1)
                    txtKQ.Text = "Giá trị chẵn cuối cùng trong mảng= " + chanCuoi.ToString();
                else
                    txtKQ.Text = "Không có số chẵn trong mảng.";
            }
            if (rdoTongLe.Checked == true)
            {
                Nhap();
                int tongLe = TongLe();
                txtKQ.Clear();
                txtKQ.Text = "Tổng các số lẻ trong mảng= " + tongLe.ToString();
            }
            if (rdoTongChan.Checked == true)
            {
                Nhap();
                int tongChan = TongChan();
                txtKQ.Clear();
                txtKQ.Text = "Tổng các số chẵn trong mảng= " + tongChan.ToString();
            }
            if (rdoDemLe.Checked == true)
            {
                Nhap();
                int demLe = DemLe();
                txtKQ.Clear();
                txtKQ.Text = "Số lượng các số lẻ trong mảng= " + demLe.ToString();
            }
            if (rdoDemChan.Checked == true)
            {
                Nhap();
                int demChan = DemChan();
                txtKQ.Clear();
                txtKQ.Text = "Số lượng các số chẵn trong mảng= " + demChan.ToString();
            }
        }
    }
}
