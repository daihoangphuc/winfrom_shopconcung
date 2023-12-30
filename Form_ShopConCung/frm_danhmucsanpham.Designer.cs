namespace Form_ShopConCung
{
	partial class frm_danhmucsanpham
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvdanhmuc = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.gbthongtindmsp = new System.Windows.Forms.GroupBox();
			this.txttendanhmuc = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtmadanhmuc = new Guna.UI2.WinForms.Guna2TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.gbchucnangdmsp = new System.Windows.Forms.GroupBox();
			this.btntimkiem = new Guna.UI2.WinForms.Guna2Button();
			this.btnnhaplai = new Guna.UI2.WinForms.Guna2Button();
			this.btnthem = new Guna.UI2.WinForms.Guna2Button();
			this.btnsua = new Guna.UI2.WinForms.Guna2Button();
			this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
			this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvdanhmuc)).BeginInit();
			this.gbthongtindmsp.SuspendLayout();
			this.gbchucnangdmsp.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvdanhmuc
			// 
			this.dgvdanhmuc.AllowUserToAddRows = false;
			this.dgvdanhmuc.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvdanhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdanhmuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.dgvdanhmuc.Location = new System.Drawing.Point(566, 391);
			this.dgvdanhmuc.Name = "dgvdanhmuc";
			this.dgvdanhmuc.RowHeadersWidth = 51;
			this.dgvdanhmuc.RowTemplate.Height = 24;
			this.dgvdanhmuc.Size = new System.Drawing.Size(462, 184);
			this.dgvdanhmuc.TabIndex = 34;
			this.dgvdanhmuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhmuc_CellClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaDanhMuc";
			this.Column1.HeaderText = "Mã danh mục";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TenDanhMuc";
			this.Column2.HeaderText = "Tên danh mục";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(631, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(350, 29);
			this.label1.TabIndex = 17;
			this.label1.Text = "DANH MỤC LOẠI SẢN PHẨM";
			// 
			// gbthongtindmsp
			// 
			this.gbthongtindmsp.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbthongtindmsp.Controls.Add(this.txttendanhmuc);
			this.gbthongtindmsp.Controls.Add(this.txtmadanhmuc);
			this.gbthongtindmsp.Controls.Add(this.label10);
			this.gbthongtindmsp.Controls.Add(this.label11);
			this.gbthongtindmsp.Location = new System.Drawing.Point(325, 66);
			this.gbthongtindmsp.Name = "gbthongtindmsp";
			this.gbthongtindmsp.Size = new System.Drawing.Size(954, 174);
			this.gbthongtindmsp.TabIndex = 74;
			this.gbthongtindmsp.TabStop = false;
			// 
			// txttendanhmuc
			// 
			this.txttendanhmuc.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttendanhmuc.DefaultText = "";
			this.txttendanhmuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txttendanhmuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txttendanhmuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttendanhmuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttendanhmuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttendanhmuc.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txttendanhmuc.ForeColor = System.Drawing.Color.Black;
			this.txttendanhmuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttendanhmuc.Location = new System.Drawing.Point(168, 88);
			this.txttendanhmuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txttendanhmuc.Name = "txttendanhmuc";
			this.txttendanhmuc.PasswordChar = '\0';
			this.txttendanhmuc.PlaceholderText = "";
			this.txttendanhmuc.SelectedText = "";
			this.txttendanhmuc.Size = new System.Drawing.Size(712, 48);
			this.txttendanhmuc.TabIndex = 49;
			// 
			// txtmadanhmuc
			// 
			this.txtmadanhmuc.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtmadanhmuc.DefaultText = "";
			this.txtmadanhmuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtmadanhmuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtmadanhmuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmadanhmuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmadanhmuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmadanhmuc.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtmadanhmuc.ForeColor = System.Drawing.Color.Black;
			this.txtmadanhmuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmadanhmuc.Location = new System.Drawing.Point(168, 32);
			this.txtmadanhmuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmadanhmuc.Name = "txtmadanhmuc";
			this.txtmadanhmuc.PasswordChar = '\0';
			this.txtmadanhmuc.PlaceholderText = "";
			this.txtmadanhmuc.SelectedText = "";
			this.txtmadanhmuc.Size = new System.Drawing.Size(712, 48);
			this.txtmadanhmuc.TabIndex = 50;
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(27, 102);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(115, 20);
			this.label10.TabIndex = 48;
			this.label10.Text = "Tên danh mục";
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(27, 47);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(110, 20);
			this.label11.TabIndex = 47;
			this.label11.Text = "Mã danh mục";
			// 
			// gbchucnangdmsp
			// 
			this.gbchucnangdmsp.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbchucnangdmsp.Controls.Add(this.btntimkiem);
			this.gbchucnangdmsp.Controls.Add(this.btnnhaplai);
			this.gbchucnangdmsp.Controls.Add(this.btnthem);
			this.gbchucnangdmsp.Controls.Add(this.btnsua);
			this.gbchucnangdmsp.Controls.Add(this.btnxoa);
			this.gbchucnangdmsp.Controls.Add(this.txttimkiem);
			this.gbchucnangdmsp.Location = new System.Drawing.Point(423, 248);
			this.gbchucnangdmsp.Name = "gbchucnangdmsp";
			this.gbchucnangdmsp.Size = new System.Drawing.Size(767, 128);
			this.gbchucnangdmsp.TabIndex = 75;
			this.gbchucnangdmsp.TabStop = false;
			this.gbchucnangdmsp.Text = "Chức năng";
			// 
			// btntimkiem
			// 
			this.btntimkiem.Animated = true;
			this.btntimkiem.AutoRoundedCorners = true;
			this.btntimkiem.BackColor = System.Drawing.Color.Transparent;
			this.btntimkiem.BorderRadius = 21;
			this.btntimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btntimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btntimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btntimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btntimkiem.FillColor = System.Drawing.Color.HotPink;
			this.btntimkiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
			this.btntimkiem.ForeColor = System.Drawing.Color.Black;
			this.btntimkiem.Location = new System.Drawing.Point(611, 77);
			this.btntimkiem.Name = "btntimkiem";
			this.btntimkiem.Size = new System.Drawing.Size(156, 45);
			this.btntimkiem.TabIndex = 64;
			this.btntimkiem.Text = "Tìm kiếm";
			this.btntimkiem.UseTransparentBackground = true;
			this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click_1);
			// 
			// btnnhaplai
			// 
			this.btnnhaplai.Animated = true;
			this.btnnhaplai.AutoRoundedCorners = true;
			this.btnnhaplai.BackColor = System.Drawing.Color.Transparent;
			this.btnnhaplai.BorderRadius = 21;
			this.btnnhaplai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnnhaplai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnnhaplai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnnhaplai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnnhaplai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnnhaplai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnnhaplai.ForeColor = System.Drawing.Color.Black;
			this.btnnhaplai.Location = new System.Drawing.Point(0, 21);
			this.btnnhaplai.Name = "btnnhaplai";
			this.btnnhaplai.Size = new System.Drawing.Size(156, 45);
			this.btnnhaplai.TabIndex = 60;
			this.btnnhaplai.Text = "Nhập lại";
			this.btnnhaplai.UseTransparentBackground = true;
			this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click_1);
			// 
			// btnthem
			// 
			this.btnthem.Animated = true;
			this.btnthem.AutoRoundedCorners = true;
			this.btnthem.BackColor = System.Drawing.Color.Transparent;
			this.btnthem.BorderRadius = 21;
			this.btnthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnthem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnthem.ForeColor = System.Drawing.Color.Black;
			this.btnthem.Location = new System.Drawing.Point(204, 21);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(156, 45);
			this.btnthem.TabIndex = 61;
			this.btnthem.Text = "Thêm";
			this.btnthem.UseTransparentBackground = true;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
			// 
			// btnsua
			// 
			this.btnsua.Animated = true;
			this.btnsua.AutoRoundedCorners = true;
			this.btnsua.BackColor = System.Drawing.Color.Transparent;
			this.btnsua.BorderRadius = 21;
			this.btnsua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnsua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnsua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnsua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnsua.FillColor = System.Drawing.Color.Lime;
			this.btnsua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnsua.ForeColor = System.Drawing.Color.Black;
			this.btnsua.Location = new System.Drawing.Point(412, 21);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(156, 45);
			this.btnsua.TabIndex = 62;
			this.btnsua.Text = "Sửa";
			this.btnsua.UseTransparentBackground = true;
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
			// 
			// btnxoa
			// 
			this.btnxoa.Animated = true;
			this.btnxoa.AutoRoundedCorners = true;
			this.btnxoa.BackColor = System.Drawing.Color.Transparent;
			this.btnxoa.BorderRadius = 21;
			this.btnxoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnxoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnxoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnxoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnxoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnxoa.ForeColor = System.Drawing.Color.Black;
			this.btnxoa.Location = new System.Drawing.Point(611, 21);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(156, 45);
			this.btnxoa.TabIndex = 63;
			this.btnxoa.Text = "Xóa";
			this.btnxoa.UseTransparentBackground = true;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
			// 
			// txttimkiem
			// 
			this.txttimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttimkiem.DefaultText = "";
			this.txttimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txttimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txttimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txttimkiem.ForeColor = System.Drawing.Color.Black;
			this.txttimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttimkiem.Location = new System.Drawing.Point(0, 77);
			this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txttimkiem.Name = "txttimkiem";
			this.txttimkiem.PasswordChar = '\0';
			this.txttimkiem.PlaceholderForeColor = System.Drawing.Color.Black;
			this.txttimkiem.PlaceholderText = "Tìm kiếm";
			this.txttimkiem.SelectedText = "";
			this.txttimkiem.Size = new System.Drawing.Size(605, 48);
			this.txttimkiem.TabIndex = 59;
			// 
			// frm_danhmucsanpham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1605, 676);
			this.Controls.Add(this.gbchucnangdmsp);
			this.Controls.Add(this.gbthongtindmsp);
			this.Controls.Add(this.dgvdanhmuc);
			this.Controls.Add(this.label1);
			this.Name = "frm_danhmucsanpham";
			this.Text = "frm_danhmucsanpham";
			this.Load += new System.EventHandler(this.frm_danhmucsanpham_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvdanhmuc)).EndInit();
			this.gbthongtindmsp.ResumeLayout(false);
			this.gbthongtindmsp.PerformLayout();
			this.gbchucnangdmsp.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvdanhmuc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.GroupBox gbthongtindmsp;
		private System.Windows.Forms.GroupBox gbchucnangdmsp;
		private Guna.UI2.WinForms.Guna2Button btntimkiem;
		private Guna.UI2.WinForms.Guna2Button btnnhaplai;
		private Guna.UI2.WinForms.Guna2Button btnthem;
		private Guna.UI2.WinForms.Guna2Button btnsua;
		private Guna.UI2.WinForms.Guna2Button btnxoa;
		private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
		private Guna.UI2.WinForms.Guna2TextBox txttendanhmuc;
		private Guna.UI2.WinForms.Guna2TextBox txtmadanhmuc;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
	}
}