namespace QLTV_Heni_4
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_ok = new DevExpress.XtraEditors.SimpleButton();
            this.bt_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.lblTrangThaiLogin = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl1.Location = new System.Drawing.Point(191, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(193, 27);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Đăng nhập hệ thống";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.Location = new System.Drawing.Point(143, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên đăng nhập :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl3.Location = new System.Drawing.Point(143, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Mật khẩu :";
            // 
            // txt_Name
            // 
            this.txt_Name.EditValue = "NV00000009";
            this.txt_Name.Location = new System.Drawing.Point(259, 53);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_Name.Properties.Appearance.Options.UseFont = true;
            this.txt_Name.Properties.Appearance.Options.UseForeColor = true;
            this.txt_Name.Size = new System.Drawing.Size(160, 20);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(161, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 1);
            this.panel1.TabIndex = 6;
            // 
            // bt_ok
            // 
            this.bt_ok.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ok.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.bt_ok.Appearance.Options.UseFont = true;
            this.bt_ok.Appearance.Options.UseForeColor = true;
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Location = new System.Drawing.Point(186, 160);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(88, 27);
            this.bt_ok.TabIndex = 3;
            this.bt_ok.Text = "OK";
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.bt_cancel.Appearance.Options.UseFont = true;
            this.bt_cancel.Appearance.Options.UseForeColor = true;
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(330, 160);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(74, 27);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancel";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.Black;
            this.txt_Pass.Location = new System.Drawing.Point(259, 92);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(160, 22);
            this.txt_Pass.TabIndex = 2;
            this.txt_Pass.Text = "12345";
            // 
            // lblTrangThaiLogin
            // 
            this.lblTrangThaiLogin.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiLogin.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTrangThaiLogin.Location = new System.Drawing.Point(167, 127);
            this.lblTrangThaiLogin.Name = "lblTrangThaiLogin";
            this.lblTrangThaiLogin.Size = new System.Drawing.Size(151, 15);
            this.lblTrangThaiLogin.TabIndex = 7;
            this.lblTrangThaiLogin.Text = "Trạng thái chưa đăng nhập !";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::QLTV_Heni_4.Properties.Resources.preferences_system_login;
            this.pictureEdit1.Location = new System.Drawing.Point(17, 15);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Size = new System.Drawing.Size(120, 134);
            this.pictureEdit1.TabIndex = 0;
            // 
            // DangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 206);
            this.Controls.Add(this.lblTrangThaiLogin);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit txt_Name;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblTrangThaiLogin;
        private DevExpress.XtraEditors.SimpleButton bt_ok;
        private DevExpress.XtraEditors.SimpleButton bt_cancel;
        public System.Windows.Forms.TextBox txt_Pass;
    }
}