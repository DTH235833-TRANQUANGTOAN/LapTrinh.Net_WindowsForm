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
    public partial class Form3 : Form
    {
        public int N;
        public int[] Mang = new int[100];
        public void TaoMang()
        {
            string temp = ""; 
            Mang = new int[N];
            Random rd = new Random();
            for (int i = 0; i < N; i++)
            {
                Mang[i] = rd.Next(N, N + 12);
                temp += Mang[i] + " ";
            }
            txtKQ.Text = temp;
        }
        public void SoChan()
        {
            String temp = "";
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (Mang[i] % 2 == 0)
                {
                    temp += Mang[i] + " ";
                }
            }
            txtChan.Text = temp;

        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TaoMang();
            SoChan();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Close();
        }
    }
}
