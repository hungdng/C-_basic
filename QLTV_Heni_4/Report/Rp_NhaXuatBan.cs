using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV_Heni_4.Report;
using QLTV_Heni_4.BLL;

namespace QLTV_Heni_4.Report
{
    public partial class Rp_NhaXuatBan : UserControl
    {
        NhaXuatBan_BLL nxbBUS = new NhaXuatBan_BLL();
        public Rp_NhaXuatBan()
        {
            InitializeComponent();
        }

        private void Rp_NhaXuatBan_Load(object sender, EventArgs e)
        {
            nXBSOSACHBindingSource.DataSource = nxbBUS.LayDSNXB_Report_SL(txtSl.Text);
            txtNhanVien.Text = Utilities.user.HoTenNV;
            txtTongSo.Text = nxbBUS.dem_nxb();
            reportViewer1.RefreshReport();
        }


        private void txtSl_EditValueChanged(object sender, EventArgs e)
        {
            nXBSOSACHBindingSource.DataSource = nxbBUS.LayDSNXB_Report_SL(txtSl.Text);
            reportViewer1.RefreshReport();
        }

        private void txtSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
