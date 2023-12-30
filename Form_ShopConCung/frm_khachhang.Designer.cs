namespace Form_ShopConCung
{
	partial class frm_khachhang
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gbchucnangkh = new System.Windows.Forms.GroupBox();
			this.btntimkiem = new Guna.UI2.WinForms.Guna2Button();
			this.btnnhaplai = new Guna.UI2.WinForms.Guna2Button();
			this.btnthem = new Guna.UI2.WinForms.Guna2Button();
			this.btnsua = new Guna.UI2.WinForms.Guna2Button();
			this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
			this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.gbthongtinkh = new System.Windows.Forms.GroupBox();
			this.cmbgioitinh = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtsdtkh = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtdiachi = new Guna.UI2.WinForms.Guna2TextBox();
			this.txttenkh = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtmakh = new Guna.UI2.WinForms.Guna2TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvkhachhang = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.gbchucnangkh.SuspendLayout();
			this.gbthongtinkh.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.Controls.Add(this.gbchucnangkh);
			this.groupBox1.Controls.Add(this.gbthongtinkh);
			this.groupBox1.Controls.Add(this.dgvkhachhang);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1211, 821);
			this.groupBox1.TabIndex = 61;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// gbchucnangkh
			// 
			this.gbchucnangkh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbchucnangkh.Controls.Add(this.btntimkiem);
			this.gbchucnangkh.Controls.Add(this.btnnhaplai);
			this.gbchucnangkh.Controls.Add(this.btnthem);
			this.gbchucnangkh.Controls.Add(this.btnsua);
			this.gbchucnangkh.Controls.Add(this.btnxoa);
			this.gbchucnangkh.Controls.Add(this.txttimkiem);
			this.gbchucnangkh.Location = new System.Drawing.Point(197, 362);
			this.gbchucnangkh.Name = "gbchucnangkh";
			this.gbchucnangkh.Size = new System.Drawing.Size(767, 141);
			this.gbchucnangkh.TabIndex = 64;
			this.gbchucnangkh.TabStop = false;
			this.gbchucnangkh.Text = "Chức năng";
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
			this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
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
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
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
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
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
			this.txttimkiem.PlaceholderText = "    Tìm kiếm";
			this.txttimkiem.SelectedText = "";
			this.txttimkiem.Size = new System.Drawing.Size(605, 48);
			this.txttimkiem.TabIndex = 59;
			// 
			// gbthongtinkh
			// 
			this.gbthongtinkh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbthongtinkh.Controls.Add(this.cmbgioitinh);
			this.gbthongtinkh.Controls.Add(this.txtsdtkh);
			this.gbthongtinkh.Controls.Add(this.txtdiachi);
			this.gbthongtinkh.Controls.Add(this.txttenkh);
			this.gbthongtinkh.Controls.Add(this.txtmakh);
			this.gbthongtinkh.Controls.Add(this.label6);
			this.gbthongtinkh.Controls.Add(this.label5);
			this.gbthongtinkh.Controls.Add(this.label4);
			this.gbthongtinkh.Controls.Add(this.label3);
			this.gbthongtinkh.Controls.Add(this.label2);
			this.gbthongtinkh.Location = new System.Drawing.Point(55, 120);
			this.gbthongtinkh.Name = "gbthongtinkh";
			this.gbthongtinkh.Size = new System.Drawing.Size(1100, 226);
			this.gbthongtinkh.TabIndex = 63;
			this.gbthongtinkh.TabStop = false;
			// 
			// cmbgioitinh
			// 
			this.cmbgioitinh.BackColor = System.Drawing.Color.Transparent;
			this.cmbgioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbgioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbgioitinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbgioitinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbgioitinh.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbgioitinh.ForeColor = System.Drawing.Color.Black;
			this.cmbgioitinh.ItemHeight = 30;
			this.cmbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
			this.cmbgioitinh.Location = new System.Drawing.Point(163, 151);
			this.cmbgioitinh.Name = "cmbgioitinh";
			this.cmbgioitinh.Size = new System.Drawing.Size(361, 36);
			this.cmbgioitinh.TabIndex = 57;
			// 
			// txtsdtkh
			// 
			this.txtsdtkh.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtsdtkh.DefaultText = "";
			this.txtsdtkh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtsdtkh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtsdtkh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsdtkh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsdtkh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsdtkh.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtsdtkh.ForeColor = System.Drawing.Color.Black;
			this.txtsdtkh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsdtkh.Location = new System.Drawing.Point(689, 96);
			this.txtsdtkh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtsdtkh.Name = "txtsdtkh";
			this.txtsdtkh.PasswordChar = '\0';
			this.txtsdtkh.PlaceholderText = "";
			this.txtsdtkh.SelectedText = "";
			this.txtsdtkh.Size = new System.Drawing.Size(361, 48);
			this.txtsdtkh.TabIndex = 53;
			// 
			// txtdiachi
			// 
			this.txtdiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtdiachi.DefaultText = "";
			this.txtdiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtdiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtdiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtdiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtdiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtdiachi.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtdiachi.ForeColor = System.Drawing.Color.Black;
			this.txtdiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtdiachi.Location = new System.Drawing.Point(689, 40);
			this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtdiachi.Name = "txtdiachi";
			this.txtdiachi.PasswordChar = '\0';
			this.txtdiachi.PlaceholderText = "";
			this.txtdiachi.SelectedText = "";
			this.txtdiachi.Size = new System.Drawing.Size(361, 48);
			this.txtdiachi.TabIndex = 54;
			// 
			// txttenkh
			// 
			this.txttenkh.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttenkh.DefaultText = "";
			this.txttenkh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txttenkh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txttenkh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttenkh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttenkh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttenkh.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txttenkh.ForeColor = System.Drawing.Color.Black;
			this.txttenkh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttenkh.Location = new System.Drawing.Point(163, 96);
			this.txttenkh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txttenkh.Name = "txttenkh";
			this.txttenkh.PasswordChar = '\0';
			this.txttenkh.PlaceholderText = "";
			this.txttenkh.SelectedText = "";
			this.txttenkh.Size = new System.Drawing.Size(361, 48);
			this.txttenkh.TabIndex = 55;
			// 
			// txtmakh
			// 
			this.txtmakh.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtmakh.DefaultText = "";
			this.txtmakh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtmakh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtmakh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmakh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmakh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmakh.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtmakh.ForeColor = System.Drawing.Color.Black;
			this.txtmakh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmakh.Location = new System.Drawing.Point(163, 40);
			this.txtmakh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmakh.Name = "txtmakh";
			this.txtmakh.PasswordChar = '\0';
			this.txtmakh.PlaceholderText = "";
			this.txtmakh.SelectedText = "";
			this.txtmakh.Size = new System.Drawing.Size(361, 48);
			this.txtmakh.TabIndex = 56;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(577, 111);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 20);
			this.label6.TabIndex = 52;
			this.label6.Text = "Số điện thoại";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(577, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 20);
			this.label5.TabIndex = 51;
			this.label5.Text = "Địa chỉ";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 20);
			this.label4.TabIndex = 50;
			this.label4.Text = "Giới tính";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 20);
			this.label3.TabIndex = 49;
			this.label3.Text = "Tên khách hàng";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 20);
			this.label2.TabIndex = 48;
			this.label2.Text = "Mã khách hàng";
			// 
			// dgvkhachhang
			// 
			this.dgvkhachhang.AllowUserToAddRows = false;
			this.dgvkhachhang.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgvkhachhang.Location = new System.Drawing.Point(123, 509);
			this.dgvkhachhang.Name = "dgvkhachhang";
			this.dgvkhachhang.RowHeadersWidth = 51;
			this.dgvkhachhang.RowTemplate.Height = 24;
			this.dgvkhachhang.Size = new System.Drawing.Size(923, 223);
			this.dgvkhachhang.TabIndex = 62;
			this.dgvkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellClick_1);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaKhachHang";
			this.Column1.HeaderText = "Mã khách hàng";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "HoTen";
			this.Column2.HeaderText = "Tên khách hàng";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "GioiTinh";
			this.Column3.HeaderText = "Giới tính";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "DiaChi";
			this.Column4.HeaderText = "Địa chỉ";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "SDT";
			this.Column5.HeaderText = "Số điện thoại";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.Width = 125;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(436, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(329, 29);
			this.label1.TabIndex = 61;
			this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
			// 
			// frm_khachhang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1216, 824);
			this.Controls.Add(this.groupBox1);
			this.Name = "frm_khachhang";
			this.Text = "frm_khachhang";
			this.Load += new System.EventHandler(this.frm_khachhang_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbchucnangkh.ResumeLayout(false);
			this.gbthongtinkh.ResumeLayout(false);
			this.gbthongtinkh.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gbchucnangkh;
		private Guna.UI2.WinForms.Guna2Button btntimkiem;
		private Guna.UI2.WinForms.Guna2Button btnnhaplai;
		private Guna.UI2.WinForms.Guna2Button btnthem;
		private Guna.UI2.WinForms.Guna2Button btnsua;
		private Guna.UI2.WinForms.Guna2Button btnxoa;
		private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
		private System.Windows.Forms.GroupBox gbthongtinkh;
		private Guna.UI2.WinForms.Guna2ComboBox cmbgioitinh;
		private Guna.UI2.WinForms.Guna2TextBox txtsdtkh;
		private Guna.UI2.WinForms.Guna2TextBox txtdiachi;
		private Guna.UI2.WinForms.Guna2TextBox txttenkh;
		private Guna.UI2.WinForms.Guna2TextBox txtmakh;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvkhachhang;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.Label label1;
	}
}