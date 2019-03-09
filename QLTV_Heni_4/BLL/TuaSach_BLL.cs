using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTV_Heni_4.DAL;
using QLTV_Heni_4.DTO;

namespace QLTV_Heni_4.BLL
{
    class TuaSach_BLL
    {
        ConnectDB connData = new ConnectDB();
        // Tìm kiếm sách
        public DataTable TimKiem_TuaSach(string MaTuaSach, string TuaSach, string MaTL)
        {
            string sql = "select MaTuaSach,TuaSach,TenTL,TongSoSach,SLCON,TuSach,NDTT from TT_TuaSach_Sach,THELOAI,TUSACH where TT_TuaSach_Sach.MaTL=THELOAI.MaTL and TT_TuaSach_Sach.MaTuSach=TUSACH.MaTuSach";
            string sq ="";
            if (MaTuaSach != "" && TuaSach=="" && MaTL=="")
            {
                sq = sql+ " and TT_TuaSach_Sach.MaTuaSach like N'%"+MaTuaSach+"%'";
            }
            if (MaTuaSach == "" && TuaSach != "" && MaTL == "")
            {
                sq = sql + " and TT_TuaSach_Sach.TuaSach like N'%" + TuaSach + "%'";
            }
            if (MaTuaSach == "" && TuaSach == "" && MaTL != "")
            {
                sq = sql + " and TT_TuaSach_Sach.MaTL ='" + MaTL + "'";
            }
            if (MaTuaSach != "" && TuaSach != "" && MaTL == "")
            {
                sq = sql + " and TT_TuaSach_Sach.MaTuaSach like N'%" + MaTuaSach + "%' and TT_TuaSach_Sach.TuaSach like N'%" + TuaSach + "%'";
            }
            if(MaTuaSach!="" && TuaSach=="" && MaTL!="")
            {
                sq = sql + " and TT_TuaSach_Sach.MaTuaSach like N'%" + MaTuaSach + "%' and TT_TuaSach_Sach.MaTL ='" + MaTL + "'";
            }
            if (MaTuaSach == "" && TuaSach != "" && MaTL != "")
            {
                sq = sql + " and TT_TuaSach_Sach.TuaSach like N'%" + TuaSach + "%' and TT_TuaSach_Sach.MaTL ='" + MaTL + "'";
            }
            if (MaTuaSach != "" && TuaSach != "" && MaTL != "")
            {
                sq = sql + " and TT_TuaSach_Sach.MaTuaSach like N'%" + MaTuaSach + "%' and TT_TuaSach_Sach.TuaSach like N'%" + TuaSach + "%' and TT_TuaSach_Sach.MaTL='" + MaTL + "'";
            }
            if (MaTuaSach == "" && TuaSach == "" && MaTL == "")
            {
                sq = sql;
            }




            DataTable ts = connData.getdata(sq);
            if (ts.Rows.Count > 0)
            {
                return ts;
            }
            else
            {
                return connData.getdata(sql);
            }

        }

        // có số lượng sách còn
        public DataTable LayDS_TuaSach()
        {
            string sql = "select MaTuaSach,TuaSach,TenTL,TongSoSach,SLCON,TuSach,NDTT from TT_TuaSach_Sach,THELOAI,TUSACH where TT_TuaSach_Sach.MaTL=THELOAI.MaTL and TT_TuaSach_Sach.MaTuSach=TUSACH.MaTuSach";
            return connData.getdata(sql);
        }



        //Hàm lấy tất cả danh sách Sách để hiển thị

        public DataTable LayDanhSachTuaSach()
        {
            string sql = " SELECT MaTuaSach, TuaSach, NDTT,MaTL, MaTuSach FROM TUASACH ORDER BY MaTuaSach DESC";
            return connData.getdata(sql);
        }

        //Hàm lấy tất cả danh sách Sách để hiển thị cho Reports
        public DataTable LayDSTuaSachReport()
        {
            string sql = " SELECT MaTuaSach, TuaSach,MaTL,MaTuSach FROM TUASACH";
            return connData.getdata(sql);
        }

