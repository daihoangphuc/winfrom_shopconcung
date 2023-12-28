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
	public partial class frm_inhoadon : Form
	{
		public frm_inhoadon()
		{
			InitializeComponent();
		}

		private void frm_inhoadon_Load(object sender, EventArgs e)
		{

            this.reportViewer1.RefreshReport();
        }
    }
}
