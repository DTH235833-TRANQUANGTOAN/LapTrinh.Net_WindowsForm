using System.Diagnostics.Eventing.Reader;

namespace Buoi02_Bai_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x = double.Parse(tboxx.Text);
            double f = double.Parse(tboxf.Text);
            double kq = 0;
            if (x >= 2) 
            { 
               kq = -8 * Math.Pow(x, 3) - 12 * x - 1;
            }
            else if (x>1 && x<2)
            {
               kq = Math.Pow(x,2)-6*x - 19;
            }
            else if (x<=1)
            {
               kq = 7 * x;
            }
            MessageBox.Show("Kết quả là: " + kq.ToString());
        }
    }
}
