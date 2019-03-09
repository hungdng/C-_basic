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
    public partial class Rp_MuonQuaHan : UserControl
    {
        PhieuMuon_BLL pmBUS = new PhieuMuon_BLL();
        public Rp_MuonQuaHan()
        {
            InitializeComponent();
        }

        private void Rp_MuonQuaHan_Load(object sender, EventArgs e)
        {
            txtNhanVien.Text = Utilities.user.HoTenNV;
            bindingSource1.DataSource = pmBUS.Lay_report();
       //     this.report_QuaHanTableAdapter.Fill(qLTVDataSet_MuonSachQuaHan.Report_QuaHan);
            reportViewer1.RefreshReport();
        }
    }
}
