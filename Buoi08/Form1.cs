namespace Buoi08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            txtBanKinh.Enabled = false;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtCanh.Focus();
            rb1.Checked = true;
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtCanh.Clear();
            txtCanh.Enabled = true;
            txtBanKinh.Enabled = false;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtCanh.Clear();
            txtCanh.Enabled = false;
            txtBanKinh.Enabled = false;
            txtDai.Enabled = true;
            txtRong.Enabled = true;
            txtDai.Focus();
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtCanh.Clear();
            txtCanh.Enabled = false;
            txtBanKinh.Enabled = true;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBanKinh.Focus();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                if (txtCanh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập độ dài cạnh");
                    txtCanh.Focus();
                    return;
                }
                else
                {
                    Form2 f2 = new Form2();
                    f2.a = double.Parse(txtCanh.Text);
                    f2.ShowDialog();
                }
            }
            else if (rb2.Checked)
            {
                if (txtDai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập độ dài");
                    txtDai.Focus();
                    return;
                }
                else if (txtRong.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập độ rộng");
                    txtRong.Focus();
                    return;
                }
                else
                {
                    Form3 f3 = new Form3();
                    f3.a = double.Parse(txtDai.Text);
                    f3.b = double.Parse(txtRong.Text);
                    f3.ShowDialog();
                }
            }
            else if (rb3.Checked)
            {
                if (txtBanKinh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập bán kính");
                    txtBanKinh.Focus();
                    return;
                }
                else
                {
                    Form4 f4 = new Form4();
                    f4.r = double.Parse(txtBanKinh.Text);
                    f4.ShowDialog();
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
