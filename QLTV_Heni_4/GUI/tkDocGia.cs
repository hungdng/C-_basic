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
    public partial class tkDocGia : UserControl
    {
        private DocGia_BLL dgBUS = new DocGia_BLL();
        private void Binding()
        {
            txt_madocgia.DataBindings.Clear();
            txt_madocgia.DataBindings.Add("Text", grid_docgia.DataSource, "MaDG");
            txt_tendocgia.DataBindings.Clear();
            txt_tendocgia.DataBindings.Add("Text", grid_docgia.DataSource, "HoTenDG");
            txt_email.DataBindings.Clear();
            txt_email.DataBindings.Add("Text", grid_docgia.DataSource, "EmailDG");
            txt_ngaysinh.DataBindings.Clear();
            txt_ngaysinh.DataBindings.Add("Text", grid_docgia.DataSource, "NgaySinhDG");
            txt_dienthoai.DataBindings.Clear();
            txt_dienthoai.DataBindings.Add("Text", grid_docgia.DataSource, "DienThoaiDG");
            txt_ngayhethan.DataBindings.Clear();
            txt_ngayhethan.DataBindings.Add("Text", grid_docgia.DataSource, "NgayHetHan");
        }

        public tkDocGia()
        {
            InitializeComponent();
        }

        private void tkDocGia_Load(object sender, EventArgs e)
        {
            grid_docgia.DataSource = dgBUS.LayDanhSachDocGia();
            Binding();
            grid_phieumuon.DataSource = dgBUS.LayDS_PMTheoDG(txt_madocgia.Text);
        }

        private void txtMaDG_EditValueChanged(object sender, EventArgs e)
        {
            grid_docgia.DataSource = dgBUS.TimKiem_DocGia(txtMaDG.Text, txtTenDG.Text);
            Binding();
        }

        private void txtTenDG_EditValueChanged(object sender, EventArgs e)
        {
            grid_docgia.DataSource = dgBUS.TimKiem_DocGia(txtMaDG.Text, txtTenDG.Text);
            Binding();
        }

        private void txt_madocgia_TextChanged(object sender, EventArgs e)
        {
            grid_phieumuon.DataSource = dgBUS.LayDS_PMTheoDG(txt_madocgia.Text);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtMaDG.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtTenDG.Text = "";
        }


    }
}
