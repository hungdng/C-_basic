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
    public partial class Rp_TuaSach : UserControl
    {
        TuaSach_BLL tsBUS = new TuaSach_BLL();
        public Rp_TuaSach()
        {
            InitializeComponent();
        }

        private void Rp_TuaSach_Load(object sender, EventArgs e)
        {
            bindingTuaSach.DataSource = tsBUS.Report_tuasach_sl(txtSl.Text);
            txtNhanVien.Text = Utilities.user.HoTenNV;
            txtTongSo.Text = tsBUS.demtuaduowc_muon();
            reportTuaSach.RefreshReport();
        }

        private void txtSl_EditValueChanged(object sender, EventArgs e)
        {
            bindingTuaSach.DataSource = tsBUS.Report_tuasach_sl(txtSl.Text);
            reportTuaSach.RefreshReport();
        }

        private void txtSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
