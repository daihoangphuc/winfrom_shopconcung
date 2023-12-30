using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ShopConCung
{
	
	public partial class frm_slider : Form
	{
		frm_home fhome;
		frm_khachhang fkhachhang;
		frm_sanpham fsanpham;
		frm_donhang fdonhang;
		frm_chitietdonhang fchitietdonhang;
		frm_danhmucsanpham fdanhmucsanpham;
		frm_main fmain;

		frm_indsnhanvien findsnhanvien;
		frm_indskhachhang findskhachhang;
		frm_indssanpham findssanpham;

		public frm_slider()
		{
			InitializeComponent();
		}
		
		public bool isLogin = false;
		private void frm_slider_Load(object sender, EventArgs e)
		{

			//menuContainer.Visible = false;
			pn_sanpham.Visible = false;
			pn_danhmuc.Visible = false;
			pn_donhang.Visible = false;
			pn_khachhang.Visible = false;
			pn_btndangxuat.Visible = false;
		}
		private void ShowChildForm(Form childForm)
		{
			gbdangnhap.Visible = false;

			childForm.FormClosed += Fmain_FormClosed;
			childForm.MdiParent = this;
			childForm.Dock = DockStyle.Fill;
		
			childForm.FormBorderStyle = FormBorderStyle.None;
	
			childForm.ControlBox = false;

			childForm.Show();
		}

		bool menuExpand = false;
		private void menuTransition_Tick(object sender, EventArgs e)
		{
			
			if (menuExpand == false)
			{
				menuContainer.Height += 10;
				if (menuContainer.Height >= 248)
				{
					menuTransition.Stop();
					menuExpand = true;
				}
			}
			else
			{
				menuContainer.Height -= 10;
				if (menuContainer.Height <= 62)
				{
					menuTransition.Stop();
					menuExpand = false;
				}
			}
		}

		private void menu_Click(object sender, EventArgs e)
		{
			menuTransition.Start();
			//slideTrasition.Start();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			slideTrasition.Start();
		}
		bool slideExpand = true;
		private void slideTrasition_Tick(object sender, EventArgs e)
		{
			if (slideExpand)
			{
				slidebarContainer.Width -= 15;
				if (slidebarContainer.Width <= 59)
				{
					slideTrasition.Stop();
					slideExpand = false;
					//pictureBox1.Hide();

				}

			}
			else
			{
				slidebarContainer.Width += 10;
				if (slidebarContainer.Width >= 250)
				{
					//pictureBox1.Show();

					slideTrasition.Stop();
					slideExpand = true;
				}
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			//home

			if (fhome == null)
			{
				fhome = new frm_home();
				ShowChildForm(fhome);
				fhome.BringToFront();
			}
			else
			{
				fhome.Activate();
			}
		}

		private void Fmain_FormClosed(object sender, FormClosedEventArgs e)
		{
			fmain = null;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			gbdangnhap.Visible = false;

			//In san Pham
			if (findssanpham == null)
			{
				findssanpham = new frm_indssanpham();
				ShowChildForm(findssanpham);
			}
			else
			{
				findssanpham.Activate();
			}
		}

		private void btnsanpham_Click(object sender, EventArgs e)
		{
			gbdangnhap.Visible = false;

			if (fsanpham == null)
			{
				fsanpham = new frm_sanpham();
				ShowChildForm(fsanpham);
			}
			else
			{
				fsanpham.Activate();
			}
		}

		private void Fsanpham_FormClosed(object sender, FormClosedEventArgs e)
		{
			fsanpham = null;
		}
		private void Fdanhmuc_FormClosed(object sender, FormClosedEventArgs e)
		{
			fdanhmucsanpham = null;
		}

		private void btnkhachhang_Click(object sender, EventArgs e)
		{
			gbdangnhap.Visible = false;
			if (fkhachhang == null)
			{
				fkhachhang = new frm_khachhang();
				ShowChildForm(fkhachhang);
			}
			else
			{
				fkhachhang.Activate();
			}
		}

		private void btndanhmuc_Click(object sender, EventArgs e)
		{
			gbdangnhap.Visible = false;

			if (fdanhmucsanpham == null)
			{
				fdanhmucsanpham = new frm_danhmucsanpham();
				ShowChildForm(fdanhmucsanpham);
			}
			else
			{
				fdanhmucsanpham.Activate();
			}
		}

		 
		private void btndonhang_Click(object sender, EventArgs e)
		{
			gbdangnhap.Visible = false;

			if (fchitietdonhang == null)
			{
				fchitietdonhang = new frm_chitietdonhang();
				ShowChildForm(fchitietdonhang);
			}
			else
			{
				fchitietdonhang.Activate();
			}
		}


		private void button4_Click(object sender, EventArgs e)
		{
			//in nhan vien
			gbdangnhap.Visible = false;

			if (findsnhanvien == null)
			{
				findsnhanvien = new frm_indsnhanvien();
				ShowChildForm(findsnhanvien);
			}
			else
			{
				findsnhanvien.Activate();
			}
		}


		private void inkhachhang_Click(object sender, EventArgs e)
		{
			//In ds khach hang
			gbdangnhap.Visible = false;
			if (findskhachhang == null)
			{
				findskhachhang = new frm_indskhachhang();
				ShowChildForm(findskhachhang);
			}
			else
			{
				findskhachhang.Activate();
			}
		}


		bool tkExpand = false;
		private void taikhoanTransition_Tick(object sender, EventArgs e)
		{
			if (tkExpand == false)
			{
				tkContainer.Height += 10;
				if (tkContainer.Height >= 124)
				{
					taikhoanTransition.Stop();
					tkExpand = true;
				}
			}
			else
			{
				tkContainer.Height -= 10;
				if (tkContainer.Height <= 62)
				{
					taikhoanTransition.Stop();
					tkExpand = false;
				}
			}
		}

		private void btn_tk_Click(object sender, EventArgs e)
		{
			taikhoanTransition.Start();
		}

		private void btndangnhap_slider_Click(object sender, EventArgs e)
		{
			//dangnhap
			fhome = new frm_home();
			ShowChildForm(fhome);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			btndanhmuc.Visible = false;
			btnkhachhang.Visible = false;
			btndonhang.Visible = false;
			menu.Visible = false;
			btnsanpham.Visible = false;
			// Hiển thị thông báo đăng xuất
			MessageBox.Show("Đăng xuất thành công", "Thông báo");
			// Xóa dữ liệu tài khoản đã nhập
			txttaikhoan.Clear();
			txtmatkhau.Clear();

			Application.Restart();
		}

		private void btn_thoat_Click(object sender, EventArgs e)
		{

			DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			// Kiểm tra kết quả của hộp thoại xác nhận
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
		public static string GenerateRandomString(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			Random random = new Random();

			string randomString = new string(Enumerable.Repeat(chars, length)
				.Select(s => s[random.Next(s.Length)]).ToArray());

			return randomString;
		}

		private void gbdangnhap_Enter(object sender, EventArgs e)
		{

		}

		private void button8_MouseEnter(object sender, EventArgs e)
		{
			button8.BackColor = Color.DeepPink;
		}

		private void button8_MouseLeave(object sender, EventArgs e)
		{
			button8.BackColor = SystemColors.ActiveCaptionText;
		}

		private void btndangnhap_Click_1(object sender, EventArgs e)
		{
			KetNoiDuLieu ketnoi = new KetNoiDuLieu();
			DataTable bangtam = new DataTable();
			string sql = "select * from TaiKhoan where taikhoan='" + txttaikhoan.Text + "'and matkhau='" + txtmatkhau.Text + "'";
			bangtam = ketnoi.DocDuLieu(sql);

			if (bangtam.Rows.Count > 0)
			{
				btndangnhap_slider.Visible = false;
				button7.Visible = true;
				if (bangtam.Rows[0]["quyen"].ToString() == "")
				{
					PhanquyenQuanli.loaitk = "user";
					MessageBox.Show("Đăng nhập tài khoản khách hàng thành công", "Thông báo");
					pn_sanpham.Visible = true;
					pn_btndangxuat.Visible = true;
					pn_btdangnhap.Visible = false;

				}
				else if (int.Parse(bangtam.Rows[0]["quyen"].ToString()) == 0)
				{
					PhanquyenQuanli.loaitk = "staff";
					MessageBox.Show("Đăng nhập tài khoản nhân viên thành công", "Thông báo");

					menuContainer.Visible = true;
					pn_sanpham.Visible = true;
					pn_danhmuc.Visible = true;
					pn_donhang.Visible = true;
					pn_khachhang.Visible = true;
					tkContainer.Visible = true;
					menuContainer.Visible = true;
					pn_btndangxuat.Visible = true;
					pn_btdangnhap.Visible = false;

				}
				else
				{
					PhanquyenQuanli.loaitk = "admin";
					MessageBox.Show("Đăng nhập tài khoản Admin thành công", "Thông báo");
					menuContainer.Visible = true;
					pn_sanpham.Visible = true;
					pn_danhmuc.Visible = true;
					pn_donhang.Visible = true;
					pn_khachhang.Visible = true;
					menuContainer.Visible = true;
					pn_btndangxuat.Visible = true;
					pn_btdangnhap.Visible = false;
				}

			}
			else
			{
				MessageBox.Show("Đăng nhập không thành công", "Thông báo");
				txttaikhoan.Clear();
				txtmatkhau.Clear();


			}
		}

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
	}
}
