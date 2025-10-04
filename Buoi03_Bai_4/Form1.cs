namespace Buoi03_Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên");
                this.txtHoTen.Focus();
                return;
            }
            else
            {
                string hoten = this.txtHoTen.Text;
                if (this.rdoChuthuong.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToLower();
                }
                else if (this.rdoChuhoa.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToUpper();
                }
                else
                {
                    this.txtKQ.Text = hoten;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.txtKQ.Clear();
            this.rdoChuhoa.Checked = false;
            this.rdoChuthuong.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
