using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_Bai_3
{
    public partial class Form2 : Form
    {
        public int[] b;
        public int n;
        public Form2(int[] a, int n)
        {
            InitializeComponent();
            b = a;
            this.n = n;
        }
        public int TinhTong()
        {
            int Tong = 0;
            for (int i = 0; i < n; i++)
            {
                Tong += b[i];
            }
            return Tong;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text="Tổng các phần tử mảng: "+ TinhTong();
        }
    }
}
