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
    public partial class Form2 : Form
    {
        public double a = 0;
        public double TinhDienTich()
        {
            return a * a;
        }
        public double TinhChuVi()
        {
            return 4 * a;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtChuVi.Text = TinhChuVi().ToString();
            txtDienTich.Text = TinhDienTich().ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }
    }
}
