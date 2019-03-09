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
    public partial class tkTacGia : UserControl
    {
        private TacGia_BLL tgBUS = new TacGia_BLL();
        private void bin()
        {
            txt_TacGia.DataBindings.Clear();
            txt_TacGia.DataBindings.Add("Text", grid_tacgia.DataSource, "MaTG");
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

        public tkTacGia()
        {
            InitializeComponent();
        }

        private void tkTacGia_Load(object sender, EventArgs e)
        {
            grid_tacgia.DataSource = tgBUS.LayDanhSachTacGia();
            bin();
            grid_sach.DataSource = tgBUS.LayDSSachTheoTG(txt_TacGia.Text);
            binding();
        }

        private void txt_TacGia_TextChanged(object sender, EventArgs e)
        {
            grid_sach.DataSource = tgBUS.LayDSSachTheoTG(txt_TacGia.Text);
            binding();
        }

        private void txtMaTacGia_EditValueChanged(object sender, EventArgs e)
        {
            grid_tacgia.DataSource = tgBUS.Tim_TacGia(txtMaTacGia.Text, txtTenTG.Text);
            bin();
        }

        private void txtTenTG_EditValueChanged(object sender, EventArgs e)
        {
            grid_tacgia.DataSource = tgBUS.Tim_TacGia(txtMaTacGia.Text, txtTenTG.Text);
            bin();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtMaTacGia.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtTenTG.Text = "";
        }
    }
}
