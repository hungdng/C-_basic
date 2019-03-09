namespace QLTV_Heni_4.GUI
{
    partial class tkNhaXuatBan
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
            this.splitContainerControlWin641 = new DevExpress.XtraCharts.Wizard.SplitContainerControlWin64();
            this.grid_sach = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTuaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TuaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NDTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_nxb = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TuaSach = new System.Windows.Forms.TextBox();
            this.txt_MaTuaSach = new System.Windows.Forms.TextBox();
            this.txt_NDTT = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNXB = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNXB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grid_nxb = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoaiNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Website = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).BeginInit();
            this.splitContainerControlWin641.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nxb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.splitContainerControlWin641);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1146, 540);
            this.groupControl1.TabIndex = 2;
            // 
            // splitContainerControlWin641
            // 
            this.splitContainerControlWin641.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlWin641.Location = new System.Drawing.Point(2, 261);
            this.splitContainerControlWin641.Name = "splitContainerControlWin641";
            this.splitContainerControlWin641.Panel1.Controls.Add(this.grid_nxb);
            this.splitContainerControlWin641.Panel1.Text = "Panel1";
            this.splitContainerControlWin641.Panel2.Controls.Add(this.grid_sach);
            this.splitContainerControlWin641.Panel2.Text = "Panel2";
            this.splitContainerControlWin641.Size = new System.Drawing.Size(1142, 277);
            this.splitContainerControlWin641.SplitterPosition = 744;
            this.splitContainerControlWin641.TabIndex = 1;
            this.splitContainerControlWin641.Text = "splitContainerControlWin641";
            // 
            // grid_sach
            // 
            this.grid_sach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_sach.Location = new System.Drawing.Point(0, 0);
            this.grid_sach.MainView = this.gridView2;
            this.grid_sach.Name = "grid_sach";
            this.grid_sach.Size = new System.Drawing.Size(393, 277);
            this.grid_sach.TabIndex = 0;
            this.grid_sach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTuaSach,
            this.TuaSach,
            this.NDTT});
            this.gridView2.GridControl = this.grid_sach;
            this.gridView2.Name = "gridView2";
            // 
            // MaTuaSach
            // 
            this.MaTuaSach.Caption = "Mã tựa sách";
            this.MaTuaSach.FieldName = "MaTuaSach";
            this.MaTuaSach.Name = "MaTuaSach";
            this.MaTuaSach.Visible = true;
            this.MaTuaSach.VisibleIndex = 0;
            this.MaTuaSach.Width = 79;
            // 
            // TuaSach
            // 
            this.TuaSach.Caption = "Tựa sách";
            this.TuaSach.FieldName = "TuaSach";
            this.TuaSach.Name = "TuaSach";
            this.TuaSach.Visible = true;
            this.TuaSach.VisibleIndex = 1;
            this.TuaSach.Width = 132;
            // 
            // NDTT
            // 
            this.NDTT.Caption = "Nội dung TT";
            this.NDTT.FieldName = "NDTT";
            this.NDTT.Name = "NDTT";
            this.NDTT.Visible = true;
            this.NDTT.VisibleIndex = 2;
            this.NDTT.Width = 164;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txt_nxb);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.txt_TuaSach);
            this.panelControl1.Controls.Add(this.txt_MaTuaSach);
            this.panelControl1.Controls.Add(this.txt_NDTT);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txtTenNXB);
            this.panelControl1.Controls.Add(this.txtMaNXB);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1142, 240);
            this.panelControl1.TabIndex = 0;
            // 
            // txt_nxb
            // 
            this.txt_nxb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nxb.Location = new System.Drawing.Point(590, 113);
            this.txt_nxb.Name = "txt_nxb";
            this.txt_nxb.ReadOnly = true;
            this.txt_nxb.Size = new System.Drawing.Size(235, 22);
            this.txt_nxb.TabIndex = 22;
            this.txt_nxb.TextChanged += new System.EventHandler(this.txt_nxb_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl5.Location = new System.Drawing.Point(500, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 15);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Nhà xuất bản";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::QLTV_Heni_4.Properties.Resources.traiphai;
            this.simpleButton3.Location = new System.Drawing.Point(394, 145);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(24, 20);
            this.simpleButton3.TabIndex = 20;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::QLTV_Heni_4.Properties.Resources.traiphai;
            this.simpleButton2.Location = new System.Drawing.Point(394, 111);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(24, 20);
            this.simpleButton2.TabIndex = 19;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl9.Location = new System.Drawing.Point(500, 190);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 15);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Tựa sách";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl8.Location = new System.Drawing.Point(500, 150);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 15);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Mã tựa sách";
            // 
            // txt_TuaSach
            // 
            this.txt_TuaSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TuaSach.ForeColor = System.Drawing.Color.Navy;
            this.txt_TuaSach.Location = new System.Drawing.Point(588, 186);
            this.txt_TuaSach.Name = "txt_TuaSach";
            this.txt_TuaSach.ReadOnly = true;
            this.txt_TuaSach.Size = new System.Drawing.Size(238, 22);
            this.txt_TuaSach.TabIndex = 15;
            // 
            // txt_MaTuaSach
            // 
            this.txt_MaTuaSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTuaSach.Location = new System.Drawing.Point(588, 146);
            this.txt_MaTuaSach.Name = "txt_MaTuaSach";
            this.txt_MaTuaSach.ReadOnly = true;
            this.txt_MaTuaSach.Size = new System.Drawing.Size(238, 22);
            this.txt_MaTuaSach.TabIndex = 14;
            // 
            // txt_NDTT
            // 
            this.txt_NDTT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NDTT.Location = new System.Drawing.Point(842, 136);
            this.txt_NDTT.Multiline = true;
            this.txt_NDTT.Name = "txt_NDTT";
            this.txt_NDTT.ReadOnly = true;
            this.txt_NDTT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_NDTT.Size = new System.Drawing.Size(295, 98);
            this.txt_NDTT.TabIndex = 13;
            this.txt_NDTT.Text = "\r\n";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl7.Location = new System.Drawing.Point(595, 81);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(109, 19);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Hiển thị kết quả";
            // 
            // panelControl3
            // 
            this.panelControl3.Location = new System.Drawing.Point(487, 92);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(2, 123);
            this.panelControl3.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl6.Location = new System.Drawing.Point(857, 111);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(133, 15);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Hiển thị nội dung tóm tắt";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(154, 145);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(234, 20);
            this.txtTenNXB.TabIndex = 7;
            this.txtTenNXB.EditValueChanged += new System.EventHandler(this.txtTenNXB_EditValueChanged);
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(154, 110);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(234, 20);
            this.txtMaNXB.TabIndex = 6;
            this.txtMaNXB.EditValueChanged += new System.EventHandler(this.txtMaNXB_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl4.Location = new System.Drawing.Point(42, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 19);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Tên NXB";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl3.Location = new System.Drawing.Point(42, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 19);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Mã NXB";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Location = new System.Drawing.Point(25, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(280, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nhập từ khóa cần tìm theo tiêu chí dưới :";
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(394, 39);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(401, 2);
            this.panelControl2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(438, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(313, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tra cứu thông tin nhà xuất bản";
            // 
            // grid_nxb
            // 
            this.grid_nxb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_nxb.Location = new System.Drawing.Point(0, 0);
            this.grid_nxb.MainView = this.gridView1;
            this.grid_nxb.Name = "grid_nxb";
            this.grid_nxb.Size = new System.Drawing.Size(744, 277);
            this.grid_nxb.TabIndex = 1;
            this.grid_nxb.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNXB,
            this.TenNXB,
            this.DiaChiNXB,
            this.DienThoaiNXB,
            this.Website});
            this.gridView1.GridControl = this.grid_nxb;
            this.gridView1.Name = "gridView1";
            // 
            // MaNXB
            // 
            this.MaNXB.Caption = "Mã NXB";
            this.MaNXB.FieldName = "MaNXB";
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.Visible = true;
            this.MaNXB.VisibleIndex = 0;
            this.MaNXB.Width = 85;
            // 
            // TenNXB
            // 
            this.TenNXB.Caption = "Tên nhà xuất bản";
            this.TenNXB.FieldName = "TenNXB";
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.Visible = true;
            this.TenNXB.VisibleIndex = 1;
            this.TenNXB.Width = 208;
            // 
            // DiaChiNXB
            // 
            this.DiaChiNXB.Caption = "Địa chỉ";
            this.DiaChiNXB.FieldName = "DiaChiNXB";
            this.DiaChiNXB.Name = "DiaChiNXB";
            this.DiaChiNXB.Visible = true;
            this.DiaChiNXB.VisibleIndex = 2;
            this.DiaChiNXB.Width = 179;
            // 
            // DienThoaiNXB
            // 
            this.DienThoaiNXB.Caption = "Điện thoại";
            this.DienThoaiNXB.FieldName = "DienThoaiNXB";
            this.DienThoaiNXB.Name = "DienThoaiNXB";
            this.DienThoaiNXB.Visible = true;
            this.DienThoaiNXB.VisibleIndex = 3;
            this.DienThoaiNXB.Width = 97;
            // 
            // Website
            // 
            this.Website.Caption = "Website";
            this.Website.FieldName = "Website";
            this.Website.Name = "Website";
            this.Website.Visible = true;
            this.Website.VisibleIndex = 4;
            this.Website.Width = 157;
            // 
            // tkNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "tkNhaXuatBan";
            this.Size = new System.Drawing.Size(1146, 540);
            this.Load += new System.EventHandler(this.tkNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).EndInit();
            this.splitContainerControlWin641.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nxb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraCharts.Wizard.SplitContainerControlWin64 splitContainerControlWin641;
        private DevExpress.XtraGrid.GridControl grid_sach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn MaTuaSach;
        private DevExpress.XtraGrid.Columns.GridColumn TuaSach;
        private DevExpress.XtraGrid.Columns.GridColumn NDTT;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txt_nxb;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txt_TuaSach;
        private System.Windows.Forms.TextBox txt_MaTuaSach;
        private System.Windows.Forms.TextBox txt_NDTT;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTenNXB;
        private DevExpress.XtraEditors.TextEdit txtMaNXB;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grid_nxb;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNXB;
        private DevExpress.XtraGrid.Columns.GridColumn TenNXB;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiNXB;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoaiNXB;
        private DevExpress.XtraGrid.Columns.GridColumn Website;
    }
}
