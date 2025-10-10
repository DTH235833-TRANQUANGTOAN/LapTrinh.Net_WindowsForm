namespace Buoi04_Bai_3
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnMax.Enabled = false;
            btnSum.Enabled = false;
        }
        public void TaoMang()
        {
            Random rd = new Random();
            a = new int[n]; // so phan tu cua a =n
            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(-10, 100);
            }
        }
        public string InMang()
        {
            string chuoi = "";
            for (int i = 0; i < n; i++)
            {
                chuoi += a[i] + " ";
            }
            return chuoi;
        }
        private void btnTaomang_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số phần tử mảng");
                return;
            }
            else if (int.Parse(txtNhap.Text) <= 0)
            {
                MessageBox.Show("Số bạn nhập là: " + int.Parse(txtNhap.Text), ". Số phần tử mảng phải lớn hơn 0");
                return;
            }
            else if (int.Parse(txtNhap.Text) > 0)
            {
                n = int.Parse(txtNhap.Text);
                btnMax.Enabled = true;
                btnSum.Enabled = true;
                TaoMang();
                MessageBox.Show("Mảng có 10 phần tử phát sinh ngẫu nhiên: " + InMang());
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Mảng : " + InMang() + "\ncó muốn tính tổng mảng không: ", "tb", MessageBoxButtons.OKCancel); // mac dinh text cuoi dung la phan caption nen phai them 1 cai text thu 3
            if (KQ == DialogResult.OK)
            {
                Form2 f2 = new Form2(a, n); //nhet bien a vo form2
                f2.Show();

            }

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Mảng : " + InMang() + "\ncó muốn tìm MAX không: ", "tb", MessageBoxButtons.OKCancel); // mac dinh text cuoi dung la phan caption nen phai them 1 cai text thu 3
            if (KQ == DialogResult.OK)
            {
                Form3 f3 = new Form3(a, n); //nhet bien a vo form3
                f3.Show();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    