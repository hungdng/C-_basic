namespace QLTV_Heni_4.Report
{
    partial class Rp_NhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTongSo = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.statusStrip1);
            this.groupControl1.Controls.Add(this.reportViewer1);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1143, 523);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách nhân viên thư viện";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nHANVIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLTV_Heni_4.Report.Rp_NhanVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1139, 459);
            this.reportViewer1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtNhanVien);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1139, 41);
            this.panelControl1.TabIndex = 0;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(947, 11);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(160, 20);
            this.txtNhanVien.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(866, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Nhân viên lập : ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtTongSo});
            this.statusStrip1.Location = new System.Drawing.Point(2, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1139, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Tỗng số";
            // 
            // txtTongSo
            // 
            this.txtTongSo.ForeColor = System.Drawing.Color.Red;
            this.txtTongSo.Name = "txtTongSo";
            this.txtTongSo.Size = new System.Drawing.Size(118, 17);
            this.txtTongSo.Text = "toolStripStatusLabel2";
            // 
            // Rp_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "Rp_NhanVien";
            this.Size = new System.Drawing.Size(1143, 523);
            this.Load += new System.EventHandler(this.Rp_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtTongSo;
    }
}
