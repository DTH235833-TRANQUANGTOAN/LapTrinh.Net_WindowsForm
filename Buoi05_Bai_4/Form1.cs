namespace Buoi05_Bai_4
{//View-other window-document outline hay xai ctrl+alt+T de tranh bi long cai group

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double DienTichHCN(int dai, int rong)
        {
            return dai * rong;
        }
        public double DienTichTG(int canhA, int canhB, int canhC)
        {
            double p = (canhA + canhB + canhC) / 2;
            return Math.Sqrt(p * (p - canhA) * (p - canhB) * (p - canhC));
        }
        public double DienTichTron(int banKinh)
        {
            return Math.PI * banKinh * banKinh;
        }
        public double DienTichVuong(int canh)
        {
            return canh * canh;
        }
        public double ChuViHCN(int dai, int rong)
        {
            return (dai + rong) * 2;
        }
        public double ChuViTG(int canhA, int canhB, int canhC)
        {
            return canhA + canhB + canhC;
        }
        public double ChuViTron(int banKinh)
        {
            return 2 * Math.PI * banKinh;
        }
        public double ChuViVuong(int canh)
        {
            return canh * 4;
        }
        public void An()
        {
            grChuNhat.Visible = false;
            grVuong.Visible = false;
            grTamGiac.Visible = false;
            grTron.Visible = false;
        }
        private void rdoTron_CheckedChanged(object sender, EventArgs e)
        {
            An();
            grTron.Visible = true;
            grTron.BringToFront();
        }

        private void rdoVuong_CheckedChanged(object sender, EventArgs e)
        {
            An();
            grVuong.Visible = true;
            grVuong.BringToFront();
        }

        private void rdoTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            An();
            grTamGiac.Visible = true;
            grTamGiac.BringToFront();
        }

        private void rdoChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            An();
            grChuNhat.Visible = true;
            grChuNhat.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            An();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdoChuNhat.Checked == true)
            {
                if(txt_ChuNhat_A.Text=="" || txt_ChuNhat_B.Text=="")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                txt_ChuNhat_ChuVi.Text = ChuViHCN(int.Parse(txt_ChuNhat_A.Text), int.Parse(txt_ChuNhat_B.Text)).ToString();
                txt_ChuNhat_DienTich.Text = DienTichHCN(int.Parse(txt_ChuNhat_A.Text), int.Parse(txt_ChuNhat_B.Text)).ToString();
            }
            if (rdoVuong.Checked == true)
            {
                if (txt_Vuong_A.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                txt_Vuong_ChuVi.Text = ChuViVuong(int.Parse(txt_Vuong_A.Text)).ToString();
                txt_Vuong_DienTich.Text = DienTichVuong(int.Parse(txt_Vuong_A.Text)).ToString();
            }
            if (rdoTamGiac.Checked == true)
            {
                if (txt_TamGiac_A.Text == "" || txt_TamGiac_B.Text == "" || txt_TamGiac_C.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                txt_TamGiac_ChuVi.Text = ChuViTG(int.Parse(txt_TamGiac_A.Text), int.Parse(txt_TamGiac_B.Text), int.Parse(txt_TamGiac_C.Text)).ToString();
                txt_TamGiac_DienTich.Text = DienTichTG(int.Parse(txt_TamGiac_A.Text), int.Parse(txt_TamGiac_B.Text), int.Parse(txt_TamGiac_C.Text)).ToString();
            }
            if (rdoTron.Checked == true)
            {
                if (txt_Tron_BanKinh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                txt_Tron_ChuVi.Text = ChuViTron(int.Parse(txt_Tron_BanKinh.Text)).ToString("F2"); // f2 là để làm tròn 2 số
                txt_Tron_DienTich.Text = DienTichTron(int.Parse(txt_Tron_BanKinh.Text)).ToString("F2");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_Tron_BanKinh.Clear();
            txt_Tron_ChuVi.Clear();
            txt_Tron_DienTich.Clear();
            txt_Vuong_A.Clear();
            txt_Vuong_ChuVi.Clear();
            txt_Vuong_DienTich.Clear();
            txt_TamGiac_A.Clear();
            txt_TamGiac_B.Clear();
            txt_TamGiac_C.Clear();
            txt_TamGiac_ChuVi.Clear();
            txt_TamGiac_DienTich.Clear();
            txt_ChuNhat_A.Clear();
            txt_ChuNhat_B.Clear();
            txt_ChuNhat_ChuVi.Clear();
            txt_ChuNhat_DienTich.Clear();
            An();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
