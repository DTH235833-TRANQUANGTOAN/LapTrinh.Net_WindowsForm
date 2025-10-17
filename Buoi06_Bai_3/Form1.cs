namespace Buoi06_Bai_3
{// listview viewmode details gridlines fullrowselect
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(); // tao 1 dong moi o ngoai
            item.SubItems[0].Text = txtMaSV.Text;//cho nay phai gan vao SubItems[0] vi no la cot dau tien
            item.SubItems.Add(txtHoTen.Text);// cho no chay tiep theo
            item.SubItems.Add(txtDiaChi.Text);
            item.SubItems.Add(dateNgaySinh.Value.ToShortDateString());
            item.SubItems.Add(cbLop.Text);
            lsKQ.Items.Add(item); //gan thang item vo cai lskq
            txtDiaChi.Clear();
            txtHoTen.Clear();
            txtMaSV.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsKQ.SelectedIndices.Count > 0) // kiem tra xem co dong nao duoc chon khong
                lsKQ.Items.RemoveAt(lsKQ.SelectedIndices[0]); // xoa dong duoc chon tu phan tu subitem 0
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
