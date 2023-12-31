namespace Form_ShopConCung
{
	partial class frm_indssanpham
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
			this.btn_intheoluachon = new Guna.UI2.WinForms.Guna2Button();
			this.btn_in_toanbo = new Guna.UI2.WinForms.Guna2Button();
			this.cmbdanhmucin = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// btn_intheoluachon
			// 
			this.btn_intheoluachon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_intheoluachon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_intheoluachon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_intheoluachon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_intheoluachon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_intheoluachon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_intheoluachon.ForeColor = System.Drawing.Color.White;
			this.btn_intheoluachon.Location = new System.Drawing.Point(699, 72);
			this.btn_intheoluachon.Margin = new System.Windows.Forms.Padding(0);
			this.btn_intheoluachon.Name = "btn_intheoluachon";
			this.btn_intheoluachon.Size = new System.Drawing.Size(232, 45);
			this.btn_intheoluachon.TabIndex = 10;
			this.btn_intheoluachon.Text = "In theo lựa chọn";
			this.btn_intheoluachon.Click += new System.EventHandler(this.btn_intheoluachon_Click_1);
			// 
			// btn_in_toanbo
			// 
			this.btn_in_toanbo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_in_toanbo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_in_toanbo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_in_toanbo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_in_toanbo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_in_toanbo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_in_toanbo.ForeColor = System.Drawing.Color.White;
			this.btn_in_toanbo.Location = new System.Drawing.Point(350, 72);
			this.btn_in_toanbo.Name = "btn_in_toanbo";
			this.btn_in_toanbo.Size = new System.Drawing.Size(232, 45);
			this.btn_in_toanbo.TabIndex = 9;
			this.btn_in_toanbo.Text = "In toàn bộ";
			this.btn_in_toanbo.Click += new System.EventHandler(this.btn_in_toanbo_Click_1);
			// 
			// cmbdanhmucin
			// 
			this.cmbdanhmucin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmbdanhmucin.BackColor = System.Drawing.Color.Transparent;
			this.cmbdanhmucin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbdanhmucin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbdanhmucin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbdanhmucin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbdanhmucin.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbdanhmucin.ForeColor = System.Drawing.Color.Black;
			this.cmbdanhmucin.ItemHeight = 30;
			this.cmbdanhmucin.Items.AddRange(new object[] {
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
			this.cmbdanhmucin.Location = new System.Drawing.Point(350, 16);
			this.cmbdanhmucin.Name = "cmbdanhmucin";
			this.cmbdanhmucin.Size = new System.Drawing.Size(581, 36);
			this.cmbdanhmucin.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(89, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(255, 35);
			this.label1.TabIndex = 7;
			this.label1.Text = "In theo danh mục: ";
			// 
			// reportViewer1
			// 
			this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.reportViewer1.Location = new System.Drawing.Point(12, 132);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1153, 672);
			this.reportViewer1.TabIndex = 6;
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// frm_indssanpham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1177, 816);
			this.Controls.Add(this.btn_intheoluachon);
			this.Controls.Add(this.btn_in_toanbo);
			this.Controls.Add(this.cmbdanhmucin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.reportViewer1);
			this.Name = "frm_indssanpham";
			this.Text = "frm_indssanpham";
			this.Load += new System.EventHandler(this.frm_indssanpham_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Button btn_intheoluachon;
		private Guna.UI2.WinForms.Guna2Button btn_in_toanbo;
		private Guna.UI2.WinForms.Guna2ComboBox cmbdanhmucin;
		private System.Windows.Forms.Label label1;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}