using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi09
{
    public partial class Form2 : Form
    {
        public int N;
        private Boolean KiemTraSoHoanHao(int so)
        {
            int tong = 0;
            for (int i = 1; i <= so / 2; i++)
            {
                if (so % i == 0)
                {
                    tong += i;
                }
            }
            return tong == so;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (KiemTraSoHoanHao(N) == true)
            {
                label1.Text = $"{N} là số hoàn hảo.";
            }
            else
            {
                label1.Text = $"{N} không phải là số hoàn hảo.";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }
    }
}
