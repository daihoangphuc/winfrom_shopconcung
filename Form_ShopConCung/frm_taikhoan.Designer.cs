﻿namespace Form_ShopConCung
{
	partial class frm_taikhoan
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
			this.label2 = new System.Windows.Forms.Label();
			this.gbchucnangkh = new System.Windows.Forms.GroupBox();
			this.btntimkiem = new Guna.UI2.WinForms.Guna2Button();
			this.btnnhaplai = new Guna.UI2.WinForms.Guna2Button();
			this.btnthem = new Guna.UI2.WinForms.Guna2Button();
			this.btnsua = new Guna.UI2.WinForms.Guna2Button();
			this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
			this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbquyen = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtmakh = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtmatkhau = new Guna.UI2.WinForms.Guna2TextBox();
			this.txttentk = new Guna.UI2.WinForms.Guna2TextBox();
			this.gbthongtinkh = new System.Windows.Forms.GroupBox();
			this.txtmanv = new Guna.UI2.WinForms.Guna2TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtmatk = new Guna.UI2.WinForms.Guna2TextBox();
			this.dgvtttaikhoan = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbchucnangkh.SuspendLayout();
			this.gbthongtinkh.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvtttaikhoan)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 20);
			this.label2.TabIndex = 48;
			this.label2.Text = "Mã tài khoản";
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
			this.gbchucnangkh.Location = new System.Drawing.Point(179, 365);
			this.gbchucnangkh.Name = "gbchucnangkh";
			this.gbchucnangkh.Size = new System.Drawing.Size(767, 141);
			this.gbchucnangkh.TabIndex = 68;
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
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(530, 111);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 20);
			this.label6.TabIndex = 52;
			this.label6.Text = "Mã khách hàng";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(530, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 20);
			this.label5.TabIndex = 51;
			this.label5.Text = "Mật khẩu";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 20);
			this.label4.TabIndex = 50;
			this.label4.Text = "Quyền";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 20);
			this.label3.TabIndex = 49;
			this.label3.Text = "Tên tài khoản";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(418, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 29);
			this.label1.TabIndex = 65;
			this.label1.Text = "THÔNG TIN TÀI KHOẢN";
			// 
			// cmbquyen
			// 
			this.cmbquyen.BackColor = System.Drawing.Color.Transparent;
			this.cmbquyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbquyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbquyen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbquyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbquyen.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbquyen.ForeColor = System.Drawing.Color.Black;
			this.cmbquyen.ItemHeight = 30;
			this.cmbquyen.Items.AddRange(new object[] {
            "0",
            "1"});
			this.cmbquyen.Location = new System.Drawing.Point(163, 151);
			this.cmbquyen.Name = "cmbquyen";
			this.cmbquyen.Size = new System.Drawing.Size(361, 36);
			this.cmbquyen.TabIndex = 57;
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
			this.txtmakh.Location = new System.Drawing.Point(689, 96);
			this.txtmakh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmakh.Name = "txtmakh";
			this.txtmakh.PasswordChar = '\0';
			this.txtmakh.PlaceholderText = "";
			this.txtmakh.SelectedText = "";
			this.txtmakh.Size = new System.Drawing.Size(361, 48);
			this.txtmakh.TabIndex = 53;
			// 
			// txtmatkhau
			// 
			this.txtmatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtmatkhau.DefaultText = "";
			this.txtmatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtmatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtmatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtmatkhau.ForeColor = System.Drawing.Color.Black;
			this.txtmatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmatkhau.Location = new System.Drawing.Point(689, 40);
			this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmatkhau.Name = "txtmatkhau";
			this.txtmatkhau.PasswordChar = '\0';
			this.txtmatkhau.PlaceholderText = "";
			this.txtmatkhau.SelectedText = "";
			this.txtmatkhau.Size = new System.Drawing.Size(361, 48);
			this.txtmatkhau.TabIndex = 54;
			// 
			// txttentk
			// 
			this.txttentk.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttentk.DefaultText = "";
			this.txttentk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txttentk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txttentk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttentk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttentk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttentk.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txttentk.ForeColor = System.Drawing.Color.Black;
			this.txttentk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttentk.Location = new System.Drawing.Point(163, 96);
			this.txttentk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txttentk.Name = "txttentk";
			this.txttentk.PasswordChar = '\0';
			this.txttentk.PlaceholderText = "";
			this.txttentk.SelectedText = "";
			this.txttentk.Size = new System.Drawing.Size(361, 48);
			this.txttentk.TabIndex = 55;
			// 
			// gbthongtinkh
			// 
			this.gbthongtinkh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbthongtinkh.Controls.Add(this.cmbquyen);
			this.gbthongtinkh.Controls.Add(this.txtmanv);
			this.gbthongtinkh.Controls.Add(this.txtmakh);
			this.gbthongtinkh.Controls.Add(this.txtmatkhau);
			this.gbthongtinkh.Controls.Add(this.txttentk);
			this.gbthongtinkh.Controls.Add(this.label7);
			this.gbthongtinkh.Controls.Add(this.txtmatk);
			this.gbthongtinkh.Controls.Add(this.label6);
			this.gbthongtinkh.Controls.Add(this.label5);
			this.gbthongtinkh.Controls.Add(this.label4);
			this.gbthongtinkh.Controls.Add(this.label3);
			this.gbthongtinkh.Controls.Add(this.label2);
			this.gbthongtinkh.Location = new System.Drawing.Point(37, 123);
			this.gbthongtinkh.Name = "gbthongtinkh";
			this.gbthongtinkh.Size = new System.Drawing.Size(1100, 226);
			this.gbthongtinkh.TabIndex = 67;
			this.gbthongtinkh.TabStop = false;
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
			this.txtmanv.Location = new System.Drawing.Point(689, 151);
			this.txtmanv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmanv.Name = "txtmanv";
			this.txtmanv.PasswordChar = '\0';
			this.txtmanv.PlaceholderText = "";
			this.txtmanv.SelectedText = "";
			this.txtmanv.Size = new System.Drawing.Size(361, 48);
			this.txtmanv.TabIndex = 53;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(530, 166);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(108, 20);
			this.label7.TabIndex = 52;
			this.label7.Text = "Mã nhân viên";
			// 
			// txtmatk
			// 
			this.txtmatk.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtmatk.DefaultText = "";
			this.txtmatk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtmatk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtmatk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmatk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtmatk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmatk.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtmatk.ForeColor = System.Drawing.Color.Black;
			this.txtmatk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtmatk.Location = new System.Drawing.Point(163, 40);
			this.txtmatk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmatk.Name = "txtmatk";
			this.txtmatk.PasswordChar = '\0';
			this.txtmatk.PlaceholderText = "";
			this.txtmatk.SelectedText = "";
			this.txtmatk.Size = new System.Drawing.Size(361, 48);
			this.txtmatk.TabIndex = 56;
			// 
			// dgvtttaikhoan
			// 
			this.dgvtttaikhoan.AllowUserToAddRows = false;
			this.dgvtttaikhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvtttaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvtttaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.MaNhanVien});
			this.dgvtttaikhoan.Location = new System.Drawing.Point(105, 512);
			this.dgvtttaikhoan.Name = "dgvtttaikhoan";
			this.dgvtttaikhoan.RowHeadersWidth = 51;
			this.dgvtttaikhoan.RowTemplate.Height = 24;
			this.dgvtttaikhoan.Size = new System.Drawing.Size(923, 223);
			this.dgvtttaikhoan.TabIndex = 66;
			this.dgvtttaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtttaikhoan_CellClick);
			this.dgvtttaikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtttaikhoan_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "idtaikhoan";
			this.Column1.HeaderText = "Mã tài khoản";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "taikhoan";
			this.Column2.HeaderText = "Tên tài khoản";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "matkhau";
			this.Column3.HeaderText = "Mật khẩu";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "quyen";
			this.Column4.HeaderText = "Quyền";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "MaNhanVien";
			this.Column5.HeaderText = "Mã nhân viên";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.Width = 125;
			// 
			// MaNhanVien
			// 
			this.MaNhanVien.DataPropertyName = "MaKhachHang";
			this.MaNhanVien.HeaderText = "Mã khách hàng";
			this.MaNhanVien.MinimumWidth = 6;
			this.MaNhanVien.Name = "MaNhanVien";
			this.MaNhanVien.Width = 125;
			// 
			// frm_taikhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1174, 800);
			this.Controls.Add(this.gbchucnangkh);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gbthongtinkh);
			this.Controls.Add(this.dgvtttaikhoan);
			this.Name = "frm_taikhoan";
			this.Text = "frm_taikhoan";
			this.Load += new System.EventHandler(this.frm_taikhoan_Load);
			this.gbchucnangkh.ResumeLayout(false);
			this.gbthongtinkh.ResumeLayout(false);
			this.gbthongtinkh.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvtttaikhoan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gbchucnangkh;
		private Guna.UI2.WinForms.Guna2Button btntimkiem;
		private Guna.UI2.WinForms.Guna2Button btnnhaplai;
		private Guna.UI2.WinForms.Guna2Button btnthem;
		private Guna.UI2.WinForms.Guna2Button btnsua;
		private Guna.UI2.WinForms.Guna2Button btnxoa;
		private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ComboBox cmbquyen;
		private Guna.UI2.WinForms.Guna2TextBox txtmakh;
		private Guna.UI2.WinForms.Guna2TextBox txtmatkhau;
		private Guna.UI2.WinForms.Guna2TextBox txttentk;
		private System.Windows.Forms.GroupBox gbthongtinkh;
		private Guna.UI2.WinForms.Guna2TextBox txtmanv;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2TextBox txtmatk;
		private System.Windows.Forms.DataGridView dgvtttaikhoan;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
	}
}