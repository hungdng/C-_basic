namespace QLTV_Heni_4.GUI
{
    partial class QuyDinhMuonTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuyDinhMuonTra));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl1.Location = new System.Drawing.Point(357, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(232, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Quy Định Mượn Trả Sách";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1000, 479);
            this.groupControl1.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl3.Location = new System.Drawing.Point(211, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(723, 299);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = resources.GetString("labelControl3.Text");
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(420, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(255, 28);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Quy định mượn - trả sách";
            // 
            // QuyDinhMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "QuyDinhMuonTra";
            this.Size = new System.Drawing.Size(1000, 479);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
