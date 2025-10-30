using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi08
{
    public partial class Form3 : Form
    {
        public double a = 0;
        public double b = 0;
        public double TinhChuVi()
        {
            return 2 * (a + b);
        }
        public double TinhDienTich()
        {
            return a * b;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtChuVi.Text = TinhChuVi().ToString();
            txtDienTich.Text = TinhDienTich().ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Close();
        }
    }
}
