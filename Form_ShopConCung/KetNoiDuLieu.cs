using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Form_ShopConCung
{
	internal class KetNoiDuLieu
	{
		public SqlConnection ketnoi;
		public SqlDataAdapter docghi;
		public SqlCommand lenh;
		public SqlCommandBuilder capnhat;
		public KetNoiDuLieu()
		{
			ketnoi = new SqlConnection();
			string chuoiketnoi = "Data Source=LAPTOP-4CEU6S6B\\SQLEXPRESS;Initial Catalog=frm_QuanLy_ShopConCung2;Integrated Security=True";
			ketnoi.ConnectionString = chuoiketnoi;
		}
		public DataTable DocDuLieu(string sql)
		{
			ketnoi.Open();
			docghi = new SqlDataAdapter(sql, ketnoi);
			DataTable bangtan = new DataTable();
			docghi.Fill(bangtan);
			ketnoi.Close();
			return bangtan;
		}
		public void ThaoTacDuLieu(string sql)
		{
			ketnoi.Open();
			lenh = new SqlCommand(sql, ketnoi);
			lenh.ExecuteNonQuery();
			ketnoi.Close();
		}
		public void CapNhatDuLieu(SqlDataAdapter bdg, DataTable dt)
		{
			capnhat = new SqlCommandBuilder(bdg);
			bdg.Update(dt);
		}
	}
}
