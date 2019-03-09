using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV_Heni_4.DTO;
using QLTV_Heni_4.BLL;

namespace QLTV_Heni_4.GUI
{
    public partial class ttTuSach : UserControl
    {
        private TuSach_BLL tuBUS = new TuSach_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            txtTuSach.Text = "";
            txtGhiChu.Text = "";
        }

        //Binding dữ liệu lên textbox
        public void binding()
        {
            txtMaTu.DataBindings.Clear();
            txtMaTu.DataBindings.Add("Text", grid_tusach.DataSource, "MaTuSach");
            txtTuSach.DataBindings.Clear();
            txtTuSach.DataBindings.Add("Text", grid_tusach.DataSource, "TuSach");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", grid_tusach.DataSource, "GhiChu");
        }

        //Lấy Thông tin Thể loại
        private TuSach_DTO LayTTTuSach()
        {
            TuSach_DTO tu = new TuSach_DTO();
            tu.MaTuSach = txtMaTu.Text;
            tu.TuSach = txtTuSach.Text;
            tu.GhiChu = txtGhiChu.Text;
            return tu;
        }


        private void ttTuSach_Load(object sender, EventArgs e)
        {
            grid_tusach.DataSource = tuBUS.LayDanhSachTuSach();
            group_thongtin.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            binding();
        }
        public ttTuSach()
        {
            InitializeComponent();
        }
        // Thêm
        private void bt_them_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            group_thongtin.Enabled = true;
            bt_them.Enabled = true;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            // Load NextID len textbox MaSV
            txtMaTu.Text = tuBUS.NextID();
            cleantxt();
            txtTuSach.Focus();
        }
// Sửa
        private void bt_sua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            group_thongtin.Enabled = true;
            bt_them.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = false;
            txtMaTu.Enabled = false;
            txtTuSach.Focus();
        }
// Xóa
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            group_thongtin.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa tủ sách : " + txtTuSach.Text + "  này không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tuBUS.KiemTra(txtMaTu.Text))
                {
                    MessageBox.Show("Bạn phải xóa những loại tựa sách có mã vị trí tủ sách: '" + txtMaTu.Text + "' trong bảng tựa Sách trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tuBUS.XoaTuSach(txtMaTu.Text);
                    ttTuSach_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TuSach_DTO ts = LayTTTuSach();
            if (add)
            {
                
                tuBUS.ThemTuSach(ts);
                
                ttTuSach_Load(sender, e);
            }
            if (update)
            {
                tuBUS.SuaTuSach(ts);
                ttTuSach_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ttTuSach_Load(sender, e);
        }

    }
}
