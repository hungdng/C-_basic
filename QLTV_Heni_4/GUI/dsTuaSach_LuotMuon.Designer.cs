namespace QLTV_Heni_4.GUI
{
    partial class dsTuaSach_LuotMuon
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grid_tuasach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTuaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TuaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TuSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NDTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tong_LanMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_tile = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTS = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tuasach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTS.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grid_tuasach);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1143, 523);
            this.groupControl1.TabIndex = 0;
            // 
            // grid_tuasach
            // 
            this.grid_tuasach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_tuasach.Location = new System.Drawing.Point(2, 157);
            this.grid_tuasach.MainView = this.gridView1;
            this.grid_tuasach.Name = "grid_tuasach";
            this.grid_tuasach.Size = new System.Drawing.Size(1139, 364);
            this.grid_tuasach.TabIndex = 7;
            this.grid_tuasach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTuaSach,
            this.TuaSach,
            this.TenTL,
            this.TuSach,
            this.NDTT,
            this.Tong_LanMuon});
            this.gridView1.GridControl = this.grid_tuasach;
            this.gridView1.Name = "gridView1";
            // 
            // MaTuaSach
            // 
            this.MaTuaSach.Caption = "Mã tựa sách";
            this.MaTuaSach.FieldName = "MaTuaSach";
            this.MaTuaSach.Name = "MaTuaSach";
            this.MaTuaSach.Visible = true;
            this.MaTuaSach.VisibleIndex = 0;
            this.MaTuaSach.Width = 85;
            // 
            // TuaSach
            // 
            this.TuaSach.Caption = "Tựa sách";
            this.TuaSach.FieldName = "TuaSach";
            this.TuaSach.Name = "TuaSach";
            this.TuaSach.Visible = true;
            this.TuaSach.VisibleIndex = 1;
            this.TuaSach.Width = 139;
            // 
            // TenTL
            // 
            this.TenTL.Caption = "Thể loại";
            this.TenTL.FieldName = "TenTL";
            this.TenTL.Name = "TenTL";
            this.TenTL.Visible = true;
            this.TenTL.VisibleIndex = 2;
            this.TenTL.Width = 89;
            // 
            // TuSach
            // 
            this.TuSach.Caption = "Tủ sách";
            this.TuSach.FieldName = "TuSach";
            this.TuSach.Name = "TuSach";
            this.TuSach.Visible = true;
            this.TuSach.VisibleIndex = 3;
            // 
            // NDTT
            // 
            this.NDTT.Caption = "Tóm tắt nội dung";
            this.NDTT.FieldName = "NDTT";
            this.NDTT.Name = "NDTT";
            this.NDTT.Visible = true;
            this.NDTT.VisibleIndex = 4;
            this.NDTT.Width = 194;
            // 
            // Tong_LanMuon
            // 
            this.Tong_LanMuon.Caption = "Tỗng lần mượn";
            this.Tong_LanMuon.FieldName = "Tong_LanMuon";
            this.Tong_LanMuon.Name = "Tong_LanMuon";
            this.Tong_LanMuon.Visible = true;
            this.Tong_LanMuon.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtTS);
            this.panelControl1.Controls.Add(this.txtMaTS);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1139, 136);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(426, 48);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(335, 2);
            this.panelControl2.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Location = new System.Drawing.Point(517, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(164, 28);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Lượt mượn sách";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txt_tile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1143, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(223, 17);
            this.toolStripStatusLabel1.Text = "Tựa sách được mượn / Tỗng tựa sách :    ";
            // 
            // txt_tile
            // 
            this.txt_tile.ForeColor = System.Drawing.Color.Red;
            this.txt_tile.Name = "txt_tile";
            this.txt_tile.Size = new System.Drawing.Size(0, 17);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(54, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Tựa sách";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(54, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Mã tựa sách";
            // 
            // txtTS
            // 
            this.txtTS.Location = new System.Drawing.Point(161, 100);
            this.txtTS.Name = "txtTS";
            this.txtTS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTS.Properties.Appearance.Options.UseFont = true;
            this.txtTS.Size = new System.Drawing.Size(159, 20);
            this.txtTS.TabIndex = 13;
            // 
            // txtMaTS
            // 
            this.txtMaTS.Location = new System.Drawing.Point(161, 73);
            this.txtMaTS.Name = "txtMaTS";
            this.txtMaTS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTS.Properties.Appearance.Options.UseFont = true;
            this.txtMaTS.Size = new System.Drawing.Size(159, 20);
            this.txtMaTS.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(28, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 19);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Tìm kiếm nhanh";
            // 
            // dsTuaSach_LuotMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupControl1);
            this.Name = "dsTuaSach_LuotMuon";
            this.Size = new System.Drawing.Size(1143, 523);
            this.Load += new System.EventHandler(this.dsTuaSach_LuotMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tuasach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTS.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grid_tuasach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaTuaSach;
        private DevExpress.XtraGrid.Columns.GridColumn TuaSach;
        private DevExpress.XtraGrid.Columns.GridColumn TenTL;
        private DevExpress.XtraGrid.Columns.GridColumn TuSach;
        private DevExpress.XtraGrid.Columns.GridColumn NDTT;
        private DevExpress.XtraGrid.Columns.GridColumn Tong_LanMuon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txt_tile;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTS;
        private DevExpress.XtraEditors.TextEdit txtMaTS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
