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
using System.IO;
using QLTV_Heni_4.DAL;
using QLTV_Heni_4.BLL;
using QLTV_Heni_4.DTO;

namespace QLTV_Heni_4.GUI
{
    public partial class ttTuaSach : UserControl
    {
        private TuaSach_BLL tsBUS = new TuaSach_BLL();      
        private TheLoai_BLL tlBUS = new TheLoai_BLL();
        private TuSach_BLL tuBUS = new TuSach_BLL();
        ConnectDB conn = new ConnectDB();
        private TacGiaTuaSach_BLL tgtsBUS = new TacGiaTuaSach_BLL();
        private TacGia_BLL tgBUS = new TacGia_BLL();
        private bool add = false, update = false;

        private void cleantxt()
        {
            txtTuaSach.Text = "";
            txtNDTT.Text = "";
            cboTacGia.Text = "";
            cboTheLoai.Text = "";
            cboTuSach.Text = "";
        }
        private void binding()
        {
            txtMaTuaSach.DataBindings.Clear();
            txtMaTuaSach.DataBindings.Add("Text", grid_tuasach.DataSource, "MaTuaSach");
            txtTuaSach.DataBindings.Clear();
            txtTuaSach.DataBindings.Add("Text", grid_tuasach.DataSource, "TuaSach");
            txtNDTT.DataBindings.Clear();
            txtNDTT.DataBindings.Add("Text", grid_tuasach.DataSource, "NDTT");
            cboTheLoai.DataBindings.Clear();
            cboTheLoai.DataBindings.Add("EditValue", grid_tuasach.DataSource, "MaTL");
            cboTuSach.DataBindings.Clear();
            cboTuSach.DataBindings.Add("EditValue", grid_tuasach.DataSource, "MaTuSach");
// Tác giả sách
            lb_id.DataBindings.Clear();
            lb_id.DataBindings.Add("Text", grid_tacgiasach.DataSource, "id_tgs");
            cboMaTuaSach.DataBindings.Clear();
            cboMaTuaSach.DataBindings.Add("EditValue", grid_tacgiasach.DataSource, "MaTuaSach");
            cboTacGia.DataBindings.Clear();
            cboTacGia.DataBindings.Add("EditValue", grid_tacgiasach.DataSource, "MaTG");

        }
        //Lấy Thông tin tựa Sách
        private TuaSach_DTO LayTTTuaSach()
        {
            TuaSach_DTO s = new TuaSach_DTO();
            s.MaTuaSach = txtMaTuaSach.Text;
            s.TuaSach = txtTuaSach.Text;
            s.NDTT = txtNDTT.Text;
            s.MaTL = cboTheLoai.EditValue.ToString();
            s.MaTuSach = cboTuSach.EditValue.ToString();
            return s;
        }
        private TuaSach_DTO LayMaTuaSach()
        {
            TuaSach_DTO a = new TuaSach_DTO();
            a.MaTuaSach = txtMaTuaSach.Text;
            return a;
        }
        private TacGiaTuaSach_DTO LayTTTacGiaSach()
        {
            TacGiaTuaSach_DTO tgs = new TacGiaTuaSach_DTO();
            tgs.id_tgs = lb_id.Text;
            tgs.MaTuaSach = cboMaTuaSach.EditValue.ToString();
            tgs.MaTG = cboTacGia.EditValue.ToString();
            return tgs;
        }

        public ttTuaSach()
        {
            InitializeComponent();
        }



        private void ttTuaSach_Load(object sender, EventArgs e)
        {
            
            // Load combobox Mã tủ sách
            cboTuSach.Properties.DataSource = tuBUS.LayDSTS();
            cboTuSach.Properties.DisplayMember = "TuSach";
            cboTuSach.Properties.ValueMember = "MaTuSach";
            // Load combobox Mã tựa sách
            cboMaTuaSach.Properties.DataSource = tsBUS.LayDSTuaSach();
            cboMaTuaSach.Properties.DisplayMember = "TuaSach";
            cboMaTuaSach.Properties.ValueMember = "MaTuaSach";
            // Load combobox Mã TL
            cboTheLoai.Properties.DataSource = tlBUS.LayDSTL();
            cboTheLoai.Properties.DisplayMember = "TenTL";
            cboTheLoai.Properties.ValueMember = "MaTL";
            // Load combobox Mã TG
            cboTacGia.Properties.DataSource = tgBUS.LayDSTG();
            cboTacGia.Properties.DisplayMember = "HoTenTG";
            cboTacGia.Properties.ValueMember = "MaTG";

            //Load DataGrid
            TuaSach_DTO ts = LayMaTuaSach();
            grid_tuasach.DataSource = tsBUS.LayDanhSachTuaSach();
            grid_tacgiasach.DataSource = tgtsBUS.LayDSTGS(txtMaTuaSach.Text);
            panel_ts.Enabled = false;
            panel_tgs.Enabled = false;
            bt_themtgs.Enabled = true;
            bt_suatgs.Enabled = true;
            bt_xoatgs.Enabled = true;

            bt_themts.Enabled = true;
            bt_suats.Enabled = true;
            bt_xoats.Enabled = true;
            binding();
            hien_anh();
        }
        #region Them tựa sách
        private void bt_themts_Click(object sender, EventArgs e)
        {
            cleantxt();
            add = true; update = false;
            panel_ts.Enabled = true;
            panel_tgs.Enabled = false;
            bt_themts.Enabled = true;
            bt_suats.Enabled =false;
            bt_xoats.Enabled = false;
            txtMaTuaSach.Text = tsBUS.NextID();          
            txtTuaSach.Focus();
            pictureBox1.Image = global::QLTV_Heni_4.Properties.Resources.say_yes;
        }
        #endregion
        // Sửa tựa sách
        private void bt_suats_Click(object sender, EventArgs e)
        {
            add = false; update = true;
            panel_ts.Enabled = true;
            panel_tgs.Enabled = false;
            bt_themts.Enabled = false;
            bt_suats.Enabled = true;
            bt_xoats.Enabled = false;
            txtTuaSach.Focus();
        }

