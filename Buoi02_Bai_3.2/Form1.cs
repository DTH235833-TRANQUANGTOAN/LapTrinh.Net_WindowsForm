namespace Buoi02_Bai_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            double t = double.Parse(txtThang.Text);
            if (t == 1 || t == 2 || t == 3)
            {
                MessageBox.Show("Mua Xuan");
            }
            else if (t == 4 || t == 5 || t == 6)
            {
                MessageBox.Show("Mua He");
            }
            else if (t == 7 || t == 8 || t == 9)
            {
                MessageBox.Show("Mua Thu");
            }
            else if (t == 10 || t == 11 || t == 12)
            {
                MessageBox.Show("Mua Dong");
            }
       
        }
    }
}
