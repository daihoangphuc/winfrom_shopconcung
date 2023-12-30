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
	public partial class frm_indskhachhang : Form
	{
		public frm_indskhachhang()
		{
			InitializeComponent();
		}

		private void frm_indskhachhang_Load(object sender, EventArgs e)
		{
			DBContext context = new DBContext();
			List<KhachHang> liskh = context.KhachHangs.ToList();
			List<Khachhang_Report> listreport = new List<Khachhang_Report>();
			foreach(KhachHang k in liskh)
			{
				Khachhang_Report temp = new Khachhang_Report();
				temp.MaKhachHang = k.MaKhachHang;
				temp.HoTen = k.HoTen;
				temp.GioiTinh = k.GioiTinh;
				temp.DiaChi = k.DiaChi;
				temp.SDT = k.SDT;

				listreport.Add(temp);

			}
			reportViewer1.LocalReport.ReportPath = "rptkhachhang.rdlc";
			var nguon = new ReportDataSource("KhachhangDataset", listreport);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(nguon);
            this.reportViewer1.RefreshReport();
        }

		private void reportViewer1_Load(object sender, EventArgs e)
		{
			DBContext context = new DBContext();
			List<KhachHang> liskh = context.KhachHangs.ToList();
			List<Khachhang_Report> listreport = new List<Khachhang_Report>();
			foreach (KhachHang k in liskh)
			{
				Khachhang_Report temp = new Khachhang_Report();
				temp.MaKhachHang = k.MaKhachHang;
				temp.HoTen = k.HoTen;
				temp.GioiTinh = k.GioiTinh;
				temp.DiaChi = k.DiaChi;
				temp.SDT = k.SDT;

				listreport.Add(temp);

			}
			reportViewer1.LocalReport.ReportPath = "rptkhachhang.rdlc";
			var nguon = new ReportDataSource("KhachhangDataset", listreport);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(nguon);
			this.reportViewer1.RefreshReport();
		}
	}
}
