﻿namespace Form_ShopConCung
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
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.reportViewer1.Location = new System.Drawing.Point(13, 102);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1177, 688);
			this.reportViewer1.TabIndex = 0;
			// 
			// frm_indskhachhang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1202, 802);
			this.Controls.Add(this.reportViewer1);
			this.Name = "frm_indskhachhang";
			this.Text = "frm_indskhachhang";
			this.Load += new System.EventHandler(this.frm_indskhachhang_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}