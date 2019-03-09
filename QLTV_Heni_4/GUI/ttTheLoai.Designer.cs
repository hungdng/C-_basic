namespace QLTV_Heni_4.GUI
{
    partial class ttTheLoai
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grid_theloai = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.group_thongtin = new DevExpress.XtraEditors.GroupControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaTL = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bt_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_sua = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_theloai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_thongtin)).BeginInit();
            this.group_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(894, 507);
            this.groupControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grid_theloai);
            this.panelControl2.Controls.Add(this.group_thongtin);
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 78);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(890, 427);
            this.panelControl2.TabIndex = 2;
            // 
            // grid_theloai
            // 
            this.grid_theloai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_theloai.Location = new System.Drawing.Point(2, 203);
            this.grid_theloai.MainView = this.gridView1;
            this.grid_theloai.Name = "grid_theloai";
            this.grid_theloai.Size = new System.Drawing.Size(886, 222);
            this.grid_theloai.TabIndex = 3;
            this.grid_theloai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTL,
            this.TenTL,
            this.GhiChu});
            this.gridView1.GridControl = this.grid_theloai;
            this.gridView1.Name = "gridView1";
            // 
            // MaTL
            // 
            this.MaTL.Caption = "Mã thể loại";
            this.MaTL.FieldName = "MaTL";
            this.MaTL.Name = "MaTL";
            this.MaTL.Visible = true;
            this.MaTL.VisibleIndex = 0;
            this.MaTL.Width = 155;
            // 
            // TenTL
            // 
            this.TenTL.Caption = "Tên thể loại";
            this.TenTL.FieldName = "TenTL";
            this.TenTL.Name = "TenTL";
            this.TenTL.Visible = true;
            this.TenTL.VisibleIndex = 1;
            this.TenTL.Width = 333;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 2;
            this.GhiChu.Width = 334;
            // 
            // group_thongtin
            // 
            this.group_thongtin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.group_thongtin.Controls.Add(this.btnHuy);
            this.group_thongtin.Controls.Add(this.btnLuu);
            this.group_thongtin.Controls.Add(this.txtGhiChu);
            this.group_thongtin.Controls.Add(this.labelControl7);
            this.group_thongtin.Controls.Add(this.labelControl6);
            this.group_thongtin.Controls.Add(this.labelControl5);
            this.group_thongtin.Controls.Add(this.txtMaTL);
            this.group_thongtin.Controls.Add(this.txtTenTL);
            this.group_thongtin.Controls.Add(this.labelControl2);
            this.group_thongtin.Controls.Add(this.labelControl3);
            this.group_thongtin.Controls.Add(this.labelControl4);
            this.group_thongtin.Controls.Add(this.labelControl8);
            this.group_thongtin.Enabled = false;
            this.group_thongtin.Location = new System.Drawing.Point(142, 2);
            this.group_thongtin.Name = "group_thongtin";
            this.group_thongtin.Size = new System.Drawing.Size(743, 195);
            this.group_thongtin.TabIndex = 2;
            this.group_thongtin.Text = "Điền thông tin";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::QLTV_Heni_4.Properties.Resources.undo;
            this.btnHuy.Location = new System.Drawing.Point(590, 148);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 23);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::QLTV_Heni_4.Properties.Resources.save1;
            this.btnLuu.Location = new System.Drawing.Point(428, 148);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 23);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(460, 41);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(210, 73);
            this.txtGhiChu.TabIndex = 30;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(54, 120);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(176, 13);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = ": Vui lòng nhập Đầy đủ các Thông tin";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Location = new System.Drawing.Point(97, 85);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(14, 13);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "(*)";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(97, 45);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(14, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "(*)";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Enabled = false;
            this.txtMaTL.Location = new System.Drawing.Point(131, 41);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(210, 20);
            this.txtMaTL.TabIndex = 25;
            // 
            // txtTenTL
            // 
            this.txtTenTL.Location = new System.Drawing.Point(131, 81);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(210, 20);
            this.txtTenTL.TabIndex = 26;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Mã Thể Loại";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Tên Thể Loại";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(397, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Ghi Chú";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Location = new System.Drawing.Point(34, 120);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(14, 13);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "(*)";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.bt_xoa);
            this.groupControl2.Controls.Add(this.bt_sua);
            this.groupControl2.Controls.Add(this.bt_them);
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(134, 195);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Điều khiển";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.bt_xoa.Appearance.Options.UseFont = true;
            this.bt_xoa.Appearance.Options.UseForeColor = true;
            this.bt_xoa.Image = global::QLTV_Heni_4.Properties.Resources.DELETE;
            this.bt_xoa.Location = new System.Drawing.Point(16, 128);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(109, 33);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click_1);
            // 
            // bt_sua
            // 
            this.bt_sua.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.bt_sua.Appearance.Options.UseFont = true;
            this.bt_sua.Appearance.Options.UseForeColor = true;
            this.bt_sua.Image = global::QLTV_Heni_4.Properties.Resources.options;
            this.bt_sua.Location = new System.Drawing.Point(16, 81);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(109, 33);
            this.bt_sua.TabIndex = 1;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click_1);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Location = new System.Drawing.Point(302, 70);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(462, 2);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Location = new System.Drawing.Point(434, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(211, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Quản lý thể loại sách";
            // 
            // bt_them
            // 
            this.bt_them.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.bt_them.Appearance.Options.UseFont = true;
            this.bt_them.Appearance.Options.UseForeColor = true;
            this.bt_them.Image = global::QLTV_Heni_4.Properties.Resources.add;
            this.bt_them.Location = new System.Drawing.Point(16, 35);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(109, 33);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // ttTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ttTheLoai";
            this.Size = new System.Drawing.Size(894, 507);
            this.Load += new System.EventHandler(this.ttTheLoai_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_theloai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_thongtin)).EndInit();
            this.group_thongtin.ResumeLayout(false);
            this.group_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl group_thongtin;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt_xoa;
        private DevExpress.XtraEditors.SimpleButton bt_sua;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMaTL;
        private DevExpress.XtraEditors.TextEdit txtTenTL;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl grid_theloai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaTL;
        private DevExpress.XtraGrid.Columns.GridColumn TenTL;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraEditors.SimpleButton bt_them;
    }
}
