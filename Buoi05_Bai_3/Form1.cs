namespace Buoi05_Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            grkq.Text = "Kết quả cộng";
            int PhanSo1_TS = int.Parse(txt_ps1_TS.Text);
            int PhanSo1_MS = int.Parse(txt_ps1_MS.Text);
            int PhanSo2_TS = int.Parse(txt_ps2_TS.Text);
            int PhanSo2_MS = int.Parse(txt_ps2_MS.Text);
            if (PhanSo1_MS == 0 || PhanSo2_MS == 0)
            {
                MessageBox.Show("Mẫu số phải khác 0");
                return;
            }
            else if (PhanSo1_MS == PhanSo2_MS)
            {
                int TS = PhanSo1_TS + PhanSo2_TS;//cung mau so
                int MS = PhanSo1_MS;
                txt_kq_TS.Text = TS.ToString();
                txt_kq_MS.Text = MS.ToString();
            }
            else
            {
                int TS = PhanSo1_TS * PhanSo2_MS + PhanSo2_TS * PhanSo1_MS; //ko cung mau so
                int MS = PhanSo1_MS * PhanSo2_MS;
                txt_kq_TS.Text = TS.ToString();
                txt_kq_MS.Text = MS.ToString();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            grkq.Text = "Kết quả trừ";
            int PhanSo1_TS = int.Parse(txt_ps1_TS.Text);
            int PhanSo1_MS = int.Parse(txt_ps1_MS.Text);
            int PhanSo2_TS = int.Parse(txt_ps2_TS.Text);
            int PhanSo2_MS = int.Parse(txt_ps2_MS.Text);
            if (PhanSo1_MS == 0 || PhanSo2_MS == 0)
            {
                MessageBox.Show("Mẫu số phải khác 0");
                return;
            }
            else if (PhanSo1_MS == PhanSo2_MS)
            {
                int TS = PhanSo1_TS - PhanSo2_TS;
                int MS = PhanSo1_MS;
                txt_kq_TS.Text = TS.ToString();
                txt_kq_MS.Text = MS.ToString();
            }
            else
            {
                int TS = PhanSo1_TS * PhanSo2_MS - PhanSo2_TS * PhanSo1_MS;
                int MS = PhanSo1_MS * PhanSo2_MS;
                txt_kq_TS.Text = TS.ToString();
                txt_kq_MS.Text = MS.ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            grkq.Text = "Kết quả nhân";
            int PhanSo1_TS = int.Parse(txt_ps1_TS.Text);
            int PhanSo1_MS = int.Parse(txt_ps1_MS.Text);
            int PhanSo2_TS = int.Parse(txt_ps2_TS.Text);
            int PhanSo2_MS = int.Parse(txt_ps2_MS.Text);
            if (PhanSo1_MS == 0 || PhanSo2_MS == 0)
            {
                MessageBox.Show("Mẫu số phải khác 0");
                return;
            }
            else
            {
                int TS = PhanSo1_TS * PhanSo2_TS;
                int MS = PhanSo1_MS * PhanSo2_MS;
                txt_kq_TS.Text = TS.ToString();
                txt_kq_MS.Text = MS.ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            grkq.Text = "Kết quả chia";
            int PhanSo1_TS = int.Parse(txt_ps1_TS.Text);
            int PhanSo1_MS = int.Parse(txt_ps1_MS.Text);
            int PhanSo2_TS = int.Parse(txt_ps2_TS.Text);
            int PhanSo2_MS = int.Parse(txt_ps2_MS.Text);
            if (txt_ps2_TS.Text == "0")
            {
                MessageBox.Show("Tử số của phân số thứ 2 phải khác 0");
                return;
            }
            else
            {
                int TS = PhanSo1_TS * PhanSo2_MS;
                int MS = PhanSo1_MS * PhanSo2_TS;
                txt_kq_TS.Text = TS.ToString();
                txt_kq_MS.Text = MS.ToString();
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txt_ps1_TS.Clear();
            txt_ps1_MS.Clear();
            txt_ps2_TS.Clear();
            txt_ps2_MS.Clear();
            txt_kq_TS.Clear();
            txt_kq_MS.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
