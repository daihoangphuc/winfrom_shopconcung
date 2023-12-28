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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Form_ShopConCung
{
	public partial class frm_khachhang : Form
	{
		public frm_khachhang()
		{
			InitializeComponent();
		}
		//khai bao doi tuong
		KetNoiDuLieu ketnoi = new KetNoiDuLieu();
		SqlDataAdapter bodocghi;
		DataTable bangkh = new DataTable();
		int donghh;
		void HienThiDuLieu()
		{
			string sql = "select * from KhachHang";
			bangkh = ketnoi.DocDuLieu(sql);
			bodocghi = ketnoi.docghi;
			dgvkhachhang.DataSource = bangkh;
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void frm_khachhang_Load(object sender, EventArgs e)
		{
			cmbgioitinh.SelectedIndex = 0;
			if (PhanquyenQuanli.loaitk == "admin")
			{
				HienThiDuLieu();
			}
			else if (PhanquyenQuanli.loaitk == "staff")
			{
				btnxoa.Enabled = false;
				HienThiDuLieu();

			}
			else if (PhanquyenQuanli.loaitk == "user")
			{
				btnthem.Enabled = false;
				btnsua.Enabled = false;
				btnxoa.Enabled = false;
				HienThiDuLieu();
			}
			else
			{
				System.Windows.MessageBox.Show("Vui long dang nhap");
				// Chuyển về form đăng nhập
				frm_main formDangNhap = new frm_main();
				formDangNhap.Show();
				this.Close();
			}
		}

		private void btnnhaplai_Click_1(object sender, EventArgs e)
		{
			txtmakh.Clear();
			txttenkh.Clear();
			//cmbgioitinh.Clear();
			txtdiachi.Clear();
			txtsdtkh.Clear();

			txtmakh.Enabled = true;
		}

		private void btnthem_Click_1(object sender, EventArgs e)
		{
			if (txtmakh.Text != "")
			{
				DataRow dongmoi = bangkh.NewRow();
				dongmoi["MaKhachHang"] = txtmakh.Text;
				dongmoi["HoTen"] = txttenkh.Text;
				dongmoi["GioiTinh"] = cmbgioitinh.Text;
				dongmoi["DiaChi"] = txtdiachi.Text;
				dongmoi["SDT"] = txtsdtkh.Text;
				bangkh.Rows.Add(dongmoi);
				ketnoi.CapNhatDuLieu(bodocghi, bangkh);
				bangkh.Clear();
				HienThiDuLieu();
			}
		}

		private void btnsua_Click_1(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtmakh.Text))
			{
				string idKhachHang = txtmakh.Text; ; // Giả sử cột IDKhachHang
				string tenKhachHang = txttenkh.Text;
				string gioiTinh = cmbgioitinh.Text;
				string diaChi = txtdiachi.Text;
				string soDienThoai = txtsdtkh.Text;

				// Sử dụng lệnh UPDATE
				UpdateKhachHang(idKhachHang, tenKhachHang, gioiTinh, diaChi, soDienThoai);

				bangkh.Clear();
				HienThiDuLieu();
			}
			else
			{
				MessageBox.Show("Hãy nhập thông tin khách hàng");
			}
		}

		private void UpdateKhachHang(string idKhachHang, string tenKhachHang, string gioiTinh, string diaChi, string soDienThoai)
		{
			string ConnectionString = "Data Source=LAPTOP-4CEU6S6B\\SQLEXPRESS;Initial Catalog=frm_QuanLy_ShopConCung2;Integrated Security=True";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();

				string query = "UPDATE KhachHang " +
							   "SET HoTen = @TenKhachHang, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SoDienThoai " +
							   "WHERE MaKhachHang = @IDKhachHang";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@IDKhachHang", idKhachHang);
					command.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
					command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
					command.Parameters.AddWithValue("@DiaChi", diaChi);
					command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

					command.ExecuteNonQuery();
				}
			}
		}


		private void btnxoa_Click_1(object sender, EventArgs e)
		{
			try
			{
				bangkh.Rows[donghh].Delete();
				//cap nhat csdl
				ketnoi.CapNhatDuLieu(bodocghi, bangkh);
				bangkh.Clear();
				HienThiDuLieu();
			}
			catch (Exception)
			{
				MessageBox.Show("Khong the xoa!");
			}
		}

		private void btntimkiem_Click_1(object sender, EventArgs e)
		{
			string keyword = txttimkiem.Text.Trim();

			if (!string.IsNullOrEmpty(keyword))
			{
				// Sử dụng DataView để lọc dữ liệu từ DataTable
				DataView dv = new DataView(bangkh);
				dv.RowFilter = $"MaKhachHang LIKE '%{keyword}%' OR Hoten LIKE '%{keyword}%' ";

				// Hiển thị kết quả lọc lên DataGridView
				dgvkhachhang.DataSource = dv.ToTable();
			}
			else
			{
				// Nếu từ khóa tìm kiếm rỗng, hiển thị toàn bộ dữ liệu
				HienThiDuLieu();
			}
		}

		private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			donghh = e.RowIndex;
			// Kiểm tra xem chỉ mục dòng hợp lệ hay không
			if (donghh >= 0)
			{
				// Truy cập dòng được chọn từ DataGridView bằng chỉ mục dòng từ sự kiện CellClick
				DataGridViewRow selectedRow = dgvkhachhang.Rows[e.RowIndex];

				// Lấy giá trị từ ô cụ thể trong dòng và hiển thị lên các TextBox tương ứng
				txtmakh.Text = selectedRow.Cells[0].Value?.ToString();

				txttenkh.Text = selectedRow.Cells[1].Value?.ToString();
				cmbgioitinh.Text = selectedRow.Cells[2].Value?.ToString();
				txtdiachi.Text = selectedRow.Cells[3].Value?.ToString();
				txtsdtkh.Text = selectedRow.Cells[4].Value?.ToString();

				// Tắt chức năng chỉnh sửa mã sản phẩm
				txtmakh.Enabled = false;

			}
		}

		private void cmbgioitinh_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void gbthongtinkh_Enter(object sender, EventArgs e)
		{

		}

		private void dgvkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
