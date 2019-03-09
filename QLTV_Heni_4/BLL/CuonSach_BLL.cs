using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLTV_Heni_4.DAL;
using QLTV_Heni_4.DTO;

namespace QLTV_Heni_4.BLL
{
    class CuonSach_BLL
    {
        ConnectDB connData = new ConnectDB();
        public bool SuaCS(CuonSach_DTO cs)
        {
            string sql = string.Format("UPDATE CUONSACH SET TinhTrangSach=N'{1}' WHERE MaSach='{0}'",
                cs.MaSach, cs.TinhTrangSach);
            connData.ThucThiSQL(sql);
            MessageBox.Show("Sửa tình trạng Sách thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
            return true;
        }
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("CUONSACH", "MaSach"), "CS");
        }
        public DataTable LayDSCuonSach()
        {
            string sql = "SELECT CUONSACH.MaSach,TUASACH.TuaSach FROM CUONSACH,LOSACH,TUASACH where CUONSACH.MaLoSach=LOSACH.MaLoSach and LOSACH.MaTuaSach=TUASACH.MaTuaSach";
            return connData.getdata(sql);
        }
        public DataTable LayDSTheoMa(string MaTuaSach)
        {
            string sql = "select MaSach,TenNXB,TinhTrangSach from CUONSACH,LOSACH,NHAXUATBAN where CUONSACH.MaLoSach=LOSACH.MaLoSach and LoSach.MaTuaSach='"+MaTuaSach+"' and LOSACH.MaNXB=NHAXUATBAN.MaNXB";
            return connData.getdata(sql);
        }

        public DataTable LayDSCS(string mls)
        {
            string df = "select MaSach,MaLoSach,TinhTrangSach from CUONSACH where MaLoSach='" + mls + "' ORDER BY MaSach DESC";
            DataTable d = connData.getdata(df);
            if (d.Rows.Count > 0)
            {
                return d;
            }
            else
            {
                string sql = " select MaSach,MaLoSach,TinhTrangSach from CUONSACH ORDER BY MaSach DESC";
                return connData.getdata(sql);
            }
        }

    }
}
