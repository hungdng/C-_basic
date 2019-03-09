using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTV_Heni_4.BLL;
using QLTV_Heni_4.DTO;

namespace QLTV_Heni_4.GUI
{
    public partial class ttCuonSach : UserControl
    {
        CuonSach_BLL csBUS = new CuonSach_BLL();
        LoSach_BLL lsBUS = new LoSach_BLL();


        private void bin()
        {
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", grid_sach.DataSource, "MaSach");
            MLSach.DataBindings.Clear();
            MLSach.DataBindings.Add("Text", grid_sach.DataSource, "MaLoSach");
            cboTinhTrang.DataBindings.Clear();
            cboTinhTrang.DataBindings.Add("EditValue", grid_sach.DataSource, "TinhTrangSach");

        }
        private void bin1()
        {
            txtMaLS.DataBindings.Clear();
            txtMaLS.DataBindings.Add("Text", grid_losach.DataSource, "MaLoSach");
            cboMTS.DataBindings.Clear();
            cboMTS.DataBindings.Add("EditValue", grid_losach.DataSource, "MaTuaSach");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", grid_losach.DataSource, "SoLuong");


        }
        public ttCuonSach()
        {
            InitializeComponent();
        }

        private void ttCuonSach_Load(object sender, EventArgs e)
        {
            
            grid_losach.DataSource = lsBUS.LayDSChoCuonSach();
            bin1();
            grid_sach.DataSource = csBUS.LayDSCS(txtMaLS.Text);
            bin();
         //   panel_ls.Enabled = false;
            panel_pn.Enabled = false;
            cboTinhTrang.Enabled = false;
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = false;
        }


        private void txtMaLS_EditValueChanged(object sender, EventArgs e)
        {
            grid_sach.DataSource = csBUS.LayDSCS(txtMaLS.Text);
            bin();
        }

        private CuonSach_DTO LayTT()
        {
            CuonSach_DTO cs = new CuonSach_DTO();
            cs.MaSach = txtMaSach.Text;
            cs.TinhTrangSach = cboTinhTrang.Text;
            return cs;
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            cboTinhTrang.Enabled = true;
            simpleButton1.Enabled = true;
            simpleButton2.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CuonSach_DTO cs = LayTT();
            csBUS.SuaCS(cs);
            ttCuonSach_Load(sender, e);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ttCuonSach_Load(sender, e);
        }

    }
}
