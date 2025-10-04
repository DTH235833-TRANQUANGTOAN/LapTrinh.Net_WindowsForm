namespace Buoi02_Bai_4._1
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
            for (int i = 0; i <= n; i++)
            {
                s += i;
            }
            MessageBox.Show(s.ToString());
        }
    }
}
