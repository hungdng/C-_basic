namespace QLTV_Heni_4.GUI
{
    partial class dsDocGia_LuotMuon
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
            this.grid_docgia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoaiDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmailDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLamThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LanMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDG = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDG = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_tile = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_docgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grid_docgia);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1143, 523);
            this.groupControl1.TabIndex = 1;
            // 
            // grid_docgia
            // 
            this.grid_docgia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_docgia.Location = new System.Drawing.Point(2, 157);
            this.grid_docgia.MainView = this.gridView1;
            this.grid_docgia.Name = "grid_docgia";
            this.grid_docgia.Size = new System.Drawing.Size(1139, 364);
            this.grid_docgia.TabIndex = 27;
            this.grid_docgia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDG,
            this.TenDG,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChiDG,
            this.DienThoaiDG,
            this.EmailDG,
            this.NgayLamThe,
            this.NgayHetHan,
            this.LanMuon});
            this.gridView1.GridControl = this.grid_docgia;
            this.gridView1.Name = "gridView1";
            // 
            // MaDG
            // 
            this.MaDG.Caption = "Mã ĐG";
            this.MaDG.FieldName = "MaDG";
            this.MaDG.Name = "MaDG";
            this.MaDG.Visible = true;
            this.MaDG.VisibleIndex = 0;
            this.MaDG.Width = 86;
            // 
            // TenDG
            // 
            this.TenDG.Caption = "Tên ĐG";
            this.TenDG.FieldName = "HoTenDG";
            this.TenDG.Name = "TenDG";
            this.TenDG.Visible = true;
            this.TenDG.VisibleIndex = 1;
            this.TenDG.Width = 254;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinhDG";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 2;
            this.GioiTinh.Width = 61;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.FieldName = "NgaySinhDG";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 3;
            this.NgaySinh.Width = 100;
            // 
            // DiaChiDG
            // 
            this.DiaChiDG.Caption = "Địa Chỉ ĐG";
            this.DiaChiDG.FieldName = "DiaChiDG";
            this.DiaChiDG.Name = "DiaChiDG";
            this.DiaChiDG.Visible = true;
            this.DiaChiDG.VisibleIndex = 5;
            this.DiaChiDG.Width = 128;
            // 
            // DienThoaiDG
            // 
            this.DienThoaiDG.Caption = "Điện Thoại ĐG";
            this.DienThoaiDG.FieldName = "DienThoaiDG";
            this.DienThoaiDG.Name = "DienThoaiDG";
            this.DienThoaiDG.Visible = true;
            this.DienThoaiDG.VisibleIndex = 4;
            this.DienThoaiDG.Width = 108;
            // 
            // EmailDG
            // 
            this.EmailDG.Caption = "Email ĐG";
            this.EmailDG.FieldName = "EmailDG";
            this.EmailDG.Name = "EmailDG";
            this.EmailDG.Visible = true;
            this.EmailDG.VisibleIndex = 6;
            this.EmailDG.Width = 121;
            // 
            // NgayLamThe
            // 
            this.NgayLamThe.Caption = "Ngày Làm Thẻ";
            this.NgayLamThe.FieldName = "NgayLamThe";
            this.NgayLamThe.Name = "NgayLamThe";
            this.NgayLamThe.Visible = true;
            this.NgayLamThe.VisibleIndex = 7;
            this.NgayLamThe.Width = 100;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.Caption = "Ngày Hết Hạn";
            this.NgayHetHan.FieldName = "NgayHetHan";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.Visible = true;
            this.NgayHetHan.VisibleIndex = 8;
            this.NgayHetHan.Width = 100;
            // 
            // LanMuon
            // 
            this.LanMuon.Caption = "Lượt mượn";
            this.LanMuon.FieldName = "LanMuon";
            this.LanMuon.Name = "LanMuon";
            this.LanMuon.Visible = true;
            this.LanMuon.VisibleIndex = 9;
            this.LanMuon.Width = 65;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtTenDG);
            this.panelControl1.Controls.Add(this.txtMaDG);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1139, 136);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(41, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Tên độc giả";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(41, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Mã độc giả";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(148, 100);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDG.Properties.Appearance.Options.UseFont = true;
            this.txtTenDG.Size = new System.Drawing.Size(159, 20);
            this.txtTenDG.TabIndex = 8;
            this.txtTenDG.EditValueChanged += new System.EventHandler(this.txtTenDG_EditValueChanged);
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(148, 73);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Properties.Appearance.Options.UseFont = true;
            this.txtMaDG.Size = new System.Drawing.Size(159, 20);
            this.txtMaDG.TabIndex = 7;
            this.txtMaDG.EditValueChanged += new System.EventHandler(this.txtMaDG_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(15, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 19);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Tìm kiếm nhanh";
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(407, 48);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(354, 2);
            this.panelControl2.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Location = new System.Drawing.Point(481, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(242, 28);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Lượt độc giả mượn sách";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txt_tile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1143, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(216, 17);
            this.toolStripStatusLabel1.Text = "Tỉ lệ Độc giả đã mượn / Tỗng độc giả :  ";
            // 
            // txt_tile
            // 
            this.txt_tile.ForeColor = System.Drawing.Color.Red;
            this.txt_tile.Name = "txt_tile";
            this.txt_tile.Size = new System.Drawing.Size(0, 17);
            // 
            // dsDocGia_LuotMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupControl1);
            this.Name = "dsDocGia_LuotMuon";
            this.Size = new System.Drawing.Size(1143, 523);
            this.Load += new System.EventHandler(this.dsDocGia_LuotMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_docgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grid_docgia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaDG;
        private DevExpress.XtraGrid.Columns.GridColumn TenDG;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiDG;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoaiDG;
        private DevExpress.XtraGrid.Columns.GridColumn EmailDG;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLamThe;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn LanMuon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTenDG;
        private DevExpress.XtraEditors.TextEdit txtMaDG;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txt_tile;
    }
}
