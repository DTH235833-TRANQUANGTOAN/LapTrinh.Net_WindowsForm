namespace Buoi07_Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            string DuongDan = @"D:\ky 1 nam 3\net\LapTrinh.Net_WindowsForm\Buoi07_Bai_2_demo";
            LoadFolder(DuongDan, treeView1.Nodes); //  bắt đầu từ thư mục gốc, cái nodes đó chính là điểm bắt đầu của treeview1
            treeView1.AfterSelect += treeView1_AfterSelect; // Đăng ký sự kiện AfterSelect
        }

        void LoadFolder(string DuongDan, TreeNodeCollection nodes)
        {
            foreach (string folder in Directory.GetDirectories(DuongDan))
            {
                TreeNode node = nodes.Add(Path.GetFileName(folder));
                LoadFile(folder, node); //  hàm duyệt các file trong thư mục
                LoadFolder(folder, node.Nodes); //  duyệt đệ quy thư mục con , neu khong co thu muc nao khac thi no tu thoat
                node.Tag = folder; //  gán đường dẫn đầy đủ vào thuộc tính Tag của node
            }

        }

        void LoadFile(string DuongDan, TreeNode node)
        {
            foreach (string file in Directory.GetFiles(DuongDan))
            {
                node.Nodes.Add(Path.GetFileName(file)); //  thêm file vào cây
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string folderPath = e.Node.Tag?.ToString();// Lấy đường dẫn đầy đủ đến thư mục được chọn //  dau ? la de khi ko co tag no se khong bi loi
            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
                return;
            LoadImagesToFlowLayout(folderPath);// Hiển thị hình trong thư mục
        }
        void LoadImagesToFlowLayout(string folderPath)
        {
            flowLayoutPanel1.Controls.Clear(); // Xóa hình cũ

            string[] files = Directory.GetFiles(folderPath, "*.*")
                                      .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                                               || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                                               || f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
                                               || f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)
                                               || f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                                      .ToArray();

            foreach (string file in files)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(file);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Width = 150;   
                pic.Height = 150;
                pic.Margin = new Padding(5);
                flowLayoutPanel1.Controls.Add(pic);
                pic.Tag = file;//Gắn đường dẫn ảnh vào Tag

                pic.Click += (s, e) =>                // Gắn sự kiện pic.Click, khi click vào pic thì sẽ thực hiện đoạn mã bên dưới
                { // s là sender (doi tuong xuat hien su kien ), e là eventargs (thong tin ve vi tri click, loai click...)
                    PictureBox p = s as PictureBox;
                    if (p != null && p.Tag != null)
                    {
                        // Hiển thị hình đã chọn lên PictureBox chính
                        pictureBox1.Image = Image.FromFile(p.Tag.ToString());
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                };

                flowLayoutPanel1.Controls.Add(pic);
            }
        }
    }

}
