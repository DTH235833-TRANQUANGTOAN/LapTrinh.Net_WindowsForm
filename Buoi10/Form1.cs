using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Thư viện SQL
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi10_BaiTap
{
    public partial class Form1 : Form
    {
        // 1. Khai báo chuỗi kết nối (Sửa lại thành admin và QLNV)
        string strConn = @"Data Source=admin;Initial Catalog=QLNV;Integrated Security=True";

        // Các đối tượng toàn cục
        SqlConnection conn = null;
        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter daChucVu;
        SqlDataAdapter daNhanVien;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConn);

                // --- 1. Đổ dữ liệu vào ComboBox Chức Vụ ---
                string sQueryChucVu = @"select * from chucvu";
                daChucVu = new SqlDataAdapter(sQueryChucVu, conn);
                daChucVu.Fill(ds, "tblChucVu");

                cboChucVu.DataSource = ds.Tables["tblChucVu"];
                cboChucVu.DisplayMember = "tencv";
                cboChucVu.ValueMember = "macv";

                // --- 2. Đổ dữ liệu vào DataGridView Nhân Viên ---
                // Lấy thêm tên chức vụ để hiển thị cho đẹp
                string sQueryNhanVien = @"SELECT n.*, c.tencv 
                                          FROM nhanvien n 
                                          INNER JOIN chucvu c ON n.macv = c.macv";

                daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
                daNhanVien.Fill(ds, "tblDSNhanVien");

                // Gán nguồn dữ liệu
                dgDSNhanVien.DataSource = ds.Tables["tblDSNhanVien"];

                // --- 3. Định dạng cột DataGridView ---
                if (dgDSNhanVien.Columns.Count > 0) // Kiểm tra có dữ liệu mới định dạng
                {
                    dgDSNhanVien.Columns["manv"].HeaderText = "Mã số";
                    dgDSNhanVien.Columns["manv"].Width = 80;

                    dgDSNhanVien.Columns["holot"].HeaderText = "Họ và lót";
                    dgDSNhanVien.Columns["holot"].Width = 150;

                    dgDSNhanVien.Columns["tennv"].HeaderText = "Tên";
                    dgDSNhanVien.Columns["tennv"].Width = 100;

                    dgDSNhanVien.Columns["phai"].HeaderText = "Phái";
                    dgDSNhanVien.Columns["phai"].Width = 70;
                    // Xử lý hiển thị BIT thành Nam/Nữ (nếu cần thiết có thể xử lý ở sự kiện CellFormatting)

                    dgDSNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                    dgDSNhanVien.Columns["ngaysinh"].Width = 120;
                    dgDSNhanVien.Columns["ngaysinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dgDSNhanVien.Columns["tencv"].HeaderText = "Chức vụ";
                    dgDSNhanVien.Columns["tencv"].Width = 150;

                    // Ẩn cột mã chức vụ
                    if (dgDSNhanVien.Columns.Contains("macv"))
                        dgDSNhanVien.Columns["macv"].Visible = false;
                }

                // Tùy chỉnh giao diện bảng
                dgDSNhanVien.EnableHeadersVisualStyles = false;
                dgDSNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
                dgDSNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                dgDSNhanVien.DefaultCellStyle.Font = new Font("Times New Roman", 12);
                dgDSNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgDSNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // --- 4. Thiết lập các lệnh INSERT, UPDATE, DELETE thủ công ---

                // Lệnh INSERT
                string sThemNV = @"INSERT INTO nhanvien (manv, holot, tennv, phai, ngaysinh, macv) 
                                   VALUES(@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @MaCV)";
                SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
                cmThemNV.Parameters.Add("@MaNV", SqlDbType.VarChar, 10, "manv");
                cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
                cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 20, "tennv");
                cmThemNV.Parameters.Add("@Phai", SqlDbType.Bit, 1, "phai"); // DB dùng BIT
                cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.Date, 10, "ngaysinh");
                cmThemNV.Parameters.Add("@MaCV", SqlDbType.VarChar, 10, "macv");
                daNhanVien.InsertCommand = cmThemNV;

                // Lệnh UPDATE
                string sSuaNV = @"UPDATE nhanvien 
                                  SET holot=@HoLot, tennv=@TenNV, phai=@Phai, ngaysinh=@NgaySinh, macv=@MaCV
                                  WHERE manv=@MaNV";
                SqlCommand cmSuaNV = new SqlCommand(sSuaNV, conn);
                cmSuaNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
                cmSuaNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 20, "tennv");
                cmSuaNV.Parameters.Add("@Phai", SqlDbType.Bit, 1, "phai");
                cmSuaNV.Parameters.Add("@NgaySinh", SqlDbType.Date, 10, "ngaysinh");
                cmSuaNV.Parameters.Add("@MaCV", SqlDbType.VarChar, 10, "macv");
                cmSuaNV.Parameters.Add("@MaNV", SqlDbType.VarChar, 10, "manv");
                daNhanVien.UpdateCommand = cmSuaNV;

                // Lệnh DELETE
                string sXoaNV = @"DELETE FROM nhanvien WHERE manv=@MaNV";
                SqlCommand cmXoaNV = new SqlCommand(sXoaNV, conn);
                cmXoaNV.Parameters.Add("@MaNV", SqlDbType.VarChar, 10, "manv");
                daNhanVien.DeleteCommand = cmXoaNV;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message + "\n(Hãy kiểm tra tên Server 'admin' và database 'QLNV')");
            }
        }

        private void dgDSNhanVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng có click vào dòng hợp lệ không
            if (dgDSNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];

                // Tránh lỗi khi click vào dòng trống cuối cùng
                if (dr.Cells["manv"].Value == DBNull.Value) return;

                txtMaNV.Text = dr.Cells["manv"].Value.ToString();
                txtHoLot.Text = dr.Cells["holot"].Value.ToString();
                txtTen.Text = dr.Cells["tennv"].Value.ToString();

                // Xử lý hiển thị giới tính từ CSDL (True/False) lên RadioButton
                // Lưu ý: Trong DB, 1 là Nam (True), 0 là Nữ (False) - hoặc tùy quy ước lúc nhập
                bool isNam = false;
                if (dr.Cells["phai"].Value != DBNull.Value)
                {
                    // Tùy vào cách lưu trong DB là chuỗi "Nam"/"Nữ" hay BIT (True/False)
                    // Code cũ của bạn dùng chuỗi, nhưng DB SQL Server tôi đưa là BIT. 
                    // Đoạn này tôi sửa để nhận cả 2 trường hợp cho an toàn.
                    string phaiStr = dr.Cells["phai"].Value.ToString();
                    if (phaiStr == "True" || phaiStr == "1" || phaiStr == "Nam") isNam = true;
                }

                if (isNam) radNam.Checked = true;
                else radNu.Checked = true;

                if (dr.Cells["ngaysinh"].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(dr.Cells["ngaysinh"].Value);

                if (dr.Cells["macv"].Value != DBNull.Value)
                    cboChucVu.SelectedValue = dr.Cells["macv"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtHoLot.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Kiểm tra trùng mã NV (Bỏ qua các dòng đã bị xóa tạm thời)
            foreach (DataRow r in ds.Tables["tblDSNhanVien"].Rows)
            {
                if (r.RowState != DataRowState.Deleted && r["manv"].ToString() == txtMaNV.Text)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
                    return;
                }
            }

            try
            {
                // Tạo dòng mới
                DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
                row["manv"] = txtMaNV.Text;
                row["holot"] = txtHoLot.Text;
                row["tennv"] = txtTen.Text;

                // Lưu xuống DB là kiểu BIT (True/False)
                row["phai"] = radNam.Checked ? 1 : 0;

                row["ngaysinh"] = dtpNgaySinh.Value;
                row["macv"] = cboChucVu.SelectedValue;
                row["tencv"] = cboChucVu.Text; // Để hiển thị ngay trên lưới

                ds.Tables["tblDSNhanVien"].Rows.Add(row);

                // Cập nhật ngay (hoặc đợi nút Lưu tùy bạn)
                // Ở đây cập nhật luôn để đồng bộ
                daNhanVien.Update(ds, "tblDSNhanVien");
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
                ds.Tables["tblDSNhanVien"].RejectChanges(); // Hủy dòng vừa thêm nếu lỗi
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }

            DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
            string maNV = dr.Cells["manv"].Value.ToString();

            // Tìm dòng trong DataSet
            DataRow row = ds.Tables["tblDSNhanVien"].Rows
                .Cast<DataRow>()
                .FirstOrDefault(r => r.RowState != DataRowState.Deleted && r["manv"].ToString() == maNV);

            if (row != null)
            {
                row["holot"] = txtHoLot.Text;
                row["tennv"] = txtTen.Text;
                row["phai"] = radNam.Checked ? 1 : 0;
                row["ngaysinh"] = dtpNgaySinh.Value;
                row["macv"] = cboChucVu.SelectedValue;
                row["tencv"] = cboChucVu.Text; // Cập nhật hiển thị

                MessageBox.Show("Đã cập nhật thông tin (Nhớ nhấn LƯU để ghi xuống CSDL)!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
                string maNV = dr.Cells["manv"].Value.ToString();

                DataRow row = ds.Tables["tblDSNhanVien"].Rows
                    .Cast<DataRow>()
                    .FirstOrDefault(r => r.RowState != DataRowState.Deleted && r["manv"].ToString() == maNV);

                if (row != null)
                {
                    row.Delete(); // Đánh dấu là đã xóa
                    MessageBox.Show("Đã xóa nhân viên khỏi danh sách hiển thị (Nhớ nhấn LƯU)!");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daNhanVien.Update(ds, "tblDSNhanVien");
                MessageBox.Show("Đã lưu toàn bộ thay đổi xuống CSDL!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblDSNhanVien"].RejectChanges();
            MessageBox.Show("Đã hủy các thay đổi chưa lưu!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}