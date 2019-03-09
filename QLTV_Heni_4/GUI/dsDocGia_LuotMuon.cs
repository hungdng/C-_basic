using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV_Heni_4.BLL;

namespace QLTV_Heni_4.GUI
{
    public partial class dsDocGia_LuotMuon : UserControl
    {
        private DocGia_BLL dgBUS = new DocGia_BLL();
        public dsDocGia_LuotMuon()
        {
            InitializeComponent();
        }

        private void dsDocGia_LuotMuon_Load(object sender, EventArgs e)
        {
            grid_docgia.DataSource = dgBUS.LuotMuon_DocGia();
            txt_tile.Text = (dgBUS.demDG_Luotmuon()) + "/" + dgBUS.demdocgia();
        }

        private void txtMaDG_EditValueChanged(object sender, EventArgs e)
        {
            grid_docgia.DataSource = dgBUS.TimKiem_DocGia_LuotMuon(txtMaDG.Text, txtTenDG.Text);
        }

        private void txtTenDG_EditValueChanged(object sender, EventArgs e)
        {
            grid_docgia.DataSource = dgBUS.TimKiem_DocGia_LuotMuon(txtMaDG.Text, txtTenDG.Text);
        }
    }
}
