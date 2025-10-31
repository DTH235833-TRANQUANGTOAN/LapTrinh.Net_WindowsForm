namespace Buoi09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLamLai.Enabled = false;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            btnLamLai.Enabled = true;
            Form2 f2 = new Form2();
            f2.N = int.Parse(txtN.Text);
            f2.ShowDialog();
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            btnLamLai.Enabled = true;
            Form3 f3 = new Form3();
            f3.N = int.Parse(txtN.Text);
            f3.ShowDialog();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuKiemTra_Click(object sender, EventArgs e)
        {
            btnLamLai.Enabled = true;
            Form2 f2 = new Form2();
            f2.N = int.Parse(txtN.Text);
            f2.ShowDialog();
        }

        private void menuTaoMang_Click(object sender, EventArgs e)
        {
            btnLamLai.Enabled = true;
            Form3 f3 = new Form3();
            f3.N = int.Parse(txtN.Text);
            f3.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
