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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows;

namespace Form_ShopConCung
{
	public partial class frm_danhmucsanpham : Form
	{
		public frm_danhmucsanpham()
		{
			InitializeComponent();
		}
		//khai bao doi tuong
		KetNoiDuLieu ketnoi = new KetNoiDuLieu();
		SqlDataAdapter bodocghi;
		DataTable bangdm = new DataTable();
		int donghh;
		void HienThiDuLieu()
		{
			string sql = "select * from DanhMucSanPham";
			bangdm = ketnoi.DocDuLieu(sql);
			bodocghi = ketnoi.docghi;
			dgvdanhmuc.DataSource = bangdm;
		}
		private void frm_danhmucsanpham_Load(object sender, EventArgs e)
		{
			if(PhanquyenQuanli.loaitk == "admin")
			{
				HienThiDuLieu();
			}else if(PhanquyenQuanli.loaitk == "staff")
			{
				btnxoa.Enabled = false;
				HienThiDuLieu();

			}
			else if(PhanquyenQuanli.loaitk == "user")
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
			txtmadanhmuc.Clear();
			txttendanhmuc.Clear();
			txtmadanhmuc.Enabled = true;
		}

		private void btnthem_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (txtmadanhmuc.Text != "")
				{
					DataRow dongmoi = bangdm.NewRow();
					dongmoi["MaDanhMuc"] = txtmadanhmuc.Text;
					dongmoi["TenDanhMuc"] = txttendanhmuc.Text;
					bangdm.Rows.Add(dongmoi);
					ketnoi.CapNhatDuLieu(bodocghi, bangdm);
					bangdm.Clear();
					HienThiDuLieu();
				}
			}
			catch (Exception ex)
			{
                System.Windows.MessageBox.Show("Lỗi: " + ex);
			}
		}

		private void btnsua_Click_1(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtmadanhmuc.Text))
			{
				string idDanhMuc = txtmadanhmuc.Text; // Giả sử cột IDDanhMuc
				string tenDanhMuc = txttendanhmuc.Text;

				// Sử dụng lệnh UPDATE
				UpdateDanhMuc(idDanhMuc, tenDanhMuc);

				bangdm.Clear();
				HienThiDuLieu();
			}
			else
			{
				System.Windows.MessageBox.Show("Hãy nhập thông tin");
			}
		}

		private void UpdateDanhMuc(string idDanhMuc, string tenDanhMuc)
		{
			string ConnectionString = "Data Source=LAPTOP-4CEU6S6B\\SQLEXPRESS;Initial Catalog=frm_QuanLy_ShopConCung2;Integrated Security=True";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();

				string query = "UPDATE DanhMucSanPham " +
							   "SET TenDanhMuc = @TenDanhMuc " +
							   "WHERE MaDanhMuc = @IDDanhMuc";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@IDDanhMuc", idDanhMuc);
					command.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);

					command.ExecuteNonQuery();
				}
			}
		}


		private void btnxoa_Click_1(object sender, EventArgs e)
		{

			try
			{
				bangdm.Rows[donghh].Delete();
				//cap nhat csdl
				ketnoi.CapNhatDuLieu(bodocghi, bangdm);
				bangdm.Clear();
				HienThiDuLieu();
			}
			catch (Exception)
			{
				System.Windows.MessageBox.Show("Lỗi: " + e);
			}
		}

		private void btntimkiem_Click_1(object sender, EventArgs e)
		{
			string keyword = txttimkiem.Text.Trim();

			if (!string.IsNullOrEmpty(keyword))
			{
				// Sử dụng DataView để lọc dữ liệu từ DataTable
				DataView dv = new DataView(bangdm);
				dv.RowFilter = $"MaDanhMuc LIKE '%{keyword}%' OR TenDanhMuc LIKE '%{keyword}%'";

				// Hiển thị kết quả lọc lên DataGridView
				dgvdanhmuc.DataSource = dv.ToTable();
			}
			else
			{
				// Nếu từ khóa tìm kiếm rỗng, hiển thị toàn bộ dữ liệu
				HienThiDuLieu();
			}
		}

		private void dgvdanhmuc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			donghh = e.RowIndex;
			// Kiểm tra xem chỉ mục dòng hợp lệ hay không
			if (donghh >= 0)
			{
				// Truy cập dòng được chọn từ DataGridView bằng chỉ mục dòng từ sự kiện CellClick
				DataGridViewRow selectedRow = dgvdanhmuc.Rows[e.RowIndex];

				// Lấy giá trị từ ô cụ thể trong dòng và hiển thị lên các TextBox tương ứng
				txtmadanhmuc.Text = selectedRow.Cells[0].Value?.ToString();
				txttendanhmuc.Text = selectedRow.Cells[1].Value?.ToString();

				// Tắt chức năng chỉnh sửa mã sản phẩm
				txtmadanhmuc.Enabled = false;

			}
		}
	}
}
