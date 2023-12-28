using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Form_ShopConCung
{
	public partial class frm_main : Form
	{


		private bool isLoggedIn = false; // Biến kiểm tra trạng thái đăng nhập
		public frm_main()
		{
			InitializeComponent();
		}

		private void AddForm(Form f)
		{
			this.panel1.Controls.Clear();
			f.TopLevel = false;
			f.AutoScroll = true;
			f.FormBorderStyle = FormBorderStyle.None;
			f.Dock = DockStyle.Fill;
			this.panel1.Controls.Add(f);
			f.Show();
		}
		private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{

			frm_khachhang f = new frm_khachhang();
			AddForm(f);
		}

		private void frm_main_Load(object sender, EventArgs e)
		{
			chứcNăngToolStripMenuItem.Enabled = false;
			inHóaĐơnToolStripMenuItem.Enabled = false;
			đăngXuấtToolStripMenuItem.Enabled=false; 

		}



		private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_danhmucsanpham f = new frm_danhmucsanpham();
			AddForm(f);
		}

		private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_sanpham f = new frm_sanpham();
			AddForm(f);
		}

		private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_donhang f = new frm_donhang();
			AddForm(f);
		}

		private void chiTiếtĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_chitietdonhang f = new frm_chitietdonhang();
			AddForm(f);
		}





		private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void UpdateUI()
		{
			// Ẩn/Hiện các controls phù hợp với trạng thái đăng nhập
			panel1.Visible = isLoggedIn;
			chứcNăngToolStripMenuItem.Enabled = isLoggedIn;
			inHóaĐơnToolStripMenuItem.Enabled = isLoggedIn;
			gbdangnhap.Visible = !isLoggedIn;
		}
		private void inHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void gbdangnhap_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			txttaikhoan.Clear();
			txtmatkhau.Clear();
		}


		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Hiển thị lại giao diện đăng nhập
			gbdangnhap.Visible = true;
			đăngXuấtToolStripMenuItem.Enabled = false;
			// Ẩn/hiện các controls phù hợp
			chứcNăngToolStripMenuItem.Enabled = false;
			inHóaĐơnToolStripMenuItem.Enabled = false;

			// Hiển thị thông báo đăng xuất
			MessageBox.Show("Đăng xuất thành công", "Thông báo");

			// Xóa dữ liệu tài khoản đã nhập
			txttaikhoan.Clear();
			txtmatkhau.Clear();

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.Close();

		}

		private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btndangnhap_Click(object sender, EventArgs e)
		{
			KetNoiDuLieu ketnoi = new KetNoiDuLieu();
			DataTable bangtam = new DataTable();
			string sql = "select * from TaiKhoan where taikhoan='" + txttaikhoan.Text + "'and matkhau='" + txtmatkhau.Text + "'";
			bangtam = ketnoi.DocDuLieu(sql);

			if (bangtam.Rows.Count > 0)
			{
				MessageBox.Show("Dang nhap thanh cong", "Thong bao");

		


				đăngXuấtToolStripMenuItem.Enabled = true;
				if (bangtam.Rows[0]["quyen"].ToString() == "" || int.Parse(bangtam.Rows[0]["quyen"].ToString()) == 0)
				{
					inHóaĐơnToolStripMenuItem.Enabled = true;

				}
				else
				{
					chứcNăngToolStripMenuItem.Enabled = true;
					inHóaĐơnToolStripMenuItem.Enabled = true;
				}
				gbdangnhap.Visible = false;
			}
			else
			{
				MessageBox.Show("Dang nhap khong thanh cong", "Thong bao");
				txttaikhoan.Clear();
				txtmatkhau.Clear();
			}
		}

		private void inHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}
		public static string GenerateRandomString(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			Random random = new Random();

			string randomString = new string(Enumerable.Repeat(chars, length)
				.Select(s => s[random.Next(s.Length)]).ToArray());

			return randomString;
		}

		// Sử dụng hàm để tạo chuỗi ngẫu nhiên có độ dài mong muốn
		
		private void btndangki_Click_1(object sender, EventArgs e)
		{
			// Kiểm tra thông tin đăng kí
			if (string.IsNullOrEmpty(txttaikhoan.Text) || string.IsNullOrEmpty(txtmatkhau.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng kí.", "Thông báo");
				return;
			}

			// Kiểm tra xem tài khoản đã tồn tại chưa
			string taiKhoanDK = txttaikhoan.Text;
			KetNoiDuLieu ketnoi = new KetNoiDuLieu();
			string sqlCheckExist = $"SELECT COUNT(*) FROM TaiKhoan WHERE taikhoan = '{taiKhoanDK}'";
			DataTable resultTable = ketnoi.DocDuLieu(sqlCheckExist);

			if (resultTable.Rows.Count > 0)
			{
				int count = Convert.ToInt32(resultTable.Rows[0][0]);

				// Tiếp tục xử lý dựa trên giá trị count
				if (count > 0)
				{
					MessageBox.Show("Tài khoản đã tồn tại, vui lòng chọn tài khoản khác.", "Thông báo");
					return;
				}

				// Các xử lý tiếp theo nếu count <= 0
			}
			else
			{
				// Xử lý lỗi khi không có dữ liệu hoặc khi không thể chuyển đổi giá trị
				MessageBox.Show("Lỗi khi kiểm tra tài khoản.", "Thông báo");
				return;
			}

			// Thêm tài khoản mới vào cơ sở dữ liệu
			string idtaikhoan = GenerateRandomString(5);

			string matKhauDK = txtmatkhau.Text;
			string sqlInsert = $"INSERT INTO TaiKhoan(idtaikhoan ,taikhoan, matkhau) VALUES ('{idtaikhoan}', '{taiKhoanDK}', '{matKhauDK}')";
			ketnoi.DocDuLieu(sqlInsert);

			MessageBox.Show("Đăng kí thành công.", "Thông báo");

			// Xóa dữ liệu nhập và chuyển người dùng về form đăng nhập
			txttaikhoan.Clear();
			txtmatkhau.Clear();
			//tabControl1.SelectedTab = tabDangNhap; // Chọn tab đăng nhập
		}

		private void inDanhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_indsnhanvien f = new frm_indsnhanvien();
			AddForm(f);
		}

		private void inDanhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_indssanpham f = new frm_indssanpham();
			AddForm(f);
		}

		private void inDanhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_indskhachhang f = new frm_indskhachhang();
			AddForm(f);
		}
	}
}
