using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV_Heni_4.BLL;

namespace QLTV_Heni_4.Report
{
    public partial class Rp_NhanVien : UserControl
    {
        private NhanVien_BLL nvBUS = new NhanVien_BLL();
        public Rp_NhanVien()
        {
            InitializeComponent();
        }

        private void Rp_NhanVien_Load(object sender, EventArgs e)
        {
            txtNhanVien.Text = Utilities.user.HoTenNV;
            txtTongSo.Text = nvBUS.dem_NV();
            nHANVIENBindingSource.DataSource = nvBUS.LayDanhSachNhanVien();
            reportViewer1.RefreshReport();
        }

    }
}
