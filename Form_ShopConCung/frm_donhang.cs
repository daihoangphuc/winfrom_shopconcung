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
namespace Form_ShopConCung
{
	public partial class frm_donhang : Form
	{
		public frm_donhang()
		{
			InitializeComponent();
		}
		//khai bao doi tuong
		KetNoiDuLieu ketnoi = new KetNoiDuLieu();
		SqlDataAdapter bodocghi;
		DataTable bangdh = new DataTable();
		int donghh;
		void HienThiDuLieu()
		{
			string sql = "select * from DonHang";
			bangdh = ketnoi.DocDuLieu(sql);
			bodocghi = ketnoi.docghi;
			dgvdonhang.DataSource = bangdh;
		}
		private void frm_donhang_Load(object sender, EventArgs e)
		{
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
			txtmadh.Clear();
			txtngaydat.Clear();
			txtmakh.Clear();
			txtmadh.Enabled = true;
		}

		private void btnthem_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (txtmadh.Text != "")
				{
					DataRow dongmoi = bangdh.NewRow();
					dongmoi["MaDonHang"] = txtmadh.Text;
					dongmoi["NgayDatHang"] = txtngaydat.Text;
					dongmoi["MaKhachHang"] = txtmakh.Text;
					bangdh.Rows.Add(dongmoi);
					ketnoi.CapNhatDuLieu(bodocghi, bangdh);
					bangdh.Clear();
					HienThiDuLieu();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex);
			}

			
		}

		private void btnsua_Click_1(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtmadh.Text))
			{
				string idDonHang = txtmadh.Text; // Giả sử cột IDDonHang
				string ngayDatHang = txtngaydat.Text;
				string idKhachHang = txtmakh.Text;

				// Sử dụng lệnh UPDATE
				UpdateDonHang(idDonHang, ngayDatHang, idKhachHang);

				bangdh.Clear();
				HienThiDuLieu();
			}
			else
			{
				MessageBox.Show("Hãy nhập thông tin đơn hàng");
			}
		}

		private void UpdateDonHang(string idDonHang, string ngayDatHang, string idKhachHang)
		{
			string ConnectionString = "Data Source=LAPTOP-4CEU6S6B\\SQLEXPRESS;Initial Catalog=frm_QuanLy_ShopConCung2;Integrated Security=True";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();

				string query = "UPDATE DonHang " +
							   "SET NgayDatHang = @NgayDatHang, MaKhachHang = @IDKhachHang " +
							   "WHERE MaDonhang = @IDDonHang";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@IDDonHang", idDonHang);
					command.Parameters.AddWithValue("@NgayDatHang", ngayDatHang);
					command.Parameters.AddWithValue("@IDKhachHang", idKhachHang);

					command.ExecuteNonQuery();
				}
			}
		}


		private void btnxoa_Click_1(object sender, EventArgs e)
		{
			try
			{
				bangdh.Rows[donghh].Delete();
				//cap nhat csdl
				ketnoi.CapNhatDuLieu(bodocghi, bangdh);
				bangdh.Clear();
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
				DataView dv = new DataView(bangdh);
				dv.RowFilter = $"MaDonHang LIKE '%{keyword}%' OR MaKhachHang LIKE '%{keyword}%'";

				// Hiển thị kết quả lọc lên DataGridView
				dgvdonhang.DataSource = dv.ToTable();
			}
			else
			{
				// Nếu từ khóa tìm kiếm rỗng, hiển thị toàn bộ dữ liệu
				HienThiDuLieu();
			}
		}

		private void dgvdonhang_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			donghh = e.RowIndex;
			// Kiểm tra xem chỉ mục dòng hợp lệ hay không
			if (donghh >= 0)
			{
				// Truy cập dòng được chọn từ DataGridView bằng chỉ mục dòng từ sự kiện CellClick
				DataGridViewRow selectedRow = dgvdonhang.Rows[e.RowIndex];

				// Lấy giá trị từ ô cụ thể trong dòng và hiển thị lên các TextBox tương ứng
				txtmadh.Text = selectedRow.Cells[0].Value?.ToString();
				txtngaydat.Text = selectedRow.Cells[1].Value?.ToString();
				txtmakh.Text = selectedRow.Cells[2].Value?.ToString();

				// Tắt chức năng chỉnh sửa mã sản phẩm
				txtmadh.Enabled = false;
			}
		}

		private void dgvdonhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
