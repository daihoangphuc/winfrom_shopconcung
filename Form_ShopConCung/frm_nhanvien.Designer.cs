namespace Form_ShopConCung
{
	partial class frm_nhanvien
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
			this.btntimkiem = new Guna.UI2.WinForms.Guna2Button();
			this.btnnhaplai = new Guna.UI2.WinForms.Guna2Button();
			this.btnthem = new Guna.UI2.WinForms.Guna2Button();
			this.btnsua = new Guna.UI2.WinForms.Guna2Button();
			this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.gbchucnangkh = new System.Windows.Forms.GroupBox();
			this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
			this.cmbgioitinh = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtsdtnv = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtchucvu = new Guna.UI2.WinForms.Guna2TextBox();
			this.txttennv = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtmanv = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gbthongtinkh = new System.Windows.Forms.GroupBox();
			this.dgvnhanvien = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbchucnangkh.SuspendLayout();
			this.gbthongtinkh.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
			this.SuspendLayout();
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
			// gbchucnangkh
			// 
			this.gbchucnangkh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbchucnangkh.Controls.Add(this.btntimkiem);
			this.gbchucnangkh.Controls.Add(this.btnnhaplai);
			this.gbchucnangkh.Controls.Add(this.btnthem);
			this.gbchucnangkh.Controls.Add(this.btnsua);
			this.gbchucnangkh.Controls.Add(this.btnxoa);
			this.gbchucnangkh.Controls.Add(this.txttimkiem);
			this.gbchucnangkh.Location = new System.Drawing.Point(197, 378);
			this.gbchucnangkh.Name = "gbchucnangkh";
			this.gbchucnangkh.Size = new System.Drawing.Size(767, 141);
			this.gbchucnangkh.TabIndex = 64;
			this.gbchucnangkh.TabStop = false;
			this.gbchucnangkh.Text = "Chức năng";
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
			// txtsdtnv
			// 
			this.txtsdtnv.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtsdtnv.DefaultText = "";
			this.txtsdtnv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtsdtnv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtsdtnv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsdtnv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsdtnv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsdtnv.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtsdtnv.ForeColor = System.Drawing.Color.Black;
			this.txtsdtnv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsdtnv.Location = new System.Drawing.Point(689, 96);
			this.txtsdtnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtsdtnv.Name = "txtsdtnv";
			this.txtsdtnv.PasswordChar = '\0';
			this.txtsdtnv.PlaceholderText = "";
			this.txtsdtnv.SelectedText = "";
			this.txtsdtnv.Size = new System.Drawing.Size(361, 48);
			this.txtsdtnv.TabIndex = 53;
			// 
			// txtchucvu
			// 
			this.txtchucvu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtchucvu.DefaultText = "";
			this.txtchucvu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtchucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtchucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtchucvu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtchucvu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtchucvu.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtchucvu.ForeColor = System.Drawing.Color.Black;
			this.txtchucvu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtchucvu.Location = new System.Drawing.Point(689, 40);
			this.txtchucvu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtchucvu.Name = "txtchucvu";
			this.txtchucvu.PasswordChar = '\0';
			this.txtchucvu.PlaceholderText = "";
			this.txtchucvu.SelectedText = "";
			this.txtchucvu.Size = new System.Drawing.Size(361, 48);
			this.txtchucvu.TabIndex = 54;
			// 
			// txttennv
			// 
			this.txttennv.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttennv.DefaultText = "";
			this.txttennv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txttennv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txttennv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttennv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttennv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttennv.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txttennv.ForeColor = System.Drawing.Color.Black;
			this.txttennv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttennv.Location = new System.Drawing.Point(163, 96);
			this.txttennv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txttennv.Name = "txttennv";
			this.txttennv.PasswordChar = '\0';
			this.txttennv.PlaceholderText = "";
			this.txttennv.SelectedText = "";
			this.txttennv.Size = new System.Drawing.Size(361, 48);
			this.txttennv.TabIndex = 55;
			// 
			// txtmanv
			// 
			this.txtmanv.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtmanv.DefaultText = "";
			this.txtmanv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtmanv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtmanv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmanv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmanv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmanv.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtmanv.ForeColor = System.Drawing.Color.Black;
			this.txtmanv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmanv.Location = new System.Drawing.Point(163, 40);
			this.txtmanv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmanv.Name = "txtmanv";
			this.txtmanv.PasswordChar = '\0';
			this.txtmanv.PlaceholderText = "";
			this.txtmanv.SelectedText = "";
			this.txtmanv.Size = new System.Drawing.Size(361, 48);
			this.txtmanv.TabIndex = 56;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(436, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(301, 29);
			this.label1.TabIndex = 61;
			this.label1.Text = "THÔNG TIN NHÂN VIÊN";
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
			this.label5.Size = new System.Drawing.Size(70, 20);
			this.label5.TabIndex = 51;
			this.label5.Text = "Chức vụ";
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
			this.label3.Size = new System.Drawing.Size(113, 20);
			this.label3.TabIndex = 49;
			this.label3.Text = "Tên nhân viên";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 20);
			this.label2.TabIndex = 48;
			this.label2.Text = "Mã nhân viên";
			// 
			// gbthongtinkh
			// 
			this.gbthongtinkh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbthongtinkh.Controls.Add(this.cmbgioitinh);
			this.gbthongtinkh.Controls.Add(this.txtsdtnv);
			this.gbthongtinkh.Controls.Add(this.txtchucvu);
			this.gbthongtinkh.Controls.Add(this.txttennv);
			this.gbthongtinkh.Controls.Add(this.txtmanv);
			this.gbthongtinkh.Controls.Add(this.label6);
			this.gbthongtinkh.Controls.Add(this.label5);
			this.gbthongtinkh.Controls.Add(this.label4);
			this.gbthongtinkh.Controls.Add(this.label3);
			this.gbthongtinkh.Controls.Add(this.label2);
			this.gbthongtinkh.Location = new System.Drawing.Point(55, 136);
			this.gbthongtinkh.Name = "gbthongtinkh";
			this.gbthongtinkh.Size = new System.Drawing.Size(1100, 226);
			this.gbthongtinkh.TabIndex = 63;
			this.gbthongtinkh.TabStop = false;
			// 
			// dgvnhanvien
			// 
			this.dgvnhanvien.AllowUserToAddRows = false;
			this.dgvnhanvien.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgvnhanvien.Location = new System.Drawing.Point(123, 525);
			this.dgvnhanvien.Name = "dgvnhanvien";
			this.dgvnhanvien.RowHeadersWidth = 51;
			this.dgvnhanvien.RowTemplate.Height = 24;
			this.dgvnhanvien.Size = new System.Drawing.Size(923, 223);
			this.dgvnhanvien.TabIndex = 62;
			this.dgvnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellClick);
			this.dgvnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaNhanVien";
			this.Column1.HeaderText = "Mã nhân viên";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TenNhanVien";
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
			this.Column4.DataPropertyName = "ChucVu";
			this.Column4.HeaderText = "Chức vụ";
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
			// frm_nhanvien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1211, 826);
			this.Controls.Add(this.gbchucnangkh);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gbthongtinkh);
			this.Controls.Add(this.dgvnhanvien);
			this.Name = "frm_nhanvien";
			this.Text = "frm_nhanvien";
			this.Load += new System.EventHandler(this.frm_nhanvien_Load);
			this.gbchucnangkh.ResumeLayout(false);
			this.gbthongtinkh.ResumeLayout(false);
			this.gbthongtinkh.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Button btntimkiem;
		private Guna.UI2.WinForms.Guna2Button btnnhaplai;
		private Guna.UI2.WinForms.Guna2Button btnthem;
		private Guna.UI2.WinForms.Guna2Button btnsua;
		private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
		private System.Windows.Forms.GroupBox gbchucnangkh;
		private Guna.UI2.WinForms.Guna2Button btnxoa;
		private Guna.UI2.WinForms.Guna2ComboBox cmbgioitinh;
		private Guna.UI2.WinForms.Guna2TextBox txtsdtnv;
		private Guna.UI2.WinForms.Guna2TextBox txtchucvu;
		private Guna.UI2.WinForms.Guna2TextBox txttennv;
		private Guna.UI2.WinForms.Guna2TextBox txtmanv;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gbthongtinkh;
		private System.Windows.Forms.DataGridView dgvnhanvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}