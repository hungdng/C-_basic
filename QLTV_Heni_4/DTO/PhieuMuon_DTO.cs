using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTV_Heni_4.DTO;

namespace QLTV_Heni_4.DTO
{
    class PhieuMuon_DTO
    {
        private string _MaPhieuMuon;

        public string MaPhieuMuon
        {
            get { return _MaPhieuMuon; }
            set { _MaPhieuMuon = value; }
        }
        private string _MaDG;

        public string MaDG
        {
            get { return _MaDG; }
            set { _MaDG = value; }
        }

        private DateTime _NgayHenTra;

        public DateTime NgayHenTra
        {
            get { return _NgayHenTra; }
            set { _NgayHenTra = value; }
        }
        private DateTime _NgayTra;

        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }
        private DateTime _NgayMuon;

        public DateTime NgayMuon
        {
            get { return _NgayMuon; }
            set { _NgayMuon = value; }
        }
        private string _TinhTrangMuon;

        public string TinhTrangMuon
        {
            get { return _TinhTrangMuon; }
            set { _TinhTrangMuon = value; }
        }
        public NhanVien_DTO _NhanVien_DTO { get; set; }
        public DocGia_DTO _DocGia_DTO { get; set; }
    }
}
