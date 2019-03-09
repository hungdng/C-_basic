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
    public partial class tkNhaXuatBan : UserControl
    {
        private NhaXuatBan_BLL nxbBUS = new NhaXuatBan_BLL();
        private void bin()
        {
            txt_nxb.DataBindings.Clear();
            txt_nxb.DataBindings.Add("Text", grid_nxb.DataSource, "MaNXB");
        }
        private void binding()
        {
            txt_MaTuaSach.DataBindings.Clear();
            txt_MaTuaSach.DataBindings.Add("Text", grid_sach.DataSource, "MaTuaSach");
            txt_TuaSach.DataBindings.Clear();
            txt_TuaSach.DataBindings.Add("Text", grid_sach.DataSource, "TuaSach");
            txt_NDTT.DataBindings.Clear();
            txt_NDTT.DataBindings.Add("Text", grid_sach.DataSource, "NDTT");
        }
        public tkNhaXuatBan()
        {
            InitializeComponent();
        }

        private void tkNhaXuatBan_Load(object sender, EventArgs e)
        {
            grid_nxb.DataSource = nxbBUS.LayDanhSachNXB();
            bin();
            grid_sach.DataSource = nxbBUS.LayDSSachTheoNXB(txt_nxb.Text);
            binding();
        }

        private void txtMaNXB_EditValueChanged(object sender, EventArgs e)
        {
            grid_nxb.DataSource = nxbBUS.Tim_NhaXuatBan(txtMaNXB.Text, txtTenNXB.Text);
            bin();
        }

        private void txtTenNXB_EditValueChanged(object sender, EventArgs e)
        {
            grid_nxb.DataSource = nxbBUS.Tim_NhaXuatBan(txtMaNXB.Text, txtTenNXB.Text);
            bin();
        }

        private void txt_nxb_TextChanged(object sender, EventArgs e)
        {
            grid_sach.DataSource = nxbBUS.LayDSSachTheoNXB(txt_nxb.Text);
            binding();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtMaNXB.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtTenNXB.Text = "";
        }
    }
}
