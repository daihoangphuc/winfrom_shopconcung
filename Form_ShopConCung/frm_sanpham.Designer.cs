namespace Form_ShopConCung
{
	partial class frm_sanpham
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sanpham));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbmadanhmuc = new Guna.UI2.WinForms.Guna2ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txthinhanh = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtsldaban = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtsltrongkho = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtgiasp = new Guna.UI2.WinForms.Guna2TextBox();
			this.txttensp = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtmasp = new Guna.UI2.WinForms.Guna2TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lable300 = new System.Windows.Forms.Label();
			this.lable100 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnnhaplai = new Guna.UI2.WinForms.Guna2Button();
			this.btnthongke = new Guna.UI2.WinForms.Guna2Button();
			this.btnthem = new Guna.UI2.WinForms.Guna2Button();
			this.btntimkiem = new Guna.UI2.WinForms.Guna2Button();
			this.btnsua = new Guna.UI2.WinForms.Guna2Button();
			this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
			this.gbsearch = new System.Windows.Forms.GroupBox();
			this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.cmbthongke = new Guna.UI2.WinForms.Guna2ComboBox();
			this.dgvsanpham = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvthongke = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.gbsearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.flowLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(0, -18);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1145, 819);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmbmadanhmuc);
			this.groupBox3.Controls.Add(this.pictureBox1);
			this.groupBox3.Controls.Add(this.txthinhanh);
			this.groupBox3.Controls.Add(this.txtsldaban);
			this.groupBox3.Controls.Add(this.txtsltrongkho);
			this.groupBox3.Controls.Add(this.txtgiasp);
			this.groupBox3.Controls.Add(this.txttensp);
			this.groupBox3.Controls.Add(this.txtmasp);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.lable300);
			this.groupBox3.Controls.Add(this.lable100);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new System.Drawing.Point(77, 59);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1011, 246);
			this.groupBox3.TabIndex = 44;
			this.groupBox3.TabStop = false;
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// cmbmadanhmuc
			// 
			this.cmbmadanhmuc.BackColor = System.Drawing.Color.Transparent;
			this.cmbmadanhmuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbmadanhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbmadanhmuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbmadanhmuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbmadanhmuc.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbmadanhmuc.ForeColor = System.Drawing.Color.Black;
			this.cmbmadanhmuc.ItemHeight = 30;
			this.cmbmadanhmuc.Items.AddRange(new object[] {
            "DM001",
            "DM002",
            "DM003",
            "DM004",
            "DM005",
            "DM006",
            "DM007",
            "DM008",
            "DM009",
            "DM010"});
			this.cmbmadanhmuc.Location = new System.Drawing.Point(148, 192);
			this.cmbmadanhmuc.Name = "cmbmadanhmuc";
			this.cmbmadanhmuc.Size = new System.Drawing.Size(337, 36);
			this.cmbmadanhmuc.TabIndex = 70;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(834, 84);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 152);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 69;
			this.pictureBox1.TabStop = false;
			// 
			// txthinhanh
			// 
			this.txthinhanh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txthinhanh.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txthinhanh.DefaultText = "";
			this.txthinhanh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txthinhanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txthinhanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txthinhanh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txthinhanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txthinhanh.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txthinhanh.ForeColor = System.Drawing.Color.Black;
			this.txthinhanh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txthinhanh.Location = new System.Drawing.Point(491, 146);
			this.txthinhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txthinhanh.Multiline = true;
			this.txthinhanh.Name = "txthinhanh";
			this.txthinhanh.PasswordChar = '\0';
			this.txthinhanh.PlaceholderText = "";
			this.txthinhanh.SelectedText = "";
			this.txthinhanh.Size = new System.Drawing.Size(337, 90);
			this.txthinhanh.TabIndex = 68;
			// 
			// txtsldaban
			// 
			this.txtsldaban.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtsldaban.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtsldaban.DefaultText = "";
			this.txtsldaban.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtsldaban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtsldaban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsldaban.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsldaban.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsldaban.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtsldaban.ForeColor = System.Drawing.Color.Black;
			this.txtsldaban.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsldaban.Location = new System.Drawing.Point(664, 102);
			this.txtsldaban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtsldaban.Name = "txtsldaban";
			this.txtsldaban.PasswordChar = '\0';
			this.txtsldaban.PlaceholderText = "";
			this.txtsldaban.SelectedText = "";
			this.txtsldaban.Size = new System.Drawing.Size(164, 38);
			this.txtsldaban.TabIndex = 67;
			// 
			// txtsltrongkho
			// 
			this.txtsltrongkho.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtsltrongkho.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtsltrongkho.DefaultText = "";
			this.txtsltrongkho.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtsltrongkho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtsltrongkho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsltrongkho.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsltrongkho.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsltrongkho.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtsltrongkho.ForeColor = System.Drawing.Color.Black;
			this.txtsltrongkho.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsltrongkho.Location = new System.Drawing.Point(491, 102);
			this.txtsltrongkho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtsltrongkho.Name = "txtsltrongkho";
			this.txtsltrongkho.PasswordChar = '\0';
			this.txtsltrongkho.PlaceholderText = "";
			this.txtsltrongkho.SelectedText = "";
			this.txtsltrongkho.Size = new System.Drawing.Size(164, 38);
			this.txtsltrongkho.TabIndex = 66;
			// 
			// txtgiasp
			// 
			this.txtgiasp.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtgiasp.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtgiasp.DefaultText = "";
			this.txtgiasp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtgiasp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtgiasp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtgiasp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtgiasp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtgiasp.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtgiasp.ForeColor = System.Drawing.Color.Black;
			this.txtgiasp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtgiasp.Location = new System.Drawing.Point(148, 147);
			this.txtgiasp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtgiasp.Name = "txtgiasp";
			this.txtgiasp.PasswordChar = '\0';
			this.txtgiasp.PlaceholderText = "";
			this.txtgiasp.SelectedText = "";
			this.txtgiasp.Size = new System.Drawing.Size(337, 38);
			this.txtgiasp.TabIndex = 64;
			// 
			// txttensp
			// 
			this.txttensp.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txttensp.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttensp.DefaultText = "";
			this.txttensp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txttensp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txttensp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttensp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttensp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttensp.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txttensp.ForeColor = System.Drawing.Color.Black;
			this.txttensp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttensp.Location = new System.Drawing.Point(148, 102);
			this.txttensp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txttensp.Name = "txttensp";
			this.txttensp.PasswordChar = '\0';
			this.txttensp.PlaceholderText = "";
			this.txttensp.SelectedText = "";
			this.txttensp.Size = new System.Drawing.Size(337, 38);
			this.txttensp.TabIndex = 63;
			this.txttensp.TextChanged += new System.EventHandler(this.txttensp_TextChanged);
			// 
			// txtmasp
			// 
			this.txtmasp.Anchor = System.Windows.Forms.AnchorStyles.None;
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
			this.txtmasp.Location = new System.Drawing.Point(148, 57);
			this.txtmasp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtmasp.Name = "txtmasp";
			this.txtmasp.PasswordChar = '\0';
			this.txtmasp.PlaceholderText = "";
			this.txtmasp.SelectedText = "";
			this.txtmasp.Size = new System.Drawing.Size(337, 38);
			this.txtmasp.TabIndex = 62;
			this.txtmasp.TextChanged += new System.EventHandler(this.txtmasp_TextChanged);
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(0, 203);
			this.label7.Margin = new System.Windows.Forms.Padding(15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(115, 20);
			this.label7.TabIndex = 61;
			this.label7.Text = "Tên danh mục";
			// 
			// lable300
			// 
			this.lable300.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lable300.AutoSize = true;
			this.lable300.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lable300.Location = new System.Drawing.Point(879, 62);
			this.lable300.Margin = new System.Windows.Forms.Padding(15);
			this.lable300.Name = "lable300";
			this.lable300.Size = new System.Drawing.Size(76, 20);
			this.lable300.TabIndex = 60;
			this.lable300.Text = "Hình ảnh";
			// 
			// lable100
			// 
			this.lable100.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lable100.AutoSize = true;
			this.lable100.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lable100.Location = new System.Drawing.Point(709, 62);
			this.lable100.Margin = new System.Windows.Forms.Padding(15);
			this.lable100.Name = "lable100";
			this.lable100.Size = new System.Drawing.Size(62, 20);
			this.lable100.TabIndex = 59;
			this.lable100.Text = "Đã bán";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(525, 62);
			this.label5.Margin = new System.Windows.Forms.Padding(15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 20);
			this.label5.TabIndex = 58;
			this.label5.Text = "Trong kho";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(2, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 20);
			this.label4.TabIndex = 57;
			this.label4.Text = "Giá";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(2, 111);
			this.label3.Margin = new System.Windows.Forms.Padding(15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 20);
			this.label3.TabIndex = 56;
			this.label3.Text = "Tên sản phẩm";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(2, 62);
			this.label2.Margin = new System.Windows.Forms.Padding(15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 20);
			this.label2.TabIndex = 55;
			this.label2.Text = "Mã sản phẩm";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(333, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(294, 29);
			this.label1.TabIndex = 54;
			this.label1.Text = "THÔNG TIN SẢN PHẨM";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.flowLayoutPanel1.Controls.Add(this.groupBox2);
			this.flowLayoutPanel1.Controls.Add(this.gbsearch);
			this.flowLayoutPanel1.Controls.Add(this.cmbthongke);
			this.flowLayoutPanel1.Controls.Add(this.dgvsanpham);
			this.flowLayoutPanel1.Controls.Add(this.dgvthongke);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 311);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1011, 1000);
			this.flowLayoutPanel1.TabIndex = 43;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnnhaplai);
			this.groupBox2.Controls.Add(this.btnthongke);
			this.groupBox2.Controls.Add(this.btnthem);
			this.groupBox2.Controls.Add(this.btntimkiem);
			this.groupBox2.Controls.Add(this.btnsua);
			this.groupBox2.Controls.Add(this.btnxoa);
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1005, 82);
			this.groupBox2.TabIndex = 54;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức năng";
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
			this.btnnhaplai.FillColor = System.Drawing.Color.Thistle;
			this.btnnhaplai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnnhaplai.ForeColor = System.Drawing.Color.Black;
			this.btnnhaplai.Image = global::Form_ShopConCung.Properties.Resources.nhaplai;
			this.btnnhaplai.Location = new System.Drawing.Point(2, 21);
			this.btnnhaplai.Name = "btnnhaplai";
			this.btnnhaplai.Size = new System.Drawing.Size(156, 45);
			this.btnnhaplai.TabIndex = 53;
			this.btnnhaplai.Text = "Nhập lại";
			this.btnnhaplai.UseTransparentBackground = true;
			this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click_1);
			// 
			// btnthongke
			// 
			this.btnthongke.Animated = true;
			this.btnthongke.AutoRoundedCorners = true;
			this.btnthongke.BackColor = System.Drawing.Color.Transparent;
			this.btnthongke.BorderRadius = 21;
			this.btnthongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnthongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnthongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnthongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnthongke.FillColor = System.Drawing.Color.DarkGoldenrod;
			this.btnthongke.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnthongke.ForeColor = System.Drawing.Color.Black;
			this.btnthongke.Image = global::Form_ShopConCung.Properties.Resources.thongke;
			this.btnthongke.Location = new System.Drawing.Point(812, 21);
			this.btnthongke.Name = "btnthongke";
			this.btnthongke.Size = new System.Drawing.Size(156, 45);
			this.btnthongke.TabIndex = 53;
			this.btnthongke.Text = "Thống kê";
			this.btnthongke.UseTransparentBackground = true;
			this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
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
			this.btnthem.Image = global::Form_ShopConCung.Properties.Resources.them;
			this.btnthem.Location = new System.Drawing.Point(164, 21);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(156, 45);
			this.btnthem.TabIndex = 53;
			this.btnthem.Text = "Thêm";
			this.btnthem.UseTransparentBackground = true;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
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
			this.btntimkiem.Image = global::Form_ShopConCung.Properties.Resources.timkiem;
			this.btntimkiem.Location = new System.Drawing.Point(650, 21);
			this.btntimkiem.Name = "btntimkiem";
			this.btntimkiem.Size = new System.Drawing.Size(156, 45);
			this.btntimkiem.TabIndex = 53;
			this.btntimkiem.Text = "Tìm kiếm";
			this.btntimkiem.UseTransparentBackground = true;
			this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click_1);
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
			this.btnsua.Image = global::Form_ShopConCung.Properties.Resources.sua;
			this.btnsua.Location = new System.Drawing.Point(326, 21);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(156, 45);
			this.btnsua.TabIndex = 53;
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
			this.btnxoa.Image = global::Form_ShopConCung.Properties.Resources.xoa;
			this.btnxoa.Location = new System.Drawing.Point(488, 21);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(156, 45);
			this.btnxoa.TabIndex = 53;
			this.btnxoa.Text = "Xóa";
			this.btnxoa.UseTransparentBackground = true;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
			// 
			// gbsearch
			// 
			this.gbsearch.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.gbsearch.Controls.Add(this.txttimkiem);
			this.gbsearch.Location = new System.Drawing.Point(5, 93);
			this.gbsearch.Margin = new System.Windows.Forms.Padding(5);
			this.gbsearch.Name = "gbsearch";
			this.gbsearch.Padding = new System.Windows.Forms.Padding(0);
			this.gbsearch.Size = new System.Drawing.Size(1003, 54);
			this.gbsearch.TabIndex = 54;
			this.gbsearch.TabStop = false;
			this.gbsearch.Enter += new System.EventHandler(this.gbsearch_Enter);
			// 
			// txttimkiem
			// 
			this.txttimkiem.Animated = true;
			this.txttimkiem.AutoRoundedCorners = true;
			this.txttimkiem.BorderColor = System.Drawing.Color.Fuchsia;
			this.txttimkiem.BorderRadius = 21;
			this.txttimkiem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.txttimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttimkiem.DefaultText = "";
			this.txttimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txttimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txttimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txttimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.txttimkiem.ForeColor = System.Drawing.Color.Black;
			this.txttimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txttimkiem.IconRight = ((System.Drawing.Image)(resources.GetObject("txttimkiem.IconRight")));
			this.txttimkiem.Location = new System.Drawing.Point(0, 0);
			this.txttimkiem.Margin = new System.Windows.Forms.Padding(5);
			this.txttimkiem.Name = "txttimkiem";
			this.txttimkiem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.txttimkiem.PasswordChar = '\0';
			this.txttimkiem.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txttimkiem.PlaceholderText = "Tìm kiếm";
			this.txttimkiem.SelectedText = "";
			this.txttimkiem.Size = new System.Drawing.Size(995, 45);
			this.txttimkiem.TabIndex = 55;
			this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
			this.txttimkiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttimkiem_KeyPress);
			// 
			// cmbthongke
			// 
			this.cmbthongke.AutoRoundedCorners = true;
			this.cmbthongke.BackColor = System.Drawing.Color.Transparent;
			this.cmbthongke.BorderColor = System.Drawing.Color.Fuchsia;
			this.cmbthongke.BorderRadius = 17;
			this.cmbthongke.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbthongke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbthongke.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbthongke.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbthongke.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbthongke.ForeColor = System.Drawing.Color.Black;
			this.cmbthongke.ItemHeight = 30;
			this.cmbthongke.Items.AddRange(new object[] {
            "Số lượng sản phẩm",
            "Tổng giá trị sản phẩm",
            "Số lượng sản phẩm theo từng danh mục",
            "Sản phẩm tồn kho",
            "Sản phẩm bán chạy",
            "Doanh thu trong ngày"});
			this.cmbthongke.Location = new System.Drawing.Point(3, 155);
			this.cmbthongke.Name = "cmbthongke";
			this.cmbthongke.Size = new System.Drawing.Size(997, 36);
			this.cmbthongke.TabIndex = 53;
			this.cmbthongke.SelectedIndexChanged += new System.EventHandler(this.cmbthongke_SelectedIndexChanged_2);
			// 
			// dgvsanpham
			// 
			this.dgvsanpham.AllowUserToAddRows = false;
			this.dgvsanpham.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvsanpham.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvsanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
			this.dgvsanpham.Location = new System.Drawing.Point(3, 197);
			this.dgvsanpham.Name = "dgvsanpham";
			this.dgvsanpham.RowHeadersWidth = 51;
			this.dgvsanpham.RowTemplate.Height = 24;
			this.dgvsanpham.Size = new System.Drawing.Size(1008, 360);
			this.dgvsanpham.TabIndex = 25;
			this.dgvsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellClick_2);
			this.dgvsanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaSanPham";
			this.Column1.HeaderText = "Mã sản phẩm";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TenSanPham";
			this.Column2.HeaderText = "Tên sản phẩm";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Gia";
			this.Column3.HeaderText = "Giá";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "SoLuongTrongKho";
			this.Column4.HeaderText = "Số lượng trong kho";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "MaDanhMuc";
			this.Column5.HeaderText = "Mã  danh mục";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.Width = 125;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "SoLuongDaBan";
			this.Column6.HeaderText = "Số lượng đã bán";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.Width = 125;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "HinhAnh";
			this.Column7.HeaderText = "Hình ảnh";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.Width = 125;
			// 
			// dgvthongke
			// 
			this.dgvthongke.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvthongke.Location = new System.Drawing.Point(3, 563);
			this.dgvthongke.Name = "dgvthongke";
			this.dgvthongke.RowHeadersWidth = 51;
			this.dgvthongke.RowTemplate.Height = 24;
			this.dgvthongke.Size = new System.Drawing.Size(1008, 400);
			this.dgvthongke.TabIndex = 26;
			// 
			// frm_sanpham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1145, 953);
			this.Controls.Add(this.groupBox1);
			this.Name = "frm_sanpham";
			this.Text = "frm_sanpham";
			this.Load += new System.EventHandler(this.frm_sanpham_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.gbsearch.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
		private Guna.UI2.WinForms.Guna2ComboBox cmbthongke;
		private System.Windows.Forms.DataGridView dgvthongke;
		private System.Windows.Forms.DataGridView dgvsanpham;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private Guna.UI2.WinForms.Guna2Button btnnhaplai;
		private Guna.UI2.WinForms.Guna2Button btnthem;
		private Guna.UI2.WinForms.Guna2Button btnsua;
		private Guna.UI2.WinForms.Guna2Button btnxoa;
		private Guna.UI2.WinForms.Guna2Button btntimkiem;
		private Guna.UI2.WinForms.Guna2Button btnthongke;
		private System.Windows.Forms.GroupBox gbsearch;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2TextBox txthinhanh;
		private Guna.UI2.WinForms.Guna2TextBox txtsldaban;
		private Guna.UI2.WinForms.Guna2TextBox txtsltrongkho;
		private Guna.UI2.WinForms.Guna2TextBox txtgiasp;
		private Guna.UI2.WinForms.Guna2TextBox txttensp;
		private Guna.UI2.WinForms.Guna2TextBox txtmasp;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lable300;
		private System.Windows.Forms.Label lable100;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ComboBox cmbmadanhmuc;
	}
}