        // Lấy danh sách Sách load lên Combobox
        public DataTable LayDSTuaSach()
        {
            string sql = "SELECT MaTuaSach, TuaSach FROM TUASACH";
            return connData.getdata(sql);
        }

        // Lấy danh sách Sách theo PM
        public DataTable LayDSTuaSachTheoPM(string MaPhieu)
        {
            string sql = "SELECT MaPhieu, MaTuaSach FROM CT_PHIEUMUON WHERE MaPhieu='" + MaPhieu + "'";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TuaSach_DTO s)
        {
            if (s.TuaSach.Equals(""))
            {
                MessageBox.Show("Tên Sách không hợp lệ ! ");
                return false;
            }
            if (s.MaTL.Equals(""))
            {
                MessageBox.Show("Thể loại không hợp lệ ! ");
                return false;
            }
            if (s.MaTuSach.Equals(""))
            {
                MessageBox.Show("Vị trí không hợp lệ ! ");
                return false;
            }

            return true;
        }

        //Thêm Sách vào CSDL
        public bool ThemTuaSach(TuaSach_DTO s,byte[] arr)
        {
            if (KiemTraTruocKhiLuu(s))
            {
                string sql = string.Format("INSERT INTO TUASACH (MaTuaSach, TuaSach, MaTL, NDTT,MaTuSach,AnhBia)"
                    + " VALUES ('{0}', N'{1}', N'{2}', '{3}','{4}',@pic)",
                    s.MaTuaSach, s.TuaSach, s.MaTL, s.NDTT,s.MaTuSach);
                SqlConnection c = new SqlConnection(connData.strConnect);
                SqlCommand comm = new SqlCommand(sql, c);
                comm.Parameters.Add(new SqlParameter("@pic", SqlDbType.Image)).Value = arr;

                try
                {
                    c.Open();
                    comm.ExecuteNonQuery();
                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    c.Close();
                }
                MessageBox.Show("Thêm tựa sách thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            return false;
        }

        //Sửa Sách vào CSDL
        public bool SuaTuaSach(TuaSach_DTO s,byte[] arr)
        {
            if (KiemTraTruocKhiLuu(s))
            {
                string sql = string.Format("UPDATE TUASACH SET TuaSach=N'{1}', MaTL=N'{2}', NDTT='{3}',MaTuSach='{4}',AnhBia=@pic WHERE MaTuaSach='{0}'",
                    s.MaTuaSach, s.TuaSach,  s.MaTL, s.NDTT,s.MaTuSach);
                SqlConnection c = new SqlConnection(connData.strConnect);
                SqlCommand comm = new SqlCommand(sql, c);
                comm.Parameters.Add(new SqlParameter("@pic", SqlDbType.Image)).Value = arr;

                try
                {
                    c.Open();
                    comm.ExecuteNonQuery();
                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    c.Close();
                }
                MessageBox.Show("Sửa thông tin Sách thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return false;
        }

        //Xóa Sách trong CSDL
        public bool XoaTuaSach(string MaTuaSach)
        {
            string sql = "DELETE FROM TUASACH WHERE MaTuaSach='" + MaTuaSach + "'";
            string s = "select * from TUASACH";
            DataTable tbTL = connData.getdata(s);
            if (tbTL.Rows.Count > 1)
            {
                if (connData.ThucThiSQL(sql))
                {
                    string f = "delete from TACGIASACH where MaTuaSach ='"+MaTuaSach+"'";
                    connData.ThucThiSQL(f);
                    MessageBox.Show("Xóa thông tin tựa Sách thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            MessageBox.Show("Tựa sách cuối cùng không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        //Kiểm tra tồn tại của Mã tựa sách
        public bool KiemTra(string mts)
        {
            if (connData.KiemTraTonTai("LOSACH", "MaTuaSach", mts))
                return true;
            return false;
        }
        //Lấy Mã ts kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("TUASACH", "MaTuaSach"), "TS");
        }

        //Tim kiem sach theo Tieu Chi
        public DataTable TimKiemTuaSach(string DieuKien, string TieuChi)
        {
            string sql = " SELECT MaTuaSach, TuaSach, MaTL, NDTT FROM TUASACH WHERE " + DieuKien + " LIKE N'%" + TieuChi + "%'";
            return connData.getdata(sql);
        }

        // Lượt mượn sách

        public DataTable LuotMuonSach()
        {
            string sql = "select MaTuaSach,TuaSach,TenTL,TuSach,NDTT,Tong_LanMuon from LuotMuon_TuaSach,THELOAI,TUSACH where LuotMuon_TuaSach.MaTL=THELOAI.MaTL and LuotMuon_TuaSach.MaTuSach=TUSACH.MaTuSach ORDER BY Tong_LanMuon DESC";
            return connData.getdata(sql);
        }

        // Đếm tỗng tựa
        public string demtuasach()
        {
            string sql = "select COUNT(*) as tongts from TUASACH";
            DataTable lm = connData.getdata(sql);
            DataRow g = lm.Rows[0];
            string t = g["tongts"].ToString();
            return t;
        }
        //tựa được mượn
        public string demtuaduowc_muon()
        {
            string sql = "select COUNT(*) as tongts from LuotMuon_TuaSach";
            DataTable lm = connData.getdata(sql);
            DataRow g = lm.Rows[0];
            string t = g["tongts"].ToString();
            return t;
        }
        public DataTable TimKiem_Tuasach_LuotMuon(string MaTS, string Ts)
        {
            string sql = "select MaTuaSach,TuaSach,TenTL,TuSach,NDTT,Tong_LanMuon from LuotMuon_TuaSach,THELOAI,TUSACH where LuotMuon_TuaSach.MaTL=THELOAI.MaTL and LuotMuon_TuaSach.MaTuSach=TUSACH.MaTuSach ";
            string h = "select MaTuaSach,TuaSach,TenTL,TuSach,NDTT,Tong_LanMuon from LuotMuon_TuaSach,THELOAI,TUSACH where LuotMuon_TuaSach.MaTL=THELOAI.MaTL and LuotMuon_TuaSach.MaTuSach=TUSACH.MaTuSach ORDER BY Tong_LanMuon DESC";

            string d = "";
            if (MaTS == "" && Ts == "")
            {
                d = sql;
            }
            if (MaTS != "" && Ts == "")
            {
                d = sql + " where MaTuaSach like N'%" + MaTS + "%' ORDER BY Tong_LanMuon DESC";
            }
            if (MaTS == "" && Ts != "")
            {
                d = sql + " where TuaSach like N'%" + Ts + "%' ORDER BY Tong_LanMuon DESC";
            }
            if (MaTS != "" && Ts != "")
            {
                d = sql + " where MaTuaSach like N'%" + MaTS + "%' and TuaSach like N'%" + Ts + "%' ORDER BY Tong_LanMuon DESC";
            }

            DataTable t = connData.getdata(d);
            if (t.Rows.Count > 0)
            {
                return t;
            }
            else
            {
                return connData.getdata(h);
            }
        }

        public DataTable Report_tuasach_sl(string sl)
        {
            string sql = "SELECT * from report_tuasach ORDER BY Tong_LanMuon DESC";
            string d;
            if (sl != "")
            {
                int s = Convert.ToInt32(sl);
                d = "SELECT TOP " + s + " * from report_tuasach ORDER BY Tong_LanMuon DESC";
            }
            else
            {
                d = "SELECT * from report_tuasach ORDER BY Tong_LanMuon DESC";
            }
            DataTable t = connData.getdata(d);
            if (t.Rows.Count > 0)
            {
                return t;
            }
            else
            {
                return connData.getdata(sql);
            }
        }
    }
}
