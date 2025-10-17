namespace Buoi06_Bai_1
{
    public partial class Form1 : Form
    {
        string chuoi;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog(); // tao 1 cai font dialog
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                txtNhap.Font = fnt.Font; // gan font vua chon vao txtNhap
            }
        }

        private void btnMau_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog(); // tao 1 cai color dialog
            if (cl.ShowDialog() == DialogResult.OK)
            {
                txtNhap.ForeColor = cl.Color; // gan mau vua chon vao txtNhap
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FileDialog f = new OpenFileDialog(); // tao 1 cai open file dialog (QUAN TRONG)
            if (f.ShowDialog() == DialogResult.OK)
            {
                chuoi = File.ReadAllText(f.FileName); // doc toan bo noi dung file vao chuoi
                txtNhap.Text = chuoi; // gan chuoi vao txtNhap
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileDialog f = new SaveFileDialog(); // tao 1 cai save file dialog (QUAN TRONG)
            if (f.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(f.FileName, txtNhap.Text); // luu noi dung txtNhap vao file
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
 }
