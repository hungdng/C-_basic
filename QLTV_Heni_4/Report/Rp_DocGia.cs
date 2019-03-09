using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QLTV_Heni_4;
using QLTV_Heni_4.BLL;

namespace QLTV_Heni_4.Report
{
    public partial class Rp_DocGia : UserControl
    {
        DocGia_BLL dgBUS = new DocGia_BLL();
        public Rp_DocGia()
        {
            InitializeComponent();
        }

        private void Rp_DocGia_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = dgBUS.Report_docgia_sl(txtSl.Text);
            txtNhanVien.Text = Utilities.user.HoTenNV;
            txtTongSo.Text = dgBUS.demDG_Luotmuon();
            reportDocGia.RefreshReport();
        }

        private void txtSl_EditValueChanged(object sender, EventArgs e)
        {
            bindingSource1.DataSource = dgBUS.Report_docgia_sl(txtSl.Text);
            reportDocGia.RefreshReport();
        }

        private void txtSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
