using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLTV_Heni_4.DTO
{
    class CTMuon_DTO
    {
        private string _id_CTMuon;

        public string id_CTMuon
        {
            get { return _id_CTMuon; }
            set { _id_CTMuon = value; }
        }
        private string _MaPhieuMuon;

        public string MaPhieuMuon
        {
            get { return _MaPhieuMuon; }
            set { _MaPhieuMuon = value; }
        }
        private string _MaSach;

        public string MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }
        private DateTime _NgayTra;

        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }


        private string _TinhTrangCTMuon;

        public string TinhTrangCTMuon
        {
            get { return _TinhTrangCTMuon; }
            set { _TinhTrangCTMuon = value; }
        }

    }
}
