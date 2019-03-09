namespace QLTV_Heni_4.Report
{
    partial class Rp_TuaSach
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.reportTuaSach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtSl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.bindingTuaSach = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTongSo = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingTuaSach)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.statusStrip1);
            this.groupControl1.Controls.Add(this.reportTuaSach);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1143, 523);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Báo cáo về thông tin tựa sách";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtNhanVien);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtSl);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1139, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // reportTuaSach
            // 
            this.reportTuaSach.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.bindingTuaSach;
            this.reportTuaSach.LocalReport.DataSources.Add(reportDataSource2);
            this.reportTuaSach.LocalReport.ReportEmbeddedResource = "QLTV_Heni_4.Report.Rp_TuaSach.rdlc";
            this.reportTuaSach.Location = new System.Drawing.Point(2, 67);
            this.reportTuaSach.Name = "reportTuaSach";
            this.reportTuaSach.Size = new System.Drawing.Size(1139, 454);
            this.reportTuaSach.TabIndex = 1;
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(75, 17);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(50, 20);
            this.txtSl.TabIndex = 5;
            this.txtSl.EditValueChanged += new System.EventHandler(this.txtSl_EditValueChanged);
            this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSl_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.Location = new System.Drawing.Point(133, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(133, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "sách được mượn nhiều nhất";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Location = new System.Drawing.Point(28, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Report  ";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(968, 14);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(145, 20);
            this.txtNhanVien.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(887, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 6;
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Tỗng số  :  ";
            // 
            // txtTongSo
            // 
            this.txtTongSo.ForeColor = System.Drawing.Color.Red;
            this.txtTongSo.Name = "txtTongSo";
            this.txtTongSo.Size = new System.Drawing.Size(118, 17);
            this.txtTongSo.Text = "toolStripStatusLabel2";
            // 
            // Rp_TuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "Rp_TuaSach";
            this.Size = new System.Drawing.Size(1143, 523);
            this.Load += new System.EventHandler(this.Rp_TuaSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingTuaSach)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Microsoft.Reporting.WinForms.ReportViewer reportTuaSach;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtSl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource bindingTuaSach;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtTongSo;
    }
}
