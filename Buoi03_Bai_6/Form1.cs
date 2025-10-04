using System.Windows.Forms;

namespace Buoi03_Bai_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.listbox.Items.Add(this.txtChuoi.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.listbox.Items.RemoveAt(this.listbox.SelectedIndex);
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtKQ.Text = this.listbox.SelectedItem.ToString();
        }

        private void btnChu_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.txtKQ.ForeColor = cd.Color;
            }
        }

        private void btnNen_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.txtKQ.BackColor = cd.Color;
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            FontDialog fo = new FontDialog();
            if (fo.ShowDialog() == DialogResult.OK)
            {
                this.txtKQ.Font = fo.Font;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
