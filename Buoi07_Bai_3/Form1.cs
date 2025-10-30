namespace Buoi07_Bai_3
{
    public partial class Form1 : Form
    {
        int i, n = 0;
        string[] Anh = new string[100];
        string DuongDan = @"D:\ky 1 nam 3\net\LapTrinh.Net_WindowsForm\Buoi07_Bai_3_demo";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public int DemFile(string DuongDan)
        {
            int dem = 0;
            foreach (string file in Directory.GetFiles(DuongDan))
            {
                dem++;
            }
            return dem;
        }
        public void HienThiAnh(string DuongDan, int i)
        {
            string[] Anh = Directory.GetFiles(DuongDan);
            n = Anh.Length;
            pictureBox1.Image = Image.FromFile(Anh[i]);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            int SoAnh = DemFile(DuongDan);
            if (SoAnh == 0)
            {
                MessageBox.Show("Thư mục không có ảnh!");
                return;
            }
            else
            {
                HienThiAnh(DuongDan, 0);
            }

        }


        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Đây là ảnh đầu tiên!");
            }
            else
            {
                i--;
                HienThiAnh(DuongDan, i);
            }
        }



        private void btnSau_Click(object sender, EventArgs e)
        {
            if (i > n - 1)
            {
                MessageBox.Show("Đây là ảnh cuối cùng!");
            }
            else
            {
                i++;
                HienThiAnh(DuongDan, i);
            }
        }

        private void btmMo_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                MessageBox.Show("Chưa có ảnh để mở!");
            }
            else
            {
                System.Diagnostics.Process.Start("explorer.exe", DuongDan);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
