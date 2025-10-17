namespace Buoi05_Bai_7
{
    public partial class Form1 : Form
    {
        int[] a = new int[10];
        int n = 10;
        Boolean flag = false;
        public Form1()
        {
            InitializeComponent();
        }
        public void Nhap()
        {
            string str = txtNhap.Text.Trim(); // xoa khoang trang dau va cuoi
            string[] ptu = str.Split(' '); // tach thanh cac phan tu
            n = ptu.Length; // lay so luong phan tu
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(ptu[i]); // chuyen chuoi thanh so nguyen
        }
        public void Xuat()
        {
            txtKQ.Clear();
            for (int i = 0; i < n; i++)
                txtKQ.AppendText(a[i] + " "); // appendText la tiep tuc in ma khong xoa cai cu
        }


        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (flag == false) // lan dau thuc hien thi nhap du lieu
            {
                Nhap();
                flag = true;
            }
            Xuat();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtKQ.Clear();
            txtMax.Clear();
            txtMin.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtTongMang.Clear();
            rdoGiam.Checked = false;
            rdoGiam.Checked = false;
            flag = false;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                Nhap();
                flag = true;
            }
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtTongMang.Clear();
            int tong = 0;
            for (int i = 0; i < n; i++)
                tong += a[i];
            txtTongMang.Text = tong.ToString();
            tong = 0;
            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 0)
                    tong += a[i];
            txtTongChan.Text = tong.ToString();
            tong = 0;
            for (int i = 0; i < n; i++)
                if (a[i] % 2 != 0)
                    tong += a[i];
            txtTongLe.Text = tong.ToString();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                Nhap();
                flag = true;
            }
            txtMax.Clear();
            txtMin.Clear();
            int max = a[0];
            int min = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            txtMax.Text = max.ToString();
            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            txtMin.Text = min.ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                Nhap();
                flag = true;
            }
            if (rdoTang.Checked == true)
            {
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        if (a[i] > a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
            }
            else if (rdoGiam.Checked == true)
            {
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        if (a[i] < a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
            }
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                Nhap();
                flag = true;
            }
            int n = int.Parse(txtViTri.Text);
            int x = int.Parse(txtSoThay.Text);
            a[n-1] = x;
        }
    }
}
