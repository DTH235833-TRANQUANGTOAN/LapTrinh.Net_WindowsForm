namespace Buoi07_Bai_4
{
    public partial class Form1 : Form
    {
        Label[] a = new Label[30];
        int tam = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 30; i++)
            {
                a[i] = new Label();
                a[i].Size = new Size(100, 90); // kich thuoc
                a[i].Text = (i + 1).ToString();
                a[i].ForeColor = Color.Red;
                a[i].BackColor = Color.White;
                a[i].Font = new Font("Segoe UI", 12);
                a[i].Visible = true;
                this.Controls.Add(a[i]);
                a[i].Click += Label_Click; // cai nay là gán hàm xử lý sự kiện click cho mỗi ptu
            }
            for (int temp = 0; temp <= 2; temp++)
            {
                for (int i = 0; i < 10; i++)
                {
                    a[temp * 10 + i].Location = new Point(i * 110, temp * 100);
                }
            }
            a[1].BackColor = Color.Yellow;
            a[3].BackColor = Color.Yellow;
            a[5].BackColor = Color.Yellow;
            a[10].BackColor = Color.Yellow;
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl.BackColor == Color.White)
            {
                lbl.BackColor = Color.Blue;   // chọn
                tam++;
            }
            else if (lbl.BackColor == Color.Blue)
            {
                lbl.BackColor = Color.White;    // bỏ chọn
                tam--;
            }
            else if (lbl.BackColor == Color.Yellow)
                MessageBox.Show("Đã bị bán, không thể chọn!");
        }
        public void TinhTien(int so)
        {
            int tien = so * 100000;
            label2.Text = tien.ToString();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            TinhTien(tam);
            foreach (Label lbl in a)
            {
                if (lbl.BackColor == Color.Blue)
                {
                    lbl.BackColor = Color.Yellow; // đã bán
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Label lbl in a)
            {
                if (lbl.BackColor == Color.Blue)
                {
                    lbl.BackColor = Color.White; // bỏ chọn
                }
            }
            tam = 0;
            label2.Text = "      ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
