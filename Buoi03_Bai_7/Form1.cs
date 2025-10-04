namespace Buoi03_Bai_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stripTong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.txta.Text);
            int b = int.Parse(this.txtb.Text);
            int kq = a + b;
            this.txtKQ.Text = kq.ToString();
        }

        private void stripHieu_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.txta.Text);
            int b = int.Parse(this.txtb.Text);
            int kq = a - b;
            this.txtKQ.Text = kq.ToString();
        }

        private void stripTich_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.txta.Text);
            int b = int.Parse(this.txtb.Text);
            float kq = a * b;
            this.txtKQ.Text = kq.ToString();
        }

        private void stripThuong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.txta.Text);
            int b = int.Parse(this.txtb.Text);
            if (b==0)
            {
                MessageBox.Show("Khong the chia cho 0");
                return;
            }
            float kq = a / (float)b;//them float de lay phan sau dau .
            this.txtKQ.Text = kq.ToString();
        }
    }
}
