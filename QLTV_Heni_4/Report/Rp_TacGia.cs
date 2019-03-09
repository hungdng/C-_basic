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
    public partial class Rp_TacGia : UserControl
    {
        private TacGia_BLL tgBUS = new TacGia_BLL();
        public Rp_TacGia()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            txtNhanVien.Text = Utilities.user.HoTenNV;
            txtTongSo.Text = tgBUS.dem_tgSach();
            tGSOSACHBindingSource.DataSource = tgBUS.Report_tacgia_sl(txtSl.Text);
            reportViewer1.RefreshReport();
        }

        private void txtSl_EditValueChanged(object sender, EventArgs e)
        {
            tGSOSACHBindingSource.DataSource = tgBUS.Report_tacgia_sl(txtSl.Text);
            reportViewer1.RefreshReport();
        }

        private void txtSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
