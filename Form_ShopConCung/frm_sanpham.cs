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
	public partial class frm_sanpham : Form
	{
		private KetNoiDuLieu kn = new KetNoiDuLieu();
		public frm_sanpham()
		{
			InitializeComponent();
		}
		//khai bao doi tuong
		KetNoiDuLieu ketnoi = new KetNoiDuLieu();
		SqlDataAdapter bodocghi;
		DataTable bangsp = new DataTable();
		int donghh;
		void HienThiDuLieu()
		{
			string sql = "select * from SanPham";
			bangsp = ketnoi.DocDuLieu(sql);
			bodocghi = ketnoi.docghi;
			dgvsanpham.DataSource = bangsp;
		}
		void HienDanhMuc()
		{
			string sql = "select * from DanhMucSanPham";
			cmbmadanhmuc.DataSource = ketnoi.DocDuLieu(sql);
			cmbmadanhmuc.DisplayMember = "TenDanhMuc";
			cmbmadanhmuc.ValueMember = "MaDanhMuc";
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void frm_sanpham_Load(object sender, EventArgs e)
		{
			cmbthongke.SelectedIndex = 0;
			cmbmadanhmuc.SelectedIndex = 0;
			gbsearch.Hide();
			cmbthongke.Hide();
			dgvthongke.Hide();
			// Thêm sự kiện KeyPress cho TextBox txttimkiem
			txttimkiem.KeyPress += new KeyPressEventHandler(txttimkiem_KeyPress);
			HienDanhMuc();
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
				btnthongke.Enabled = false;
				HienThiDuLieu();
			}
			else
			{
				this.Show();
			}
		}

		private void ThucHienChucNang()
		{
			if (cmbthongke.SelectedItem != null)
			{
				// Lấy chức năng được chọn từ ComboBox
				string chucNang = cmbthongke.SelectedItem.ToString();

				// Thực hiện chức năng tương ứng
				switch (chucNang)
				{
					case "Số lượng sản phẩm":
						// Thực hiện thống kê số lượng sản phẩm
						DataTable resultTable1 = kn.DocDuLieu("SELECT COUNT(*) AS SoLuongSanPham FROM SanPham");
						HienThiKetQua(resultTable1);
						break;

					case "Tổng giá trị sản phẩm":
						// Thực hiện thống kê tổng giá trị sản phẩm
						DataTable resultTable2 = kn.DocDuLieu("SELECT SUM(Gia) AS TongGiaTriSanPham FROM SanPham");
						HienThiKetQua(resultTable2);
						break;

					case "Số lượng sản phẩm theo từng danh mục":
						DataTable resultTable3 = kn.DocDuLieu("SELECT dm.TenDanhMuc AS Ten_Danh_Muc, COUNT(sp.MaSanPham) AS So_Luong_San_Pham_Theo_Danh_Muc FROM SanPham sp INNER JOIN DanhMucSanPham dm ON sp.MaDanhMuc = dm.MaDanhMuc GROUP BY dm.MaDanhMuc, dm.TenDanhMuc;");
						HienThiKetQua(resultTable3);
						break;

					case "Sản phẩm tồn kho":
						// Thực hiện thống kê sản phẩm tồn kho
						DataTable resultTable4 = kn.DocDuLieu("select TenSanPham, (SoLuongTrongKho - SoLuongDaBan) as So_Luong_Ton_Kho from SanPham WHERE SoLuongTrongKho > 0");
						HienThiKetQua(resultTable4);
						break;

					case "Sản phẩm bán chạy":
						// Thực hiện thống kê sản phẩm bán chạy
						DataTable resultTable5 = kn.DocDuLieu("SELECT TenSanPham AS San_Pham_Ban_Chay, SoLuongDaBan AS SoLuongBan FROM SanPham WHERE SoLuongDaBan > (0.5 * SoLuongTrongKho) ORDER BY SoLuongDaBan DESC;");
						HienThiKetQua(resultTable5);
						break;

					case "Doanh thu trong ngày":
						// Thực hiện thống kê doanh thu trong ngày
						DataTable resultTable6 = kn.DocDuLieu("SELECT SUM(Gia * SoLuongDaBan) AS TongDoanhThu FROM SanPham WHERE SoLuongDaBan > 0");
						HienThiKetQua(resultTable6);
						break;
				}
			}
			else
			{
				MessageBox.Show("Hãy chọn Chức năng thống kê");
			}

		}

		private void HienThiKetQua(DataTable resultTable)
		{
			// Hiển thị kết quả trong DataGridView 
			dgvthongke.DataSource = resultTable;

		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Đảm bảo đóng kết nối trước khi đóng form
			kn.ketnoi.Close();
		}

		private void dgvthongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		

		private void cmbthongke_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Kiểm tra xem đã chọn item nào trong ComboBox chưa
			if (cmbthongke.SelectedItem != null)
			{
				// Thực hiện chức năng tương ứng
				ThucHienChucNang();
			}
		}

		private void cmbthongke_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			// Kiểm tra xem đã chọn item nào trong ComboBox chưa
			if (cmbthongke.SelectedItem != null)
			{
				dgvthongke.Show();
				// Thực hiện chức năng tương ứng
				ThucHienChucNang();
			}
		}
		//----------------------------------------------------------
		private void dgvsanpham_CellClick_2(object sender, DataGridViewCellEventArgs e)
		{
			donghh = e.RowIndex;
			// Kiểm tra xem chỉ mục dòng hợp lệ hay không
			if (donghh >= 0)
			{
				// Truy cập dòng được chọn từ DataGridView bằng chỉ mục dòng từ sự kiện CellClick
				DataGridViewRow selectedRow = dgvsanpham.Rows[e.RowIndex];

				// Lấy giá trị từ ô cụ thể trong dòng và hiển thị lên các TextBox tương ứng
				txtmasp.Text = selectedRow.Cells[0].Value?.ToString();
				txttensp.Text = selectedRow.Cells[1].Value?.ToString();
				txtgiasp.Text = selectedRow.Cells[2].Value?.ToString();
				txtsltrongkho.Text = selectedRow.Cells[3].Value?.ToString();
				cmbmadanhmuc.SelectedValue = selectedRow.Cells[4].Value?.ToString();
				txthinhanh.Text = selectedRow.Cells[5].Value?.ToString();
				txtsldaban.Text = selectedRow.Cells[6].Value?.ToString();

				// Tắt chức năng chỉnh sửa mã sản phẩm
				txtmasp.Enabled = false;

				// Hiển thị hình ảnh trên pictureBox1 nếu có đường dẫn, nếu không thì ẩn pictureBox1
				if (!string.IsNullOrEmpty(txthinhanh.Text))
				{
					pictureBox1.ImageLocation = txthinhanh.Text;
				}
				else
				{
					pictureBox1.Image = null;
					// pictureBox1.Hide();
				}
			}
		}
		//--------------------------------------------------------




		private void cmbthongke_SelectedIndexChanged_2(object sender, EventArgs e)
		{
			// Kiểm tra xem đã chọn item nào trong ComboBox chưa
			if (cmbthongke.SelectedItem != null)
			{
				dgvthongke.Show();
				// Thực hiện chức năng tương ứng
				ThucHienChucNang();
			}
		}

		private void btnnhaplai_Click_1(object sender, EventArgs e)
		{
			txtmasp.Clear();
			txttensp.Clear();
			txtgiasp.Clear();
			txtsltrongkho.Clear();
			txtsldaban.Clear();
			txtsldaban.Clear();
			txthinhanh.Clear();
			txttimkiem.Clear();
			txtmasp.Enabled = true;
		}

		private void btnthem_Click_1(object sender, EventArgs e)
		{
			if (txtmasp.Text != "")
			{
				DataRow dongmoi = bangsp.NewRow();
				dongmoi["MaSanPham"] = txtmasp.Text;
				dongmoi["TenSanPham"] = txttensp.Text;
				dongmoi["Gia"] = txtgiasp.Text;
				dongmoi["SoLuongTrongKho"] = txtsltrongkho.Text;
				dongmoi["MaDanhMuc"] = cmbmadanhmuc.SelectedValue;
				dongmoi["HinhAnh"] = txthinhanh.Text;
				dongmoi["SoLuongDaBan"] = txtsldaban.Text;

				bangsp.Rows.Add(dongmoi);
				ketnoi.CapNhatDuLieu(bodocghi, bangsp);
				bangsp.Clear();
				HienThiDuLieu();
			}
		}

		private void btnsua_Click_1(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtmasp.Text))
			{
				string idSanPham = txtmasp.Text; 
				string tenSanPham = txttensp.Text;
				int gia = int.Parse(txtgiasp.Text);
				int SoLuongTrongKho = int.Parse(txtsltrongkho.Text);
				string maDanhMuc = cmbmadanhmuc.SelectedValue as string;
				maDanhMuc = maDanhMuc?.Trim();
				string hinhAnh = txthinhanh.Text;
				int soLuongDaBan = int.Parse(txtsldaban.Text);

				// Sử dụng lệnh UPDATE
				UpdateSanPham(idSanPham, tenSanPham, gia, SoLuongTrongKho, maDanhMuc, hinhAnh, soLuongDaBan);

				bangsp.Clear();
				HienThiDuLieu();
			}
			else
			{
				MessageBox.Show("Hãy nhập thông tin sản phẩm");
			}
		}

		private void UpdateSanPham(string idSanPham, string tenSanPham, int gia, int SoLuongTrongKho, string maDanhMuc, string hinhAnh, int soLuongDaBan)
		{
			string ConnectionString = "Data Source=LAPTOP-4CEU6S6B\\SQLEXPRESS;Initial Catalog=frm_QuanLy_ShopConCung2;Integrated Security=True";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();

				string query = "UPDATE SanPham " +
							   "SET TenSanPham = @TenSanPham, Gia = @Gia, SoLuongTrongKho = @SoLuongTrongKho, MaDanhMuc = @MaDanhMuc, HinhAnh = @HinhAnh, SoLuongDaBan = @SoLuongDaBan " +
							   "WHERE MaSanPham = @MaSanPham";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@MaSanPham", idSanPham);
					command.Parameters.AddWithValue("@TenSanPham", tenSanPham);
					command.Parameters.AddWithValue("@Gia", gia);
					command.Parameters.AddWithValue("@SoLuongTrongKho", SoLuongTrongKho);
					command.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
					command.Parameters.AddWithValue("@HinhAnh", hinhAnh);
					command.Parameters.AddWithValue("@SoLuongDaBan", soLuongDaBan);

					command.ExecuteNonQuery();
				}
			}
		}


		private void btnxoa_Click_1(object sender, EventArgs e)
		{
			try
			{
				// Hiển thị hộp thoại xác nhận
				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				// Kiểm tra kết quả của hộp thoại xác nhận
				if (result == DialogResult.Yes)
				{
					// Xóa dòng được chọn nếu người dùng chọn "Yes"
					bangsp.Rows[donghh].Delete();

					// Cập nhật CSDL và hiển thị lại dữ liệu
					ketnoi.CapNhatDuLieu(bodocghi, bangsp);
					bangsp.Clear();
					HienThiDuLieu();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Không thể xóa!");
			}
		}
		private bool isGbSearchVisible = false;
		private void btntimkiem_Click_1(object sender, EventArgs e)
		{

			HienThiDuLieu();

			

			cmbthongke.Hide();
			dgvthongke.Hide();
			// Ẩn/hiện gbsearch
			isGbSearchVisible = !isGbSearchVisible;
			gbsearch.Visible = isGbSearchVisible;
			dgvsanpham.Show();

		}
		private bool isDgvThongKeVisible = false;
		private bool isCmbThongKeVisible = false;
		private bool isDgvSanPhamVisible = false;

		private void btnthongke_Click(object sender, EventArgs e)
		{
			gbsearch.Hide();
			cmbthongke.Show();
			isDgvThongKeVisible = !isDgvThongKeVisible;
			dgvthongke.Visible = isDgvThongKeVisible;

			dgvsanpham.Visible = isDgvSanPhamVisible;
			isDgvSanPhamVisible = !isDgvSanPhamVisible;

			// Đảo ngược trạng thái cho lần nhấn tiếp theo
			isCmbThongKeVisible = !isCmbThongKeVisible;
			// Ẩn/hiện ComboBox tùy thuộc vào trạng thái
			cmbthongke.Visible = isCmbThongKeVisible;
		}



		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void txttimkiem_TextChanged(object sender, EventArgs e)
		{

		}
		private void PerformSearch()
		{
			string keyword = txttimkiem.Text.Trim();

			if (!string.IsNullOrEmpty(keyword))
			{
				// Sử dụng DataView để lọc dữ liệu từ DataTable
				DataView dv = new DataView(bangsp);
				dv.RowFilter = $"TenSanPham LIKE '%{keyword}%' OR MaSanPham LIKE '%{keyword}%' OR MaDanhMuc LIKE '%{keyword}%'";

				// Hiển thị kết quả lọc lên DataGridView
				dgvsanpham.DataSource = dv.ToTable();
			}
			else
			{
				// Nếu từ khóa tìm kiếm rỗng, hiển thị toàn bộ dữ liệu
				HienThiDuLieu();
			}

		}
		private void txttimkiem_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				
				// Khi nhấn phím Enter, thực hiện tìm kiếm
				PerformSearch();
			}
		}

		private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void txtmasp_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void txttensp_TextChanged(object sender, EventArgs e)
		{

		}

		private void gbsearch_Enter(object sender, EventArgs e)
		{

		}
	}
}
