using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLTV_Heni_4.DAL;
using QLTV_Heni_4.DTO;

namespace QLTV_Heni_4.BLL
{
    class NhanVien_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Nhân Viên để hiển thị
        public DataTable LayDanhSachNhanVien()
        {
            string sql = "SELECT  MaNV, HoTenNV, (CASE GioiTinhNV WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhNV, NgaySinhNV, DienThoaiNV, DiaChiNV, EmailNV, NgayVaoLam,MatKhau, (CASE QuyenHan WHEN 'true' THEN N'Quản Lý' ELSE N'Nhân Viên' END) AS QuyenHan FROM NHANVIEN ORDER BY MaNV DESC";
            return connData.getdata(sql);
        }

        //Hàm Xem danh sách Nhân Viên (Không hiển thị mật khẩu)
        public DataTable XemDanhSachNhanVien()
        {
            string sql = "SELECT  MaNV, HoTenNV, (CASE GioiTinhNV WHEN 'True' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhNV, NgaySinhNV, DienThoaiNV, DiaChiNV, EmailNV, NgayVaoLam, (CASE QuyenHan WHEN 'True' THEN N'Quản Lý' ELSE N'Nhân Viên' END) AS QuyenHan FROM NHANVIEN ORDER BY MaNV DESC";
            return connData.getdata(sql);
        }

        //Hàm lấy thông tin bản thân
        public NhanVien_DTO LayThongTinBanThan(string MaNV)
        {
            string sql = "SELECT  MaNV, HoTenNV, (CASE GioiTinhNV WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhNV, NgaySinhNV, DienThoaiNV, DiaChiNV, EmailNV, NgayVaoLam, MatKhau, (CASE QuyenHan WHEN 'true' THEN N'Quản lý' ELSE N'Nhân viên' END) AS QuyenHan FROM NHANVIEN WHERE MaNV='" + MaNV + "'";
            DataTable dt = connData.getdata(sql);
            NhanVien_DTO ttnv = new NhanVien_DTO();
            DataRow rowTTNV = dt.Rows[0];
            ttnv.MaNV = rowTTNV["MaNV"].ToString();
            ttnv.HoTenNV = rowTTNV["HoTenNV"].ToString();
            ttnv.GioiTinhNV = (rowTTNV["GioiTinhNV"].ToString() == "Nữ") ? 1 : 0;
            ttnv.NgaySinhNV = Convert.ToDateTime(rowTTNV["NgaySinhNV"].ToString());
            ttnv.DienThoaiNV = rowTTNV["DienThoaiNV"].ToString();
            ttnv.DiaChiNV = rowTTNV["DiaChiNV"].ToString();
            ttnv.EmailNV = rowTTNV["EmailNV"].ToString();
         //   ttnv.NgayVaoLam = Convert.ToDateTime(rowTTNV["NgayVaoLam"].ToString());
            ttnv.QuyenHan = (rowTTNV["QuyenHan"].ToString() == "Nhân viên") ? 1 : 0;
            return ttnv;
        }

        //Lấy thông tin Nhân Viên cho Đăng nhập
        public NhanVien_DTO LayTTDangNhap(string MaNV)
        {
            string sql = "SELECT MaNV,HoTenNV, MatKhau, QuyenHan FROM NHANVIEN WHERE MaNV='" + MaNV + "'";
            DataTable tbUser = connData.getdata(sql);
            NhanVien_DTO user = new NhanVien_DTO();
            if (tbUser.Rows.Count > 0)
            {
                DataRow rowUser = tbUser.Rows[0];
                user.MaNV = rowUser["MaNV"].ToString();
                user.HoTenNV = rowUser["HoTenNV"].ToString();
                user.MatKhau = rowUser["MatKhau"].ToString();
                user.QuyenHan = (rowUser["QuyenHan"].ToString() == "True") ? 1 : 0;
            }
            else
            {
                user.MaNV = "";
                user.MatKhau = "";
                user.QuyenHan = 2;
            }
            return user;
        }

        //Đổi mật khẩu
        public bool DoiMatKhau(string matkhau)
        {
            string sql = "UPDATE NHANVIEN SET MatKhau='" + matkhau + "' WHERE MaNV='" + Utilities.user.MaNV + "'";
            if (connData.ThucThiSQL(sql))
                return true;
            return false;
        }

