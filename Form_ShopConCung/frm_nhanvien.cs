using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ShopConCung
{
	public partial class frm_nhanvien : Form
	{
		public frm_nhanvien()
		{
			InitializeComponent();
		}
		//khai bao doi tuong
		KetNoiDuLieu ketnoi = new KetNoiDuLieu();
		SqlDataAdapter bodocghi;
		DataTable bangnv = new DataTable();
		int donghh;
		void HienThiDuLieu()
		{
			string sql = "select * from NhanVien";
			bangnv = ketnoi.DocDuLieu(sql);
			bodocghi = ketnoi.docghi;
			dgvnhanvien.DataSource = bangnv;
		}
		private void frm_nhanvien_Load(object sender, EventArgs e)
		{
			cmbgioitinh.SelectedIndex = 0;
			HienThiDuLieu();
			if (PhanquyenQuanli.loaitk == "staff")
			{
				btnxoa.Enabled = false;
			}
			else if (PhanquyenQuanli.loaitk == "admin")
			{

			}
			else
			{
				btnthem.Enabled = false;
				btnsua.Enabled = false;
				btnxoa.Enabled = false;
			}
		}

		private void btnnhaplai_Click(object sender, EventArgs e)
		{
			txtmanv.Clear();
			txttennv.Clear();
			txtchucvu.Clear();
			txtsdtnv.Clear();

			txtmanv.Enabled = true;
		}

		private void btnthem_Click(object sender, EventArgs e)
		{
			if (txtmanv.Text != "")
			{
				DataRow dongmoi = bangnv.NewRow();
				dongmoi["MaNhanVien"] = txtmanv.Text;
				dongmoi["TenNhanVien"] = txttennv.Text;
				dongmoi["GioiTinh"] = cmbgioitinh.Text;
				dongmoi["ChucVu"] = txtchucvu.Text;
				dongmoi["SDT"] = txtsdtnv.Text;
				bangnv.Rows.Add(dongmoi);
				ketnoi.CapNhatDuLieu(bodocghi, bangnv);
				bangnv.Clear();
				HienThiDuLieu();
			}
		}

		private void btnsua_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtmanv.Text))
			{
				string idNhanVien = txtmanv.Text; // Giả sử cột IDNhanVien
				string tenNhanVien = txttennv.Text;
				string gioiTinh = cmbgioitinh.Text;
				string chucVu = txtchucvu.Text;
				string soDienThoai = txtsdtnv.Text;

				// Sử dụng lệnh UPDATE
				UpdateNhanVien(idNhanVien, tenNhanVien, gioiTinh, chucVu, soDienThoai);

				bangnv.Clear();
				HienThiDuLieu();
			}
			else
			{
				MessageBox.Show("Hãy nhập thông tin nhân viên");
			}
		}

		private void UpdateNhanVien(string idNhanVien, string tenNhanVien, string gioiTinh, string chucVu, string soDienThoai)
		{
			string ConnectionString = "Data Source=LAPTOP-4CEU6S6B\\SQLEXPRESS;Initial Catalog=frm_QuanLy_ShopConCung2;Integrated Security=True";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();

				string query = "UPDATE NhanVien " +
							   "SET TenNhanVien = @TenNhanVien, GioiTinh = @GioiTinh, ChucVu = @ChucVu, SDT = @SoDienThoai " +
							   "WHERE MaNhanVien = @MaNhanVien";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@MaNhanVien", idNhanVien);
					command.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
					command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
					command.Parameters.AddWithValue("@ChucVu", chucVu);
					command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

					command.ExecuteNonQuery();
				}
			}
		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			try
			{
				bangnv.Rows[donghh].Delete();
				//cap nhat csdl
				ketnoi.CapNhatDuLieu(bodocghi, bangnv);
				bangnv.Clear();
				HienThiDuLieu();
			}
			catch (Exception)
			{
				MessageBox.Show("Khong the xoa!");
			}
		}

		private void btntimkiem_Click(object sender, EventArgs e)
		{
			string keyword = txttimkiem.Text.Trim();

			if (!string.IsNullOrEmpty(keyword))
			{
				// Sử dụng DataView để lọc dữ liệu từ DataTable
				DataView dv = new DataView(bangnv);
				dv.RowFilter = $"MaNhanVien LIKE '%{keyword}%' OR TenNhanVien LIKE '%{keyword}%' ";

				// Hiển thị kết quả lọc lên DataGridView
				dgvnhanvien.DataSource = dv.ToTable();
			}
			else
			{
				// Nếu từ khóa tìm kiếm rỗng, hiển thị toàn bộ dữ liệu
				HienThiDuLieu();
			}
		}

		private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			donghh = e.RowIndex;
			// Kiểm tra xem chỉ mục dòng hợp lệ hay không
			if (donghh >= 0)
			{
				// Truy cập dòng được chọn từ DataGridView bằng chỉ mục dòng từ sự kiện CellClick
				DataGridViewRow selectedRow = dgvnhanvien.Rows[e.RowIndex];

				// Lấy giá trị từ ô cụ thể trong dòng và hiển thị lên các TextBox tương ứng
				txtmanv.Text = selectedRow.Cells[0].Value?.ToString();

				txttennv.Text = selectedRow.Cells[1].Value?.ToString();
				cmbgioitinh.Text = selectedRow.Cells[2].Value?.ToString();
				txtchucvu.Text = selectedRow.Cells[3].Value?.ToString();
				txtsdtnv.Text = selectedRow.Cells[4].Value?.ToString();

				// Tắt chức năng chỉnh sửa mã sản phẩm
				txtmanv.Enabled = false;

			}
		}

		private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void gbthongtinkh_Enter(object sender, EventArgs e)
		{

		}
	}
}
