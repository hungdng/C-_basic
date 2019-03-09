using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLTV_Heni_4
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cd = txt_Name.Text.Length;
            if (cd > 9)
            {
                if (!Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {

        }


    }
}