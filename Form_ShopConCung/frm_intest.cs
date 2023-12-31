using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ShopConCung
{
	public partial class frm_intest : Form
	{
		public frm_intest()
		{
			InitializeComponent();
		}

		private void frm_intest_Load(object sender, EventArgs e)
		{
			DBContext context = new DBContext();
			List<DonHang> listdh = context.DonHangs.ToList();
			List<Donhang_report> listreport = new List<Donhang_report>();
			foreach (DonHang k in listdh)
			{
				Donhang_report temp = new Donhang_report();
				temp.MaDonHang = k.MaDonHang;
				temp.NgayDatHang = k.NgayDatHang;
				temp.MaKhachHang = k.MaKhachHang;

				listreport.Add(temp);

			}
			reportViewer1.LocalReport.ReportPath = "rpt_intest.rdlc";
			var nguon = new ReportDataSource("Donhang_Dataset", listreport);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(nguon);
			this.reportViewer1.RefreshReport();
        }

		private void reportViewer1_Load(object sender, EventArgs e)
		{
			DBContext context = new DBContext();
			List<DonHang> listdh = context.DonHangs.ToList();
			List<Donhang_report> listreport = new List<Donhang_report>();
			foreach (DonHang k in listdh)
			{
				Donhang_report temp = new Donhang_report();
				temp.MaDonHang = k.MaDonHang;
				temp.NgayDatHang = k.NgayDatHang;
				temp.MaKhachHang = k.MaKhachHang;

				listreport.Add(temp);

			}
			reportViewer1.LocalReport.ReportPath = "rpt_intest.rdlc";
			var nguon = new ReportDataSource("Donhang_Dataset", listreport);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(nguon);
			this.reportViewer1.RefreshReport();
		}
	}
}
