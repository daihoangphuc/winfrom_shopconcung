namespace Form_ShopConCung
{
	partial class frm_chitietdonhang
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
			this.dgvchitietdonhang = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.gbthongtinctdh = new System.Windows.Forms.GroupBox();
			this.txtgia = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtsoluong = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtmasp = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtmadh = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtmachitietdonhang = new Guna.UI2.WinForms.Guna2TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.gbchucnangctdh = new System.Windows.Forms.GroupBox();
			this.btntimkiem = new Guna.UI2.WinForms.Guna2Button();
			this.btnnhaplai = new Guna.UI2.WinForms.Guna2Button();
			this.btnthem = new Guna.UI2.WinForms.Guna2Button();
			this.btnsua = new Guna.UI2.WinForms.Guna2Button();
			this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
			this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvchitietdonhang)).BeginInit();
			this.gbthongtinctdh.SuspendLayout();
			this.gbchucnangctdh.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvchitietdonhang
			// 
			this.dgvchitietdonhang.AllowUserToAddRows = false;
			this.dgvchitietdonhang.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvchitietdonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvchitietdonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgvchitietdonhang.Location = new System.Drawing.Point(307, 485);
			this.dgvchitietdonhang.Name = "dgvchitietdonhang";
			this.dgvchitietdonhang.RowHeadersWidth = 51;
			this.dgvchitietdonhang.RowTemplate.Height = 24;
			this.dgvchitietdonhang.Size = new System.Drawing.Size(840, 184);
			this.dgvchitietdonhang.TabIndex = 66;
			this.dgvchitietdonhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchitietdonhang_CellClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaChiTietDonHang";
			this.Column1.HeaderText = "Mã chi tiết đơn hàng";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 135;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "MaDonHang";
			this.Column2.HeaderText = "Mã đơn hàng";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "MaSanPham";
			this.Column3.HeaderText = "Mã sản phẩm";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "SoLuong";
			this.Column4.HeaderText = "Số lượng";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Gia";
			this.Column5.HeaderText = "Giá";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.Width = 125;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(588, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 29);
			this.label1.TabIndex = 54;
			this.label1.Text = "CHI TIẾT ĐƠN HÀNG";
			// 
			// gbthongtinctdh
			// 
			this.gbthongtinctdh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbthongtinctdh.Controls.Add(this.txtgia);
			this.gbthongtinctdh.Controls.Add(this.txtsoluong);
			this.gbthongtinctdh.Controls.Add(this.txtmasp);
			this.gbthongtinctdh.Controls.Add(this.txtmadh);
			this.gbthongtinctdh.Controls.Add(this.txtmachitietdonhang);
			this.gbthongtinctdh.Controls.Add(this.label7);
			this.gbthongtinctdh.Controls.Add(this.label8);
			this.gbthongtinctdh.Controls.Add(this.label9);
			this.gbthongtinctdh.Controls.Add(this.label10);
			this.gbthongtinctdh.Controls.Add(this.label11);
			this.gbthongtinctdh.Location = new System.Drawing.Point(193, 111);
			this.gbthongtinctdh.Name = "gbthongtinctdh";
			this.gbthongtinctdh.Size = new System.Drawing.Size(1062, 226);
			this.gbthongtinctdh.TabIndex = 72;
			this.gbthongtinctdh.TabStop = false;
			this.gbthongtinctdh.Enter += new System.EventHandler(this.gbthongtinctdh_Enter);
			// 
			// txtgia
			// 
			this.txtgia.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtgia.DefaultText = "";
			this.txtgia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtgia.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtgia.ForeColor = System.Drawing.Color.Black;
			this.txtgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtgia.Location = new System.Drawing.Point(684, 85);
			this.txtgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtgia.Name = "txtgia";
			this.txtgia.PasswordChar = '\0';
			this.txtgia.PlaceholderText = "";
			this.txtgia.SelectedText = "";
			this.txtgia.Size = new System.Drawing.Size(342, 48);
			this.txtgia.TabIndex = 52;
			this.txtgia.TextChanged += new System.EventHandler(this.txtgia_TextChanged);
			// 
			// txtsoluong
			// 
			this.txtsoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtsoluong.DefaultText = "";
			this.txtsoluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtsoluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtsoluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsoluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsoluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsoluong.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtsoluong.ForeColor = System.Drawing.Color.Black;
			this.txtsoluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsoluong.Location = new System.Drawing.Point(684, 29);
			this.txtsoluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtsoluong.Name = "txtsoluong";
			this.txtsoluong.PasswordChar = '\0';
			this.txtsoluong.PlaceholderText = "";
			this.txtsoluong.SelectedText = "";
			this.txtsoluong.Size = new System.Drawing.Size(342, 48);
			this.txtsoluong.TabIndex = 53;
			this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
			// 
			// txtmasp
			// 
			this.txtmasp.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtmasp.DefaultText = "";
			this.txtmasp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtmasp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtmasp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmasp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmasp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmasp.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtmasp.ForeColor = System.Drawing.Color.Black;
			this.txtmasp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmasp.Location = new System.Drawing.Point(219, 141);
			this.txtmasp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmasp.Name = "txtmasp";
			this.txtmasp.PasswordChar = '\0';
			this.txtmasp.PlaceholderText = "";
			this.txtmasp.SelectedText = "";
			this.txtmasp.Size = new System.Drawing.Size(342, 48);
			this.txtmasp.TabIndex = 54;
			// 
			// txtmadh
			// 
			this.txtmadh.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtmadh.DefaultText = "";
			this.txtmadh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtmadh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtmadh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmadh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmadh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmadh.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtmadh.ForeColor = System.Drawing.Color.Black;
			this.txtmadh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmadh.Location = new System.Drawing.Point(219, 85);
			this.txtmadh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmadh.Name = "txtmadh";
			this.txtmadh.PasswordChar = '\0';
			this.txtmadh.PlaceholderText = "";
			this.txtmadh.SelectedText = "";
			this.txtmadh.Size = new System.Drawing.Size(342, 48);
			this.txtmadh.TabIndex = 55;
			// 
			// txtmachitietdonhang
			// 
			this.txtmachitietdonhang.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtmachitietdonhang.DefaultText = "";
			this.txtmachitietdonhang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtmachitietdonhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtmachitietdonhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmachitietdonhang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmachitietdonhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmachitietdonhang.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtmachitietdonhang.ForeColor = System.Drawing.Color.Black;
			this.txtmachitietdonhang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmachitietdonhang.Location = new System.Drawing.Point(219, 29);
			this.txtmachitietdonhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmachitietdonhang.Name = "txtmachitietdonhang";
			this.txtmachitietdonhang.PasswordChar = '\0';
			this.txtmachitietdonhang.PlaceholderText = "";
			this.txtmachitietdonhang.SelectedText = "";
			this.txtmachitietdonhang.Size = new System.Drawing.Size(342, 48);
			this.txtmachitietdonhang.TabIndex = 56;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(586, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 20);
			this.label7.TabIndex = 51;
			this.label7.Text = "Giá";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(586, 46);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 20);
			this.label8.TabIndex = 50;
			this.label8.Text = "Số lượng";
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(24, 159);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(110, 20);
			this.label9.TabIndex = 49;
			this.label9.Text = "Mã sản phẩm";
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(24, 103);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(105, 20);
			this.label10.TabIndex = 48;
			this.label10.Text = "Mã đơn hàng";
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(24, 45);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(160, 20);
			this.label11.TabIndex = 47;
			this.label11.Text = "Mã chi tiết đơn hàng";
			// 
			// gbchucnangctdh
			// 
			this.gbchucnangctdh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbchucnangctdh.Controls.Add(this.btntimkiem);
			this.gbchucnangctdh.Controls.Add(this.btnnhaplai);
			this.gbchucnangctdh.Controls.Add(this.btnthem);
			this.gbchucnangctdh.Controls.Add(this.btnsua);
			this.gbchucnangctdh.Controls.Add(this.btnxoa);
			this.gbchucnangctdh.Controls.Add(this.txttimkiem);
			this.gbchucnangctdh.Location = new System.Drawing.Point(343, 348);
			this.gbchucnangctdh.Name = "gbchucnangctdh";
			this.gbchucnangctdh.Size = new System.Drawing.Size(767, 128);
			this.gbchucnangctdh.TabIndex = 61;
			this.gbchucnangctdh.TabStop = false;
			this.gbchucnangctdh.Text = "Chức năng";
			this.gbchucnangctdh.Enter += new System.EventHandler(this.gbchucnangkh_Enter);
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
			this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
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
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
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
			// frm_chitietdonhang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1445, 715);
			this.Controls.Add(this.gbchucnangctdh);
			this.Controls.Add(this.gbthongtinctdh);
			this.Controls.Add(this.dgvchitietdonhang);
			this.Controls.Add(this.label1);
			this.Name = "frm_chitietdonhang";
			this.Text = "frm_chitietdonhang";
			this.Load += new System.EventHandler(this.frm_chitietdonhang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvchitietdonhang)).EndInit();
			this.gbthongtinctdh.ResumeLayout(false);
			this.gbthongtinctdh.PerformLayout();
			this.gbchucnangctdh.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvchitietdonhang;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.GroupBox gbthongtinctdh;
		private System.Windows.Forms.GroupBox gbchucnangctdh;
		private Guna.UI2.WinForms.Guna2Button btntimkiem;
		private Guna.UI2.WinForms.Guna2Button btnnhaplai;
		private Guna.UI2.WinForms.Guna2Button btnthem;
		private Guna.UI2.WinForms.Guna2Button btnsua;
		private Guna.UI2.WinForms.Guna2Button btnxoa;
		private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
		private Guna.UI2.WinForms.Guna2TextBox txtgia;
		private Guna.UI2.WinForms.Guna2TextBox txtsoluong;
		private Guna.UI2.WinForms.Guna2TextBox txtmasp;
		private Guna.UI2.WinForms.Guna2TextBox txtmadh;
		private Guna.UI2.WinForms.Guna2TextBox txtmachitietdonhang;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
	}
}