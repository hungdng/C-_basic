using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLTV_Heni_4.DAL;
using QLTV_Heni_4.DTO;
using System.Windows.Forms;

namespace QLTV_Heni_4.BLL
{
    class CTMuon_BLL
    {
        ConnectDB connData = new ConnectDB();
        //Lấy Mã ts kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("CHITIET_MUON", "id_CTMuon"), "CTM");
        }
        public DataTable LayDSCTMuon( string maphieumuon)
        {
            string mp = "SELECT * FROM CHITIET_MUON where MaPhieuMuon='"+maphieumuon+"'";
            DataTable s = connData.getdata(mp);
            if (s.Rows.Count > 0)
            {
                return s;
            }
            else
            {
                string sql = "SELECT * FROM CHITIET_MUON ORDER BY id_CTMuon DESC";
                return connData.getdata(sql);
            }
        }
        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(CTMuon_DTO ct)
        {
            if (ct.MaPhieuMuon.Equals(""))
            {
                MessageBox.Show("Phiếu mượn sách không hợp lệ ! ");
                return false;
            }
            if (ct.MaSach.Equals(""))
            {
                MessageBox.Show("Độc giả không hợp lệ ! ");
                return false;
            }

            return true;
        }

        public bool XoaCTMuon(CTMuon_DTO ctm)
        {
           // string sql = "DELETE FROM CHITIET_MUON WHERE MaPhieuMuon='" + ctm.id_CTMuon + "'";
            string s = "select * from CHITIET_MUON";
            string h = "select * from CHITIET_MUON where MaPhieuMuon='" +ctm.MaPhieuMuon +"'";
            DataTable tbTL = connData.getdata(s);
            DataTable tbPM = connData.getdata(h);
            if (tbTL.Rows.Count > 1)
            {
                if (tbPM.Rows.Count > 1)
                {
                    string cs = "delete from CHITIET_MUON where id_CTMuon='" + ctm.id_CTMuon + "'";
                    connData.ThucThiSQL(cs);
                    MessageBox.Show("Xóa phiếu mượn thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;

                }
                else
                {
                    MessageBox.Show("Chi tiết phiếu mượn duy nhất của phiếu mượn có Mã :'" + ctm.MaPhieuMuon + "', xóa không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            MessageBox.Show("Xóa chi tiết phiếu mượn không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        // Luu
        public bool ThemCTMuon(CTMuon_DTO ctm)
        {
         if (KiemTraTruocKhiLuu(ctm))
            {
                string ct = "select * from CHITIET_MUON where MaPhieuMuon='"+ctm.MaPhieuMuon+"'";
                DataTable t = connData.getdata(ct);
                if (t.Rows.Count < 3)
                {
                    string sql = string.Format("INSERT INTO CHITIET_MUON (id_CTMuon,MaPhieuMuon,MaSach,NgayTra, TinhTrangCTMuon)" + " VALUES ('{0}', N'{1}', N'{2}', N'{3}',N'{4}')",
                    ctm.id_CTMuon,ctm.MaPhieuMuon, ctm.MaSach, ctm.NgayTra, ctm.TinhTrangCTMuon);
                    if (connData.ThucThiSQL(sql))
                    {
                        string fs = "update PHIEUMUON set TinhTrangMuon=N'Đang Mượn' where MaPhieuMuon='" + ctm.MaPhieuMuon + "'";
                        connData.ThucThiSQL(fs);
                        string tt = "Đã được mượn";
                        string s = string.Format("UPDATE CUONSACH SET TinhTrangSach=N'{1}' WHERE MaSach='{0}'",
                        ctm.MaSach, tt);
                        connData.ThucThiSQL(s);
                        MessageBox.Show("Thêm chi tiết phiếu mượn sách mới thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Phiếu mượn này đã mượn đủ 3 cuốn sách", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
         return false;
        }

        //Sua
        public bool SuaCTMuon(CTMuon_DTO ctm)
        {
            if (KiemTraTruocKhiLuu(ctm))
            {
                string sql = string.Format("UPDATE CHITIET_MUON SET MaSach=N'{1}'WHERE id_CTMuon='{0}'",
                    ctm.id_CTMuon, ctm.MaSach);
                string h = "Chưa đươc mượn";
                string j = "select MaSach from CHITIET_MUON where id_CTMuon='" + ctm.id_CTMuon + "'";
                DataTable jj = connData.getdata(j);
                CuonSach_DTO cs = new CuonSach_DTO();
                DataRow rowTTNV = jj.Rows[0];
                //     string f=cs.MaSach=rowTTNV["MaSach"].ToString();
                string g = string.Format("UPDATE CUONSACH SET TinhTrangSach=N'{1}' WHERE MaSach='{0}'", rowTTNV["MaSach"].ToString(), h);
                connData.ThucThiSQL(g);

                if (connData.ThucThiSQL(sql))
                {
                    string tt = "Đã được mượn";
                    string fg = string.Format("UPDATE CUONSACH SET TinhTrangSach=N'{1}' WHERE MaSach='{0}'", ctm.MaSach, tt);                    
                    connData.ThucThiSQL(fg);

                    MessageBox.Show("Sửa thông tin chi tiết phiếu mượn thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        public bool TraCTMuon(CTMuon_DTO ctm)
        {
            if (KiemTraTruocKhiLuu(ctm))
            {
             string sql = string.Format("UPDATE CHITIET_MUON SET NgayTra='{1}',TinhTrangCTMuon=N'{2}' WHERE id_CTMuon='{0}'",
            ctm.id_CTMuon, ctm.NgayTra, ctm.TinhTrangCTMuon);
             if (ctm.TinhTrangCTMuon == "Đã trả")
             {
                 if (connData.ThucThiSQL(sql))
                 {
                     string ts = "Chưa được mượn";
                     string g = string.Format("UPDATE CUONSACH SET TinhTrangSach=N'{1}' WHERE MaSach='{0}'", ctm.MaSach, ts);
                     connData.ThucThiSQL(g);
                     string h = "select * from CHITIET_MUON where MaPhieuMuon='"+ctm.MaPhieuMuon+"' and TinhTrangCTMuon= 'Đang mượn'";
                     DataTable hh = connData.getbang(h);
                     if (hh.Rows.Count > 0)
                     {
                     }
                     else
                     {
                         string ha = "update PHIEUMUON set TinhTrangMuon = N'Đã trả' where MaPhieuMuon='" + ctm.MaPhieuMuon + "'";
                         connData.ThucThiSQL(ha);
                     }

                     MessageBox.Show("Trả chi tiết phiếu mượn thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return true;
                 }
             }
             else
             {
                 if (connData.ThucThiSQL(sql))
                 {
                     string ts = "Đã mất";
                     string g = string.Format("UPDATE CUONSACH SET TinhTrangSach=N'{1}' WHERE MaSach='{0}'", ctm.MaSach, ts);
                     connData.ThucThiSQL(g); string h = "select * from CHITIET_MUON where MaPhieuMuon='" + ctm.MaPhieuMuon + "' and TinhTrangCTMuon= 'Đang mượn'";
                     DataTable hh = connData.getbang(h);
                     if (hh.Rows.Count > 0)
                     {
                     }
                     else
                     {
                         string ha = "update PHIEUMUON set TinhTrangMuon = N'Đã trả' where MaPhieuMuon='" + ctm.MaPhieuMuon + "'";
                         connData.ThucThiSQL(ha);
                     }
                     MessageBox.Show("Trả chi tiết phiếu mượn thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return true;
                 }
             }

            }
            return false;
        }
    }
}
