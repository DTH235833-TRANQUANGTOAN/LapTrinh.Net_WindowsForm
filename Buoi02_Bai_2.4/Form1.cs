namespace Buoi02_Bai_2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chao " + tboxTen.Text);
        }

        private void tboxTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
