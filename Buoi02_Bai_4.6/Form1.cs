namespace Buoi02_Bai_4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double n = double.Parse(tboxn.Text);
            double s = double.Parse(tboxs.Text);
            for (int i = 1; i <= n; i++)
            {
                s += 1.0 / (2 * i - 1);
            }
            MessageBox.Show(s.ToString());
        }
    }
}
