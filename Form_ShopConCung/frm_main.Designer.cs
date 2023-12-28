namespace Form_ShopConCung
{
	partial class frm_main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.danhMụcSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chiTiếtĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inDanhSáchKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inDanhSáchSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inDanhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gbdangnhap = new System.Windows.Forms.GroupBox();
			this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txtmatkhau = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btndangnhap = new Guna.UI2.WinForms.Guna2Button();
			this.txttaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
			this.btndangki = new Guna.UI2.WinForms.Guna2Button();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbdangnhap.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.inHóaĐơnToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(252, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// đăngNhậpToolStripMenuItem
			// 
			this.đăngNhậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
			this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
			this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
			this.đăngNhậpToolStripMenuItem.Text = "&Đăng nhập";
			this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Image = global::Form_ShopConCung.Properties.Resources.logout;
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
			this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// thoátToolStripMenuItem
			// 
			this.thoátToolStripMenuItem.Image = global::Form_ShopConCung.Properties.Resources.exit;
			this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
			this.thoátToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
			this.thoátToolStripMenuItem.Text = "Thoát";
			this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click_1);
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.danhMụcSảnPhẩmToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.đơnHàngToolStripMenuItem,
            this.chiTiếtĐơnHàngToolStripMenuItem});
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
			this.chứcNăngToolStripMenuItem.Text = "&Chức năng";
			this.chứcNăngToolStripMenuItem.Click += new System.EventHandler(this.chứcNăngToolStripMenuItem_Click);
			// 
			// kháchHàngToolStripMenuItem
			// 
			this.kháchHàngToolStripMenuItem.Image = global::Form_ShopConCung.Properties.Resources.customer;
			this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
			this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
			this.kháchHàngToolStripMenuItem.Text = "&Khách hàng";
			this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
			// 
			// danhMụcSảnPhẩmToolStripMenuItem
			// 
			this.danhMụcSảnPhẩmToolStripMenuItem.Image = global::Form_ShopConCung.Properties.Resources.category;
			this.danhMụcSảnPhẩmToolStripMenuItem.Name = "danhMụcSảnPhẩmToolStripMenuItem";
			this.danhMụcSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
			this.danhMụcSảnPhẩmToolStripMenuItem.Text = "&Danh mục sản phẩm";
			this.danhMụcSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.danhMụcSảnPhẩmToolStripMenuItem_Click);
			// 
			// sảnPhẩmToolStripMenuItem
			// 
			this.sảnPhẩmToolStripMenuItem.Image = global::Form_ShopConCung.Properties.Resources.product;
			this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
			this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
			this.sảnPhẩmToolStripMenuItem.Text = "&Sản phẩm";
			this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
			// 
			// đơnHàngToolStripMenuItem
			// 
			this.đơnHàngToolStripMenuItem.Image = global::Form_ShopConCung.Properties.Resources.donhang;
			this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
			this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
			this.đơnHàngToolStripMenuItem.Text = "&Đơn hàng";
			this.đơnHàngToolStripMenuItem.Click += new System.EventHandler(this.đơnHàngToolStripMenuItem_Click);
			// 
			// chiTiếtĐơnHàngToolStripMenuItem
			// 
			this.chiTiếtĐơnHàngToolStripMenuItem.Image = global::Form_ShopConCung.Properties.Resources.chitietdonhang;
			this.chiTiếtĐơnHàngToolStripMenuItem.Name = "chiTiếtĐơnHàngToolStripMenuItem";
			this.chiTiếtĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
			this.chiTiếtĐơnHàngToolStripMenuItem.Text = "&Chi tiết đơn hàng";
			this.chiTiếtĐơnHàngToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtĐơnHàngToolStripMenuItem_Click);
			// 
			// inHóaĐơnToolStripMenuItem
			// 
			this.inHóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inDanhSáchKháchHàngToolStripMenuItem,
            this.inDanhSáchSảnPhẩmToolStripMenuItem,
            this.inDanhSáchNhânViênToolStripMenuItem});
			this.inHóaĐơnToolStripMenuItem.Name = "inHóaĐơnToolStripMenuItem";
			this.inHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.inHóaĐơnToolStripMenuItem.Text = "&In ấn";
			this.inHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.inHóaĐơnToolStripMenuItem_Click);
			// 
			// inDanhSáchKháchHàngToolStripMenuItem
			// 
			this.inDanhSáchKháchHàngToolStripMenuItem.Name = "inDanhSáchKháchHàngToolStripMenuItem";
			this.inDanhSáchKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
			this.inDanhSáchKháchHàngToolStripMenuItem.Text = "In Danh Sách Khách Hàng";
			this.inDanhSáchKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.inDanhSáchKháchHàngToolStripMenuItem_Click);
			// 
			// inDanhSáchSảnPhẩmToolStripMenuItem
			// 
			this.inDanhSáchSảnPhẩmToolStripMenuItem.Name = "inDanhSáchSảnPhẩmToolStripMenuItem";
			this.inDanhSáchSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
			this.inDanhSáchSảnPhẩmToolStripMenuItem.Text = "In Danh Sách Sản Phẩm";
			this.inDanhSáchSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.inDanhSáchSảnPhẩmToolStripMenuItem_Click);
			// 
			// inDanhSáchNhânViênToolStripMenuItem
			// 
			this.inDanhSáchNhânViênToolStripMenuItem.Name = "inDanhSáchNhânViênToolStripMenuItem";
			this.inDanhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
			this.inDanhSáchNhânViênToolStripMenuItem.Text = "In Danh Sách Nhân Viên";
			this.inDanhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.inDanhSáchNhânViênToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.Controls.Add(this.gbdangnhap);
			this.panel1.Location = new System.Drawing.Point(0, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1043, 652);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// gbdangnhap
			// 
			this.gbdangnhap.Controls.Add(this.guna2ImageButton1);
			this.gbdangnhap.Controls.Add(this.label1);
			this.gbdangnhap.Controls.Add(this.txtmatkhau);
			this.gbdangnhap.Controls.Add(this.label4);
			this.gbdangnhap.Controls.Add(this.btndangnhap);
			this.gbdangnhap.Controls.Add(this.txttaikhoan);
			this.gbdangnhap.Controls.Add(this.btndangki);
			this.gbdangnhap.Controls.Add(this.label3);
			this.gbdangnhap.Location = new System.Drawing.Point(76, 58);
			this.gbdangnhap.Name = "gbdangnhap";
			this.gbdangnhap.Size = new System.Drawing.Size(896, 484);
			this.gbdangnhap.TabIndex = 71;
			this.gbdangnhap.TabStop = false;
			this.gbdangnhap.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// guna2ImageButton1
			// 
			this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(200, 119);
			this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
			this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton1.ImageRotate = 0F;
			this.guna2ImageButton1.ImageSize = new System.Drawing.Size(200, 119);
			this.guna2ImageButton1.Location = new System.Drawing.Point(376, 126);
			this.guna2ImageButton1.Name = "guna2ImageButton1";
			this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(199, 118);
			this.guna2ImageButton1.Size = new System.Drawing.Size(200, 140);
			this.guna2ImageButton1.TabIndex = 86;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
			this.label1.Location = new System.Drawing.Point(231, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(450, 49);
			this.label1.TabIndex = 85;
			this.label1.Text = "Đăng nhập hệ thống";
			// 
			// txtmatkhau
			// 
			this.txtmatkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
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
			this.txtmatkhau.Location = new System.Drawing.Point(306, 319);
			this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmatkhau.Name = "txtmatkhau";
			this.txtmatkhau.PasswordChar = '*';
			this.txtmatkhau.PlaceholderText = "";
			this.txtmatkhau.SelectedText = "";
			this.txtmatkhau.Size = new System.Drawing.Size(431, 38);
			this.txtmatkhau.TabIndex = 84;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(160, 278);
			this.label4.Margin = new System.Windows.Forms.Padding(15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 20);
			this.label4.TabIndex = 81;
			this.label4.Text = "Tài khoản";
			// 
			// btndangnhap
			// 
			this.btndangnhap.Animated = true;
			this.btndangnhap.AutoRoundedCorners = true;
			this.btndangnhap.BackColor = System.Drawing.Color.Transparent;
			this.btndangnhap.BorderRadius = 21;
			this.btndangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btndangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btndangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btndangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btndangnhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
			this.btndangnhap.ForeColor = System.Drawing.Color.Black;
			this.btndangnhap.Image = global::Form_ShopConCung.Properties.Resources.login;
			this.btndangnhap.Location = new System.Drawing.Point(376, 383);
			this.btndangnhap.Name = "btndangnhap";
			this.btndangnhap.Size = new System.Drawing.Size(156, 45);
			this.btndangnhap.TabIndex = 79;
			this.btndangnhap.Text = "Đăng nhập";
			this.btndangnhap.UseTransparentBackground = true;
			this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
			// 
			// txttaikhoan
			// 
			this.txttaikhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txttaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttaikhoan.DefaultText = "";
			this.txttaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txttaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txttaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttaikhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txttaikhoan.ForeColor = System.Drawing.Color.Black;
			this.txttaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttaikhoan.Location = new System.Drawing.Point(306, 273);
			this.txttaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txttaikhoan.Name = "txttaikhoan";
			this.txttaikhoan.PasswordChar = '\0';
			this.txttaikhoan.PlaceholderText = "";
			this.txttaikhoan.SelectedText = "";
			this.txttaikhoan.Size = new System.Drawing.Size(431, 38);
			this.txttaikhoan.TabIndex = 83;
			// 
			// btndangki
			// 
			this.btndangki.Animated = true;
			this.btndangki.AutoRoundedCorners = true;
			this.btndangki.BackColor = System.Drawing.Color.Transparent;
			this.btndangki.BorderRadius = 21;
			this.btndangki.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btndangki.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btndangki.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btndangki.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btndangki.FillColor = System.Drawing.Color.LimeGreen;
			this.btndangki.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
			this.btndangki.ForeColor = System.Drawing.Color.Black;
			this.btndangki.Image = global::Form_ShopConCung.Properties.Resources.register;
			this.btndangki.Location = new System.Drawing.Point(538, 383);
			this.btndangki.Name = "btndangki";
			this.btndangki.Size = new System.Drawing.Size(156, 45);
			this.btndangki.TabIndex = 80;
			this.btndangki.Text = "Đăng kí";
			this.btndangki.UseTransparentBackground = true;
			this.btndangki.Click += new System.EventHandler(this.btndangki_Click_1);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(160, 324);
			this.label3.Margin = new System.Windows.Forms.Padding(15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 82;
			this.label3.Text = "Mật khẩu";
			// 
			// frm_main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 680);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frm_main";
			this.Text = "FormTrangChu";
			this.Load += new System.EventHandler(this.frm_main_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.gbdangnhap.ResumeLayout(false);
			this.gbdangnhap.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inHóaĐơnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem danhMụcSảnPhẩmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chiTiếtĐơnHàngToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
		private System.Windows.Forms.GroupBox gbdangnhap;
		private Guna.UI2.WinForms.Guna2TextBox txtmatkhau;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2Button btndangnhap;
		private Guna.UI2.WinForms.Guna2TextBox txttaikhoan;
		private Guna.UI2.WinForms.Guna2Button btndangki;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
		private System.Windows.Forms.ToolStripMenuItem inDanhSáchKháchHàngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inDanhSáchSảnPhẩmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inDanhSáchNhânViênToolStripMenuItem;
	}
}