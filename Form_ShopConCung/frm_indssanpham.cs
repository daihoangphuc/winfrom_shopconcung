using Microsoft.Reporting.WinForms;
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
	public partial class frm_indssanpham : Form
	{
		public frm_indssanpham()
		{
			InitializeComponent();
		}
		KetNoiDuLieu kn = new KetNoiDuLieu();
		DataTable ds_in = new DataTable();
		void HienDanhMuc()
		{
			string sql = "select * from DanhMucSanPham";
			cmbdanhmucin.DataSource = kn.DocDuLieu(sql);
			cmbdanhmucin.DisplayMember = "TenDanhMuc";
			cmbdanhmucin.ValueMember = "MaDanhMuc";
		}
		private void frm_indssanpham_Load(object sender, EventArgs e)
		{
			
			this.reportViewer1.RefreshReport();
			HienDanhMuc();

			
        }

		private void btn_intheoluachon_Click_1(object sender, EventArgs e)
		{
			DBContext context = new DBContext();
			List<SanPham> listsanpham = context.SanPhams.Where(s => s.MaDanhMuc == cmbdanhmucin.SelectedValue).ToList();
			List<object_sanpham_report> listspreport = new List<object_sanpham_report>();
			foreach (SanPham s in listsanpham)
			{
				object_sanpham_report temp = new object_sanpham_report();
				temp.MaSanPham = s.MaSanPham;
				temp.TenSanPham = s.TenSanPham;
				temp.Gia = s.Gia;
				temp.SoLuongTrongKho = s.SoLuongTrongKho;
				temp.SoLuongDaBan = (int)s.SoLuongDaBan;
				temp.HinhAnh = s.HinhAnh;
				temp.TenDanhMuc = s.DanhMucSanPham.TenDanhMuc;
				listspreport.Add(temp);
			}
			reportViewer1.LocalReport.ReportPath = "rptsanpham.rdlc";
			var nguon = new ReportDataSource("SanphamDataset", listspreport);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(nguon);
			this.reportViewer1.RefreshReport();
		}

		private void btn_in_toanbo_Click_1(object sender, EventArgs e)
		{
			DBContext context = new DBContext();
			List<SanPham> listsanpham = context.SanPhams.ToList();
			List<object_sanpham_report> listspreport = new List<object_sanpham_report>();
			foreach (SanPham s in listsanpham)
			{
				object_sanpham_report temp = new object_sanpham_report();
				temp.MaSanPham = s.MaSanPham;
				temp.TenSanPham = s.TenSanPham;
				temp.Gia = s.Gia;
				temp.SoLuongTrongKho = s.SoLuongTrongKho;
				temp.SoLuongDaBan = (int)s.SoLuongDaBan;
				temp.HinhAnh = s.HinhAnh;
				temp.TenDanhMuc = s.DanhMucSanPham.TenDanhMuc;
				listspreport.Add(temp);
			}
			reportViewer1.LocalReport.ReportPath = "rptsanpham.rdlc";
			var nguon = new ReportDataSource("SanphamDataset", listspreport);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(nguon);
			this.reportViewer1.RefreshReport();
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}
