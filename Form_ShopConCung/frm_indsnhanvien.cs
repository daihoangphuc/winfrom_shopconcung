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
	public partial class frm_indsnhanvien : Form
	{
		public frm_indsnhanvien()
		{
			InitializeComponent();
		}

		private void frm_indsnhanvien_Load(object sender, EventArgs e)
		{
			DBContext contetxt = new DBContext();
			List<NhanVien> listnv = contetxt.NhanViens.ToList();
			List<Nhanvien_report> listreport = new List<Nhanvien_report>();
			foreach(NhanVien nv in listnv)
			{
				Nhanvien_report temp = new Nhanvien_report();
				temp.MaNhanVien = nv.MaNhanVien;
				temp.TenNhanVien = nv.TenNhanVien;
				temp.GioiTinh = nv.GioiTinh;
				temp.ChucVu = nv.ChucVu;
				temp.SDT = nv.SDT;

				listreport.Add(temp);
			}
			reportViewer1.LocalReport.ReportPath = "rptnhanvien.rdlc";
			var nguon = new ReportDataSource("NhanvienDataset", listreport);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(nguon);
			this.reportViewer1.RefreshReport();
        }
    }
}
