namespace Buoi06_Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên");
                return;
            }
            ListViewItem item = new ListViewItem(); // tao 1 dong moi o ngoai
            item.SubItems[0].Text = txtMaSV.Text;//cho nay phai gan vao SubItems[0] vi no la cot dau tien
            item.SubItems.Add(txtHoTen.Text);// cho no chay tiep theo
            item.SubItems.Add(dateNgaySinh.Value.ToShortDateString());
            if (rdoNam.Checked)
                item.SubItems.Add("Nam");
            else if (rdoNu.Checked)
                item.SubItems.Add("Nữ");
            item.SubItems.Add(txtDienThoai.Text);
            item.SubItems.Add(cbQueQuan.SelectedItem.ToString());
            lsKQ.Items.Add(item); //gan thang item vo cai lskq
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsKQ.SelectedItems.Count > 0)
            {
                lsKQ.Items.Remove(lsKQ.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Phải chọn dòng để xóa");
            }
        }

        private void btnSua_Click(object sender, EventArgs e) // code nay giong nhu nhap, nhung thay vi vo dong moi th no nhap vo dong da chon
        {
            ListViewItem item = new ListViewItem(); // tao 1 dong moi o ngoai
            item.SubItems[0].Text = txtMaSV.Text;//cho nay phai gan vao SubItems[0] vi no la cot dau tien
            item.SubItems.Add(txtHoTen.Text);// cho no chay tiep theo
            item.SubItems.Add(dateNgaySinh.Value.ToShortDateString());
            if (rdoNam.Checked)
                item.SubItems.Add("Nam");
            else if (rdoNu.Checked)
                item.SubItems.Add("Nữ");
            item.SubItems.Add(txtDienThoai.Text);
            item.SubItems.Add(cbQueQuan.SelectedItem.ToString());
            if (lsKQ.SelectedItems.Count > 0)
            {
                lsKQ.Items.Remove(lsKQ.SelectedItems[0]); // xoa dong hien tai di
                lsKQ.Items.Add(item); //gan thang item vo cai lskq
            }
            else
            {
                MessageBox.Show("Phải chọn dòng để sửa");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
