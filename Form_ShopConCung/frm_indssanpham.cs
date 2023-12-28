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

namespace Form_ShopConCung
{
	public partial class frm_indssanpham : Form
	{
		public frm_indssanpham()
		{
			InitializeComponent();
		}

		private void frm_indssanpham_Load(object sender, EventArgs e)
		{
			DBContext context = new DBContext();
			List<SanPham> listsanpham = context.SanPhams.ToList();
			List<object_sanpham_report> listspreport = new List<object_sanpham_report>();
			foreach(SanPham s in listsanpham)
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
    }
}
