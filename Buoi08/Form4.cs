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
    public partial class Form4 : Form
    {
        public double r = 0;
        public double TinhChuVi()
        {
            return 2 * Math.PI * r;
        }
        public double TinhDienTich()
        {
            return Math.PI * r * r;
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtChuVi.Text = TinhChuVi().ToString();
            txtDienTich.Text = TinhDienTich().ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Close();
        }
    }
}
