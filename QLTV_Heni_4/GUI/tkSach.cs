using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using QLTV_Heni_4.DAL;
using System.IO;
using QLTV_Heni_4.BLL;

namespace QLTV_Heni_4.GUI
{
    public partial class tkSach : UserControl
    {
        private TuaSach_BLL tsBUS = new TuaSach_BLL();
        private TheLoai_BLL tlBUS = new TheLoai_BLL();
        private CuonSach_BLL csBUS = new CuonSach_BLL();
        ConnectDB conn = new ConnectDB();
        public tkSach()
        {
            InitializeComponent();
        }

        private void binding()
        {
            txt_MaTuaSach.DataBindings.Clear();
            txt_MaTuaSach.DataBindings.Add("Text", grid_ttsach.DataSource, "MaTuaSach");
            txt_TuaSach.DataBindings.Clear();
            txt_TuaSach.DataBindings.Add("Text", grid_ttsach.DataSource, "TuaSach");
            txt_NDTT.DataBindings.Clear();
            txt_NDTT.DataBindings.Add("Text", grid_ttsach.DataSource, "NDTT");
        }
        private void tkSach_Load(object sender, EventArgs e)
        {
            cboTheLoai.DataSource = tlBUS.LayDSTL();
            cboTheLoai.DisplayMember = "TenTL";
            cboTheLoai.ValueMember = "MaTL";

            grid_sach.DataSource = csBUS.LayDSTheoMa(txt_MaTuaSach.Text);
            grid_ttsach.DataSource = tsBUS.LayDS_TuaSach();
            cboTheLoai.SelectedIndex = -1;
            cboTheLoai.SelectedValue = "";
            binding();
            hien_anh();
        }

        private void txt_MaTuaSach_TextChanged(object sender, EventArgs e)
        {
            
            grid_sach.DataSource = csBUS.LayDSTheoMa(txt_MaTuaSach.Text);
            hien_anh();
        }
        private void hien_anh()
        {
            string sql = "select AnhBia from TUASACH where MaTuaSach='" + txt_MaTuaSach.Text + "'";
            SqlConnection cc = new SqlConnection(conn.strConnect);
            SqlCommand com = new SqlCommand(sql, cc);
            try
            {
                cc.Open();
                byte[] b = (byte[])com.ExecuteScalar(); // đọc dữ liệu kiểu byte 
                MemoryStream mem = new MemoryStream(b);
                pictureBox1.Image = Image.FromStream(mem);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                cc.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtMaTuaSach.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtTuaSach.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            cboTheLoai.SelectedIndex = -1;
            cboTheLoai.SelectedValue = "";
        }

        private void cboTheLoai_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtMaTuaSach_EditValueChanged(object sender, EventArgs e)
        {
            if (cboTheLoai.SelectedIndex == -1)
            {
                grid_ttsach.DataSource = tsBUS.TimKiem_TuaSach(txtMaTuaSach.Text, txtTuaSach.Text, "");
                binding();
            }
            else
            {
                grid_ttsach.DataSource = tsBUS.TimKiem_TuaSach(txtMaTuaSach.Text, txtTuaSach.Text, cboTheLoai.SelectedValue.ToString());
                binding();
            }
        }

        private void txtTuaSach_EditValueChanged(object sender, EventArgs e)
        {
            if (cboTheLoai.SelectedIndex == -1)
            {
                grid_ttsach.DataSource = tsBUS.TimKiem_TuaSach(txtMaTuaSach.Text, txtTuaSach.Text, "");
                binding();
            }
            else
            {
                grid_ttsach.DataSource = tsBUS.TimKiem_TuaSach(txtMaTuaSach.Text, txtTuaSach.Text, cboTheLoai.SelectedValue.ToString());
                binding();
            }
        }

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTheLoai.SelectedIndex == -1)
            {
                grid_ttsach.DataSource = tsBUS.TimKiem_TuaSach(txtMaTuaSach.Text, txtTuaSach.Text, "");
                binding();
            }
            else
            {
                grid_ttsach.DataSource = tsBUS.TimKiem_TuaSach(txtMaTuaSach.Text, txtTuaSach.Text, cboTheLoai.SelectedValue.ToString());
                binding();
            }

        }

    }
}
