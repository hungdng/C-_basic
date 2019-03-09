namespace QLTV_Heni_4.Report
{
    partial class Rp_NhaXuatBan
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
            this.nXBSOSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTongSo = new System.Windows.Forms.ToolStripStatusLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.nXBSOSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSl.Properties)).BeginInit();
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
            this.groupControl1.Text = "Báo cáo danh sách nhà xuất bản";
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Tỗng số  :  ";
            // 
            // txtTongSo
            // 
            this.txtTongSo.ForeColor = System.Drawing.Color.Red;
            this.txtTongSo.Name = "txtTongSo";
            this.txtTongSo.Size = new System.Drawing.Size(0, 17);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nXBSOSACHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLTV_Heni_4.Report.Rp_NhaXuatBan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1139, 457);
            this.reportViewer1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSl);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtNhanVien);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1139, 43);
            this.panelControl1.TabIndex = 0;
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(76, 14);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(50, 20);
            this.txtSl.TabIndex = 9;
            this.txtSl.EditValueChanged += new System.EventHandler(this.txtSl_EditValueChanged);
            this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSl_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.Location = new System.Drawing.Point(134, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(229, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "nhà xuất bản có nhiều sách nhất trong thư viện";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Location = new System.Drawing.Point(16, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Report  top  ";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(946, 10);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(160, 20);
            this.txtNhanVien.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(865, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nhân viên lập : ";
            // 
            // Rp_NhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "Rp_NhaXuatBan";
            this.Size = new System.Drawing.Size(1143, 523);
            this.Load += new System.EventHandler(this.Rp_NhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nXBSOSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtTongSo;
        private System.Windows.Forms.TextBox txtNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource nXBSOSACHBindingSource;
        private DevExpress.XtraEditors.TextEdit txtSl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
