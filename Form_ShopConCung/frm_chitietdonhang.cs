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

namespace Form_ShopConCung
{
	public partial class frm_chitietdonhang : Form
	{
		public frm_chitietdonhang()
		{
			InitializeComponent();
		}	
		//khai bao doi tuong
		KetNoiDuLieu ketnoi = new KetNoiDuLieu();
		SqlDataAdapter bodocghi;
		DataTable bangctdh = new DataTable();
		int donghh;
		void HienThiDuLieu()
		{
			string sql = "select * from ChiTietDonHang";
			bangctdh = ketnoi.DocDuLieu(sql);
			bodocghi = ketnoi.docghi;
			dgvchitietdonhang.DataSource = bangctdh;
		}


		private void dgvchitietdonhang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			donghh = e.RowIndex;
			// Kiểm tra xem chỉ mục dòng hợp lệ hay không
			if (donghh >= 0)
			{
				// Truy cập dòng được chọn từ DataGridView bằng chỉ mục dòng từ sự kiện CellClick
				DataGridViewRow selectedRow = dgvchitietdonhang.Rows[e.RowIndex];

				// Lấy giá trị từ ô cụ thể trong dòng và hiển thị lên các TextBox tương ứng
				txtmachitietdonhang.Text = selectedRow.Cells[0].Value?.ToString();

				txtmadh.Text = selectedRow.Cells[1].Value?.ToString();
				txtmasp.Text = selectedRow.Cells[2].Value?.ToString();
				txtsoluong.Text = selectedRow.Cells[3].Value?.ToString();
				txtgia.Text = selectedRow.Cells[4].Value?.ToString();

				// Tắt chức năng chỉnh sửa mã sản phẩm
				txtmachitietdonhang.Enabled = false;

			}
		}

		private void frm_chitietdonhang_Load(object sender, EventArgs e)
		{
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

		private void gbchucnangkh_Enter(object sender, EventArgs e)
		{

		}

		private void btnnhaplai_Click_1(object sender, EventArgs e)
		{
			txtmachitietdonhang.Clear();
			txtmadh.Clear();
			txtmasp.Clear();
			txtsoluong.Clear();
			txtgia.Clear();
			txtmachitietdonhang.Enabled = true;
		}

		private void btnthem_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (txtmachitietdonhang.Text != "")
				{
					DataRow dongmoi = bangctdh.NewRow();
					dongmoi["MaChiTietDonhang"] = txtmachitietdonhang.Text;
					dongmoi["MaDonHang"] = txtmadh.Text;
					dongmoi["MaSanPham"] = txtmasp.Text;
					dongmoi["SoLuong"] = txtsoluong.Text;
					dongmoi["Gia"] = txtgia.Text;
					bangctdh.Rows.Add(dongmoi);
					ketnoi.CapNhatDuLieu(bodocghi, bangctdh);
					bangctdh.Clear();
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
			if (!string.IsNullOrEmpty(txtmachitietdonhang.Text))
			{
				string idChiTietDonHang = txtmachitietdonhang.Text; // Giả sử cột IDChiTietDonHang
				string idDonHang = txtmadh.Text;
				string idSanPham = txtmasp.Text;
				int soLuong = int.Parse(txtsoluong.Text);
				float gia = float.Parse(txtgia.Text);

				// Sử dụng lệnh UPDATE
				UpdateChiTietDonHang(idChiTietDonHang, idDonHang, idSanPham, soLuong, gia);

				bangctdh.Clear();
				HienThiDuLieu();
			}
			else
			{
				MessageBox.Show("Hãy nhập thông tin chi tiết đơn hàng");
			}
		}

		private void UpdateChiTietDonHang(string idChiTietDonHang, string idDonHang, string idSanPham, int soLuong, float gia)
		{
			string ConnectionString = "Data Source=LAPTOP-4CEU6S6B\\SQLEXPRESS;Initial Catalog=frm_QuanLy_ShopConCung2;Integrated Security=True";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();

				string query = "UPDATE ChiTietDonHang " +
							   "SET MaDonhang = @IDDonHang, MaSanPham = @IDSanPham, SoLuong = @SoLuong, Gia = @Gia " +
							   "WHERE MaChiTietDonHang = @IDChiTietDonHang";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@IDChiTietDonHang", idChiTietDonHang);
					command.Parameters.AddWithValue("@IDDonHang", idDonHang);
					command.Parameters.AddWithValue("@IDSanPham", idSanPham);
					command.Parameters.AddWithValue("@SoLuong", soLuong);
					command.Parameters.AddWithValue("@Gia", gia);

					command.ExecuteNonQuery();
				}
			}
		}


		private void btnxoa_Click(object sender, EventArgs e)
		{
			try
			{
				bangctdh.Rows[donghh].Delete();
				//cap nhat csdl
				ketnoi.CapNhatDuLieu(bodocghi, bangctdh);
				bangctdh.Clear();
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
				DataView dv = new DataView(bangctdh);
				dv.RowFilter = $"MaChiTietDonHang LIKE '%{keyword}%' OR MaDonHang LIKE '%{keyword}%'  OR MaSanPham LIKE '%{keyword}%'";

				// Hiển thị kết quả lọc lên DataGridView
				dgvchitietdonhang.DataSource = dv.ToTable();
			}
			else
			{
				// Nếu từ khóa tìm kiếm rỗng, hiển thị toàn bộ dữ liệu
				HienThiDuLieu();
			}
		}

		private void txtgia_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtsoluong_TextChanged(object sender, EventArgs e)
		{

		}

		private void gbthongtinctdh_Enter(object sender, EventArgs e)
		{

		}
	}
}
