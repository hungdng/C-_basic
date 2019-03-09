using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTV_Heni_4.DTO;

namespace QLTV_Heni_4.DTO
{
    class LoSach_DTO
    {
        private string _MaLoSach;

        public string MaLoSach
        {
            get { return _MaLoSach; }
            set { _MaLoSach = value; }
        }
        private string _MaPhieuNhap;

        public string MaPhieuNhap
        {
            get { return _MaPhieuNhap; }
            set { _MaPhieuNhap = value; }
        }
        private string _MaTuaSach;

        public string MaTuaSach
        {
            get { return _MaTuaSach; }
            set { _MaTuaSach = value; }
        }
        private string _MaNXB;

        public string MaNXB
        {
            get { return _MaNXB; }
            set { _MaNXB = value; }
        }
        private string _NamXB;

        public string NamXB
        {
            get { return _NamXB; }
            set { _NamXB = value; }
        }

        private string _TaiBan;

        public string TaiBan
        {
            get { return _TaiBan; }
            set { _TaiBan = value; }
        }
        private string _SoLuong;

        public string SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private string _DonGia;

        public string DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }

        public PhieuNhap_DTO _PhieuNhap_DTO { get; set; }
        public TuaSach_DTO _TuaSach_DTO { get; set; }
        public NhaXuatBan_DTO _NhaXuatBan_DTO { get; set; }
    }
}
