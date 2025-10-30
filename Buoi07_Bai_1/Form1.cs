namespace Buoi07_Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeKQ.Nodes.Add("A");
            treeKQ.Nodes.Add("B");
            treeKQ.Nodes.Add("C");
            treeKQ.Nodes.Add("D");
            treeKQ.Nodes.Add("E");
            treeKQ.Nodes.Add("F");
            treeKQ.Nodes.Add("G");
            treeKQ.Nodes.Add("H");
            treeKQ.Nodes.Add("I");
            treeKQ.Nodes.Add("K");
            treeKQ.Nodes.Add("L");
            treeKQ.Nodes.Add("M");
            treeKQ.Nodes.Add("N");
            treeKQ.Nodes.Add("O");
            treeKQ.Nodes.Add("P");
            treeKQ.Nodes.Add("Q");
            treeKQ.Nodes.Add("R");
            treeKQ.Nodes.Add("S");
            treeKQ.Nodes.Add("T");
            treeKQ.Nodes.Add("U");
            treeKQ.Nodes.Add("V");
            treeKQ.Nodes.Add("W");
            treeKQ.Nodes.Add("X");
            treeKQ.Nodes.Add("Y");
            treeKQ.Nodes.Add("Z");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Ho = txtHo.Text.Trim();
            string Ten = txtTen.Text.Trim();
            if (Ho == "" || Ten == "")
            {
                MessageBox.Show("Vui long nhap ho va ten");
                return;
            }
            string ChuTen = Ten.Substring(0, 1).ToUpper(); // neu chu cai dau tien la chu thuong thi chuyen thanh chu hoa
            foreach (TreeNode i in treeKQ.Nodes)
            {
                if (i.Text == ChuTen) // neu chu cai dau tien cua ten trung voi nut trong treeview
                {
                    i.Nodes.Add(Ten + ", " + Ho);
                    i.Expand(); // mo nut de hien thi ket qua
                    txtHo.Clear();
                    txtTen.Clear();
                    txtHo.Focus();
                    return;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
