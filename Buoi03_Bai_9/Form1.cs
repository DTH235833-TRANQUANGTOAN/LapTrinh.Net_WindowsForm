namespace Buoi03_Bai_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            string Gioitinh = "";
            string TinhTrang = "";
            string Hoten = txtTen.Text;
            if (rdoNam.Checked == true)
            {
                Gioitinh = "Nam";
            }
            if (rdoNu.Checked == true)
            {
                Gioitinh = "Nu";
            }
            string Ngaysinh = pickNgaySinh.Value.ToString("dd/MM/yyyy");
            string Diachi = txtDiaChi.Text;
            string Dienthoai = txtDienThoai.Text;
            string Email = txtEmail.Text;
            if (cboxHoc.Checked == true)
            {
                TinhTrang = "Dang hoc";
            }
            if (cboxLam.Checked == true)
            {
                TinhTrang = "Dang lam";
            }
            string Thongtin = "Ho ten: " + Hoten + "\nGioi tinh: " + Gioitinh + "\nNgay sinh: " + Ngaysinh + "\nDia chi: " + Diachi + "\nDien thoai: " + Dienthoai + "\nEmail: " + Email + "\nTinh trang: " + TinhTrang;
            MessageBox.Show(Thongtin);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
