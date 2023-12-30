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
	public partial class frm_taikhoan : Form
	{
		public frm_taikhoan()
		{
			InitializeComponent();
		}
		KetNoiDuLieu ketnoi = new KetNoiDuLieu();
		SqlDataAdapter bodocghi;
		DataTable bangtk = new DataTable();
		int donghh;
		void HienThiDuLieu()
		{
			string sql = "select * from TaiKhoan";
			bangtk = ketnoi.DocDuLieu(sql);
			bodocghi = ketnoi.docghi;
			dgvtttaikhoan.DataSource = bangtk;
		}
		private void frm_taikhoan_Load(object sender, EventArgs e)
		{
			cmbquyen.SelectedIndex = 0;
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
				
			}
		}

		private void btnnhaplai_Click(object sender, EventArgs e)
		{
			txtmatk.Clear();
			txttentk.Clear();
			txtmatkhau.Clear();
			txtmanv.Clear();
			txtmakh.Clear();
			txtmatk.Enabled = true;
		}

		private void btnthem_Click(object sender, EventArgs e)
		{
			if (txtmatk.Text != "")
			{
				DataRow dongmoi = bangtk.NewRow();
				dongmoi["idtaikhoan"] = txtmatk.Text;
				dongmoi["taikhoan"] = txttentk.Text;
				dongmoi["matkhau"] = txtmatk.Text;
				dongmoi["quyen"] = cmbquyen.SelectedItem;

				// Gán giá trị null nếu chuỗi là rỗng
				dongmoi["MaNhanVien"] = string.IsNullOrEmpty(txtmanv.Text) ? (object)DBNull.Value : txtmanv.Text;
				dongmoi["MaKhachHang"] = string.IsNullOrEmpty(txtmakh.Text) ? (object)DBNull.Value : txtmakh.Text;

				bangtk.Rows.Add(dongmoi);
				ketnoi.CapNhatDuLieu(bodocghi, bangtk);
				bangtk.Clear();
				HienThiDuLieu();
			}
		}

		private void btnsua_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtmatk.Text))
			{
				string idTaiKhoan = txtmatk.Text; // Giả sử cột IDTaiKhoan
				string tenTaiKhoan = txttentk.Text;
				string matKhau = txtmatkhau.Text;
				int quyen = Convert.ToInt32(cmbquyen.Text);
				string maNhanVien = string.IsNullOrEmpty(txtmanv.Text) ? null : txtmanv.Text;
				string maKhachHang = string.IsNullOrEmpty(txtmakh.Text) ? null : txtmakh.Text;

				// Sử dụng lệnh UPDATE
				UpdateTaiKhoan(idTaiKhoan, tenTaiKhoan, matKhau, quyen, maNhanVien, maKhachHang);

				bangtk.Clear();
				HienThiDuLieu();
			}
			else
			{
				MessageBox.Show("Hãy nhập thông tin");
			}
		}

		private void UpdateTaiKhoan(string idTaiKhoan, string tenTaiKhoan, string matKhau, int quyen, string maNhanVien, string maKhachHang)
		{
			string ConnectionString = "Data Source=LAPTOP-4CEU6S6B\\SQLEXPRESS;Initial Catalog=frm_QuanLy_ShopConCung2;Integrated Security=True";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();

				string query = "UPDATE TaiKhoan " +
							   "SET taikhoan = @TenTaiKhoan, matkhau = @MatKhau, quyen = @Quyen, MaNhanVien = @MaNhanVien, MaKhachHang = @MaKhachHang " +
							   "WHERE idtaikhoan = @IDTaiKhoan";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@IDTaiKhoan", idTaiKhoan);
					command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
					command.Parameters.AddWithValue("@MatKhau", matKhau);
					command.Parameters.AddWithValue("@Quyen", quyen);
					command.Parameters.AddWithValue("@MaNhanVien", string.IsNullOrEmpty(maNhanVien) ? (object)DBNull.Value : maNhanVien);
					command.Parameters.AddWithValue("@MaKhachHang", string.IsNullOrEmpty(maKhachHang) ? (object)DBNull.Value : maKhachHang);

					command.ExecuteNonQuery();
				}
			}
		}



		private void btnxoa_Click(object sender, EventArgs e)
		{
			try
			{
				// Hiển thị hộp thoại xác nhận
				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				// Kiểm tra kết quả của hộp thoại xác nhận
				if (result == DialogResult.Yes)
				{
					// Xóa dòng được chọn nếu người dùng chọn "Yes"
					bangtk.Rows[donghh].Delete();

					// Cập nhật CSDL và hiển thị lại dữ liệu
					ketnoi.CapNhatDuLieu(bodocghi, bangtk);
					bangtk.Clear();
					HienThiDuLieu();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Không thể xóa!");
			}
		}

		private void btntimkiem_Click(object sender, EventArgs e)
		{
			string keyword = txttimkiem.Text.Trim();

			if (!string.IsNullOrEmpty(keyword))
			{


				// Sử dụng DataView để lọc dữ liệu từ DataTable
				DataView dv = new DataView(bangtk);
				dv.RowFilter = $"idtaikhoan LIKE '%{keyword}%' OR taikhoan LIKE '%{keyword}%' ";

				// Hiển thị kết quả lọc lên DataGridView
				dgvtttaikhoan.DataSource = dv.ToTable();
			}
			else
			{
				// Nếu từ khóa tìm kiếm rỗng, hiển thị toàn bộ dữ liệu
				HienThiDuLieu();
			}
		}

		private void dgvtttaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			donghh = e.RowIndex;
			// Kiểm tra xem chỉ mục dòng hợp lệ hay không
			if (donghh >= 0)
			{
				// Truy cập dòng được chọn từ DataGridView bằng chỉ mục dòng từ sự kiện CellClick
				DataGridViewRow selectedRow = dgvtttaikhoan.Rows[e.RowIndex];

				// Lấy giá trị từ ô cụ thể trong dòng và hiển thị lên các TextBox tương ứng
				txtmatk.Text = selectedRow.Cells[0].Value?.ToString();

				txttentk.Text = selectedRow.Cells[1].Value?.ToString();
				txtmatkhau.Text = selectedRow.Cells[2].Value?.ToString();
				cmbquyen.Text = selectedRow.Cells[3].Value?.ToString();
				txtmanv.Text = selectedRow.Cells[4].Value?.ToString();
				txtmakh.Text = selectedRow.Cells[5].Value?.ToString();

				// Tắt chức năng chỉnh sửa mã sản phẩm
				txtmatk.Enabled = false;

			}
		}

		private void dgvtttaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