        private void bt_huyts_Click(object sender, EventArgs e)
        {
            ttTuaSach_Load(sender, e);
        }

        private void bt_huytgs_Click(object sender, EventArgs e)
        {
            ttTuaSach_Load(sender, e);
        }

        private void bt_xoats_Click(object sender, EventArgs e)
        {
            panel_ts.Enabled = false;
            panel_tgs.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa Sách : " + txtTuaSach.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(tsBUS.KiemTra(txtMaTuaSach.Text))
                {
                    MessageBox.Show("Bạn phải xóa những lô sách có mã tựa sách '" + txtMaTuaSach.Text + "' trong bảng lô Sách trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else{
                tsBUS.XoaTuaSach(txtMaTuaSach.Text);
                ttTuaSach_Load(sender, e);
                }
            }
        }
        // Lưu tựa sách
        private void bt_luuts_Click(object sender, EventArgs e)
        {
            TuaSach_DTO s = LayTTTuaSach();
            MemoryStream mstr = new MemoryStream();
            pictureBox1.Image.Save(mstr, pictureBox1.Image.RawFormat);
            arrImage = mstr.GetBuffer();
            if (add)
            {
                tsBUS.ThemTuaSach(s,arrImage);
                ttTuaSach_Load(sender, e);
            }
            if (update)
            {
                tsBUS.SuaTuaSach(s,arrImage);
                ttTuaSach_Load(sender, e);
            }
        }

        private void bt_themtgs_Click(object sender, EventArgs e)
        {
            
            panel_tgs.Enabled = true;
            add = true; update = false;
            bt_themtgs.Enabled = true;
            bt_suatgs.Enabled = false;
            bt_xoatgs.Enabled = false;
            cboMaTuaSach.EditValue = txtMaTuaSach.Text;
            cboTacGia.Text = "";
            lb_id.Text = tgtsBUS.NextID(); 
        }

        private void bt_suatgs_Click(object sender, EventArgs e)
        {
            add = false; update = true;
            cboMaTuaSach.Enabled = false;
            bt_themtgs.Enabled = false;
            bt_suatgs.Enabled = true;
            bt_xoatgs.Enabled = false;
            panel_tgs.Enabled = true;
        }
        public byte[] arrImage;
        private void bt_luutgs_Click(object sender, EventArgs e)
        {
            TacGiaTuaSach_DTO tgs = LayTTTacGiaSach();

            if (add)
            {
                tgtsBUS.ThemTGTS(tgs);
                ttTuaSach_Load(sender, e);
            }
            if (update)
            {
                tgtsBUS.SuaTGTS(tgs);
                ttTuaSach_Load(sender, e);
            }
        }

        private void bt_xoatgs_Click(object sender, EventArgs e)
        {
            TacGiaTuaSach_DTO tgs = LayTTTacGiaSach();
            panel_ts.Enabled = false;
            panel_tgs.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa tác giả của sách này không : " + cboMaTuaSach.EditValue.ToString() + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tgtsBUS.XoaTGTS(lb_id.Text);
            }
        }

        private void grid_tuasach_Click(object sender, EventArgs e)
        {
            panel_ts.Enabled = false;
            panel_tgs.Enabled = false;
        }

        private void panel_ts_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void txtMaTuaSach_TextChanged(object sender, EventArgs e)
        //{            
        //    grid_tacgiasach.DataSource = tgtsBUS.LayDSTGS(txtMaTuaSach.Text);
        //}
        string name;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Pictures|*.bmp;*.gif;*.jpg|Bitmaps|*.bmp|GIFs|*.gi f|JPEGs|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(dlg.FileName);
                name = dlg.FileName.Substring(dlg.FileName.LastIndexOf(@"\") + 1, dlg.FileName.Length - dlg.FileName.LastIndexOf(@"\") - 1);
            }
        }

        private void txtMaTuaSach_EditValueChanged(object sender, EventArgs e)
        {
            grid_tacgiasach.DataSource = tgtsBUS.LayDSTGS(txtMaTuaSach.Text);
            if (txtTuaSach.Text != "")
            {
                hien_anh();
            }
            else
            {
            }
        }
        private void hien_anh()
        {
            string sql = "select AnhBia from TUASACH where MaTuaSach='" + txtMaTuaSach.Text + "'";
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

       
    }
}
