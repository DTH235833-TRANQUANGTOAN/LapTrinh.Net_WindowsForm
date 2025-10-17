namespace Buoi06_Bai_2
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
                MessageBox.Show("Vui long nhap ho ten");
                txtHoTen.Focus();
                return;
            }
            if (rdoLopA.Checked == false && rdoLopB.Checked == false)
            {
                MessageBox.Show("Vui long chon lop");
                txtHoTen.Focus();
                return;
            }
            if (rdoLopA.Checked == true)
            {
                lbLopA.Items.Add(txtHoTen.Text.Trim());
            }
            if (rdoLopB.Checked == true)
            {
                lbLopB.Items.Add(txtHoTen.Text.Trim());
            }
            txtHoTen.Clear();
            txtHoTen.Focus(); // dat con tro o txtHoTen nhap cho nhanh
        }

        private void btnAquaB_Click(object sender, EventArgs e) // nho chinh lbLopA va lbLopB selection mode
        {
            foreach (var item in lbLopA.SelectedItems) // vong lap foreach lay tung items trong selecteditems
            {
                lbLopB.Items.Add(item); // add no vo B
            }
            for (int i = lbLopA.SelectedItems.Count - 1; i >= 0; i--) //vi xoa lam thay doi cai selected nen phai dung vong lap nay
            {
                lbLopA.Items.Remove(lbLopA.SelectedItems[i]); //xoa item o vi tri i
            }
        }

        private void btnBquaA_Click(object sender, EventArgs e)
        {
            foreach (var item in lbLopB.SelectedItems)
            {
                lbLopA.Items.Add(item);
            }
            for (int i = lbLopB.SelectedItems.Count - 1; i >= 0; i--)
            {
                lbLopB.Items.Remove(lbLopB.SelectedItems[i]);
            }
        }

        private void btnallAQuaB_Click(object sender, EventArgs e)
        {
            foreach (var item in lbLopA.Items)
            {
                lbLopB.Items.Add(item);
            }
            lbLopA.Items.Clear();
        }

        private void btnallBquaA_Click(object sender, EventArgs e)
        {
            foreach (var item in lbLopB.Items)
            {
                lbLopA.Items.Add(item);
            }
            lbLopB.Items.Clear();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (var item in lbLopA.Items)
            {
                dem++;
            }
            foreach (var item in lbLopB.Items)
            {
                dem++;
            }
            MessageBox.Show("tổng số sinh viên 2 lớp là:  " + dem);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