        // Lấy danh sách NV cho load sang ComboBox PM
        public DataTable LayDSNV()
        {
            string sql = "SELECT MaNV, HoTenNV FROM NHANVIEN";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(NhanVien_DTO nv)
        {
            if (nv.HoTenNV.Equals(""))
            {
                MessageBox.Show("Tên Nhân Viên không hợp lệ ! ");
                return false;
            }
            if (nv.NgaySinhNV.Equals(""))
            {
                MessageBox.Show("Ngày Sinh Nhân Viên không hợp lệ ! ");
                return false;
            }
            if (nv.NgayVaoLam.Equals(""))
            {
                MessageBox.Show("Ngày Vào Làm Nhân Viên không hợp lệ ! ");
                return false;
            }
            if (nv.QuyenHan.Equals(""))
            {
                MessageBox.Show("Quyền hạn không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Thêm Nhân Viên vào CSDL
        public bool ThemNV(NhanVien_DTO nv,byte[] arr)
        {
          //  MessageBox.Show("2");
            if (KiemTraTruocKhiLuu(nv))
            {
              //  MessageBox.Show("1");

                
                string sql = string.Format("INSERT INTO NHANVIEN (MaNV, HoTenNV, GioiTinhNV, NgaySinhNV, DienThoaiNV, DiaChiNV, EmailNV, NgayVaoLam, MatKhau, QuyenHan,AnhChup)"
                    + " VALUES ('{0}', N'{1}', {2}, '{3}',N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', {9},@pic)",
                    nv.MaNV, nv.HoTenNV, nv.GioiTinhNV, nv.NgaySinhNV, nv.DienThoaiNV, nv.DiaChiNV, nv.EmailNV, nv.NgayVaoLam, nv.MatKhau, nv.QuyenHan);
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
                MessageBox.Show("Thêm Nhân Viên thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }

        //Sửa Nhân Viên vào CSDL
        public bool SuaNV(NhanVien_DTO nv,byte[] arr)
        {
            if (KiemTraTruocKhiLuu(nv))
            {
                string sql = string.Format("UPDATE NHANVIEN SET HoTenNV=N'{1}', GioiTinhNV={2}, NgaySinhNV='{3}', DienThoaiNV='{4}', DiaChiNV=N'{5}', EmailNV='{6}', NgayVaoLam='{7}', MatKhau='{8}', QuyenHan={9},AnhChup=@pic WHERE MaNV='{0}'",
                    nv.MaNV, nv.HoTenNV, nv.GioiTinhNV, nv.NgaySinhNV, nv.DienThoaiNV, nv.DiaChiNV, nv.EmailNV, nv.NgayVaoLam, nv.MatKhau, nv.QuyenHan);

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
                MessageBox.Show("Sửa Nhân Viên thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return false;
        }

        //Xóa Nhân Viên trong CSDL
        public bool XoaNV(string MaNV)
        {
            string sql = "DELETE FROM NHANVIEN WHERE MaNV='" + MaNV + "'";
            string s = "select MaNV from NHANVIEN where QuyenHan='True'";
            string ss = "select MaNV,QuyenHan from NHANVIEN where MaNV='" + MaNV + "'";
            NhanVien_DTO nv = new NhanVien_DTO();
            DataTable tbQT = connData.getdata(s);
            DataTable tbNV = connData.getdata(ss);
            DataRow qt=tbNV.Rows[0];
      //      nv.QuyenHan = (qt["QuyenHan"].ToString() == "True") ? 1 : 0;
            if ((qt["QuyenHan"].ToString() == "True"))
            {
                if (tbQT.Rows.Count > 1)
                {
                    if (connData.ThucThiSQL(sql))
                    {
                        MessageBox.Show("Xóa Nhân Viên thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên quyền quản trị đang có duy nhất không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Xóa Nhân Viên thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return true;

        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("NHANVIEN", "MaNV"), "NV");
        }
        public string dem_NV()
        {
            string sql = "select COUNT(*) as tongnv from NHANVIEN";
            DataTable lm = connData.getdata(sql);
            DataRow g = lm.Rows[0];
            string t = g["tongnv"].ToString();
            return t;
        }
    }
}
