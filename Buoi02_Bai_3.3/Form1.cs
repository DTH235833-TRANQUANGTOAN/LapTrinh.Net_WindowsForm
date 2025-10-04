namespace Buoi02_Bai_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            double ngay = double.Parse(tboxNgay.Text);
            double thang = double.Parse(tboxThang.Text);
            double nam = double.Parse(tboxNam.Text);
            if (thang ==4 || thang == 6 || thang == 9 || thang == 11)
            {
                if (ngay <= 30)
                {
                    MessageBox.Show("Ngay hop le");
                }
                else
                {
                    MessageBox.Show("Ngay khong hop le");
                }
            }
            else if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                if (ngay <= 31)
                {
                    MessageBox.Show("Ngay hop le");
                }
                else
                {
                    MessageBox.Show("Ngay khong hop le");
                }
            }
            else if (thang ==2)
            {
                if (ngay == 29 || ngay==28)
                {
                    MessageBox.Show("Ngay hop le");
                }
                else
                {
                    MessageBox.Show("Ngay khong hop le");
                }
            }
        }
    }
}
