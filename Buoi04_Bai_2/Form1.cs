namespace Buoi04_Bai_2
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;

        public Form1()
        {
            InitializeComponent();

        }
        public void TaoMang()
        {
            Random rd = new Random();
            a = new int[n];
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
                MessageBox.Show("hãy nhập số phần tử mảng");
                return;
            }
            else if (int.Parse(txtNhap.Text) <= 0)
            {
                MessageBox.Show("số phần tử mảng phải lớn hơn 0");
                return;
            }
            else if (int.Parse(txtNhap.Text) > 0)
            {
                n = int.Parse(txtNhap.Text);
                TaoMang();
            }
            btnIn.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            rlbKQ.Update();
            rlbKQ.Text = "các phần tử của mảng: " + InMang();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnIn.Enabled = false;

        }
    }
}
