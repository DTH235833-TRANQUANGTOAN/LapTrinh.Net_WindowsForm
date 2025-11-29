using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Buoi11_BaiTap  // <--- Đã sửa thành Buoi11_BaiTap
{
    public partial class Form1 : Form
    {
        // Connection String: admin
        private string connectionString = @"Data Source=admin;Initial Catalog=QLHS;Integrated Security=True";

        bool isAdding = false;
        string selectedMaHS = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDataGridView();
        }

        public void LoadComboBox()
        {
            try
            {
                string sql = "select maqq, tenqq from quequan";
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    try
                    {
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối Database: " + ex.Message);
                    }
                }

                cboQueQuan.DataSource = dt;
                cboQueQuan.DisplayMember = "tenqq";
                cboQueQuan.ValueMember = "maqq";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ComboBox: " + ex.Message);
            }
        }

        public void LoadDataGridView()
        {
            try
            {
                string sql = "SELECT hocsinh.mahs, hocsinh.holot, hocsinh.tenhs, " +
                             "CASE WHEN hocsinh.phai = 1 THEN N'Nam' ELSE N'Nữ' END AS phai, " +
                             "hocsinh.ngaysinh, quequan.tenqq " +
                             "FROM hocsinh " +
                             "LEFT JOIN quequan ON hocsinh.maqq = quequan.maqq";

                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }
                }
                dgvHocSinh.DataSource = dt;

                if (dgvHocSinh.Columns.Count >= 6)
                {
                    dgvHocSinh.Columns[0].HeaderText = "Mã học sinh";
                    dgvHocSinh.Columns[1].HeaderText = "Họ lót";
                    dgvHocSinh.Columns[2].HeaderText = "Tên học sinh";
                    dgvHocSinh.Columns[3].HeaderText = "Phái";
                    dgvHocSinh.Columns[4].HeaderText = "Ngày sinh";
                    dgvHocSinh.Columns[5].HeaderText = "Quê quán";
                    dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi GridView: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            txtMaSo.Enabled = true;
            txtMaSo.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            radNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            if (cboQueQuan.Items.Count > 0) cboQueQuan.SelectedIndex = 0;
            txtMaSo.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isAdding = false;
            MessageBox.Show("Hãy sửa thông tin và nhấn Lưu");
            txtMaSo.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaHS == "")
            {
                MessageBox.Show("Chưa chọn học sinh!");
                return;
            }

            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string sql = "DELETE FROM hocsinh WHERE mahs = @mahs";
                        SqlCommand cmd = new SqlCommand(sql, connection);
                        cmd.Parameters.AddWithValue("@mahs", selectedMaHS);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa!");
                        LoadDataGridView();
                        txtMaSo.Clear(); txtHoLot.Clear(); txtTen.Clear(); selectedMaHS = "";
                        txtMaSo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            txtMaSo.Enabled = true;
            txtMaSo.Clear(); txtHoLot.Clear(); txtTen.Clear();
            if (dgvHocSinh.Rows.Count > 0) dgvHocSinh.ClearSelection();
            selectedMaHS = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHocSinh.Rows[e.RowIndex];
                if (row.Cells[0].Value == DBNull.Value || row.Cells[0].Value == null) return;

                selectedMaHS = row.Cells[0].Value.ToString();
                txtMaSo.Text = row.Cells[0].Value.ToString();
                txtHoLot.Text = row.Cells[1].Value.ToString();
                txtTen.Text = row.Cells[2].Value.ToString();

                string gioitinh = row.Cells[3].Value.ToString();
                if (gioitinh == "Nam") radNam.Checked = true;
                else rdoNu.Checked = true;

                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells[4].Value);
                cboQueQuan.Text = row.Cells[5].Value.ToString();

                isAdding = false;
                txtMaSo.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    bool phai = radNam.Checked;
                    string maqq = cboQueQuan.SelectedValue != null ? cboQueQuan.SelectedValue.ToString() : "";

                    if (isAdding)
                    {
                        sql = "INSERT INTO hocsinh VALUES (@mahs, @holot, @tenhs, @phai, @ngaysinh, @maqq)";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@mahs", txtMaSo.Text);
                    }
                    else
                    {
                        sql = @"UPDATE hocsinh 
                                SET holot=@holot, tenhs=@tenhs, phai=@phai,
                                    ngaysinh=@ngaysinh, maqq=@maqq 
                                WHERE mahs=@mahs";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@mahs", selectedMaHS);
                    }

                    cmd.Parameters.AddWithValue("@holot", txtHoLot.Text);
                    cmd.Parameters.AddWithValue("@tenhs", txtTen.Text);
                    cmd.Parameters.AddWithValue("@phai", phai);
                    cmd.Parameters.AddWithValue("@ngaysinh", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@maqq", maqq);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lưu thành công!");
                    LoadDataGridView();

                    isAdding = false;
                    txtMaSo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
                }
            }
        }
    }
}