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
    public partial class Form3 : Form
    {
        int[] c;
        int n;
        public Form3(int[] a,int n)
        {
            InitializeComponent();
            c = a;
            this.n = n;
        }
        public int TimMax()
        {
            int max = c[0];
            for (int i = 1; i < n; i++)
            {
                if (c[i] > max)
                    max = c[i];
            }
            return max;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Phần tử lớn nhất: " + TimMax();
        }
    }
}
