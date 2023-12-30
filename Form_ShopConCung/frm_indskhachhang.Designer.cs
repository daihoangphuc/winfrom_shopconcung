namespace Form_ShopConCung
{
	partial class frm_indskhachhang
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
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.reportViewer1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1523, 812);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// reportViewer1
			// 
			this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.reportViewer1.Location = new System.Drawing.Point(28, 21);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1474, 771);
			this.reportViewer1.TabIndex = 1;
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// frm_indskhachhang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1547, 836);
			this.Controls.Add(this.groupBox1);
			this.Name = "frm_indskhachhang";
			this.Text = "frm_indskhachhang";
			this.Load += new System.EventHandler(this.frm_indskhachhang_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}