namespace QLTV_Heni_4.Report
{
    partial class Rp_MuonQuaHan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.reportViewer1);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1143, 523);
            this.groupControl1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.bindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLTV_Heni_4.Report.Rp_MuonSachQuaHan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1139, 458);
            this.reportViewer1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtNhanVien);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1139, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(952, 10);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(145, 20);
            this.txtNhanVien.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(871, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nhân viên lập : ";
            // 
            // Rp_MuonQuaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "Rp_MuonQuaHan";
            this.Size = new System.Drawing.Size(1143, 523);
            this.Load += new System.EventHandler(this.Rp_MuonQuaHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
