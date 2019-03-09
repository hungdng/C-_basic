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
    public partial class doimatkhau : UserControl
    {
        NhanVien_BLL nvBUS = new NhanVien_BLL();

        //Reset textbox
        public void cleantxt()
        {
            txt_passcu.Text = "";
            txt_passmoi.Text = "";
            txt_pass.Text = "";
        }
        public doimatkhau()
        {
            InitializeComponent();
        }

        //Kiểm tra Mật khẩu
        public bool KiemTra()
        {
        Cont:
            string oldPass = txt_passcu.Text;
            string newPass = txt_passmoi.Text;
            string reNewPass = txt_pass.Text;
            //Kiểm tra thông tin nhập trên Form đày đủ chưa
            if (oldPass == "" || newPass == "" || reNewPass == "")
            {
                lblThongBao.Text = "Bạn chưa điền đầy đủ các thông tin !";
                return false;
                goto Cont;
            }
            if (newPass != reNewPass)
            {
                lblThongBao.Text = "Mật khẩu mới không khớp nhau !";
                return false;
                goto Cont;
            }

            //Kiểm tra mật khẩu cũ có khớp không
            if (Utilities.user.MatKhau != oldPass)
            {
                lblThongBao.Text = "Mật khẩu cũ không đúng !";
                return false;
                goto Cont;
            }
            return true;
        }
        #region Khi nhấn đổi nhật khẩu
        private void bt_doimatkhau_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                nvBUS.DoiMatKhau(txt_passmoi.Text);
                MessageBox.Show("Đổi mật khẩu thành công !");
                lblThongBao.Text = "Đã đổi mật khẩu thành công !";
                cleantxt();
            }
        }
        #endregion
    }
}
