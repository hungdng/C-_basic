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
    public partial class Rp_PhieuNhapSach : UserControl
    {
        private PhieuNhap_BLL pnBUS = new PhieuNhap_BLL();
        public Rp_PhieuNhapSach()
        {
            InitializeComponent();
        }

        private void Rp_PhieuNhapSach_Load(object sender, EventArgs e)
        {
            reportNhapSachBindingSource.DataSource = pnBUS.Lay_Report("SELECT    convert(nvarchar(1000),ts.TuaSach)as tensachlau,convert(int,sum( ls.SoLuong))as soluongnhieu FROM  dbo.LOSACH AS ls INNER JOIN dbo.TUASACH AS ts ON ls.MaTuaSach = ts.MaTuaSach group by convert(nvarchar(1000),ts.TuaSach)");
            reportViewer1.RefreshReport();
        }



    }
}
